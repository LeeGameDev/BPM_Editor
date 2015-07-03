using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BPM_Editor
{
    public partial class Form1 : Form
    {
        private string songsFolder = "";
        private Beatmap selectedBeatmap = null;
        private List<string> difficulties = new List<string>();
        private List<string> difficultyNames = new List<string>();
        private List<String> hitObjects = new List<string>();
        private List<String> newHitObjects = new List<string>();

        private byte TITLE_MASK = 1;
        private byte ARTIST_MASK = 2;
        private byte SOURCE_MASK = 4;
        private byte VERSION_MASK = 8;
        private byte CREATOR_MASK = 16;

        private byte OD_MASK = 1;
        private byte AR_MASK = 2;
        private byte CS_MASK = 4;
        private byte HP_MASK = 8;

        private byte TYPE_CIRCLE = 1;
        private byte TYPE_SLIDER = 2;
        private byte TYPE_SPINNER = 8;

        private byte TYPE_CIRCLE_NEW_COMBO = 5;
        private byte TYPE_SLIDER_NEW_COMBO = 6;
        private byte TYPE_SPINNER_NEW_COMBO = 12;

        public Form1()
        {
            InitializeComponent();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            //string pathAndFileName = selectedBeatmap.FileAddr + tbDifficultyName;
            //WriteBeatmapFile(pathAndFileName, hitObjects);
            float newBpm = 0.0f;
            if (float.TryParse(tbBPM.Text, out newBpm))
            {
                AdjustHitObjects(186.0f, newBpm, hitObjects, newHitObjects);
            }
        }

        private string AdjustCircle(float oldBpm, float newBpm, string[] tokens)
        {
            // Tokens: x, y, time, type | comboColour, hitSound, addition (optional)

            // Compute new time
            int time = Int32.Parse(tokens[2]);
            int newTime = (int)(time / (newBpm / oldBpm));

            // Consolidate new hitObject
            string newCircle = tokens[0] + "," + tokens[1] + "," + newTime + "," + tokens[3] + "," + tokens[4];
            newHitObjects.Add(newCircle);

            return newCircle;
        }
        private string AdjustSlider(float oldBpm, float newBpm, string[] tokens)
        {
            // Tokens: x, y, time, type | comboColour, hitSound,
            // sliderType|curveX:curveY|..., repeat, pixelLength, edgeHitsound, edgeAddition (optional), addition (optional)

            // Compute new time
            int time = Int32.Parse(tokens[2]);
            int newTime = (int)(time / (newBpm / oldBpm));

            // Consolidate new hitObject
            string newSlider = tokens[0] + "," + tokens[1] + "," + newTime;
            for (int i = 3; i < tokens.Length; i++)
            {
                newSlider += "," + tokens[i];
            }

            newHitObjects.Add(newSlider);

            return newSlider;
        }
        private string AdjustSpinner(float oldBpm, float newBpm, string[] tokens)
        {
            // Tokens: x, y, time, type | comboColour, hitSound, endTime, addition (optional)

            // Compute new time & end time
            float bpmRatio = newBpm / oldBpm;

            int time = Int32.Parse(tokens[2]);
            int newTime = (int)(time / bpmRatio);

            int endTime = Int32.Parse(tokens[5]);
            int newEndTime = (int)(endTime / bpmRatio);

            // Consolidate new hitObject
            string newSpinner = tokens[0] + "," + tokens[1] + "," + newTime + "," + tokens[3] + "," + tokens[4] + newEndTime;
            newHitObjects.Add(newSpinner);

            return newSpinner;
        }
        private void AdjustHitObjects(float oldBpm, float newBpm, List<string> oldHitObjects, List<string> newHitObjects)
        {
            // Reading hitobjects
            newHitObjects.Clear();
            for (int i = 0; i < hitObjects.Count; i++)
            {
                // Get the hit object type
                string[] tokens = hitObjects[i].Split(',');
                byte hitObjectType = Byte.Parse(tokens[3]);
                
                // Adjust the hit object to the new bpm based on its type
                if (hitObjectType == TYPE_CIRCLE || hitObjectType == TYPE_CIRCLE_NEW_COMBO)
                {
                    AdjustCircle(oldBpm, newBpm, tokens);
                }
                else if (hitObjectType == TYPE_SLIDER || hitObjectType == TYPE_SLIDER_NEW_COMBO)
                {
                    AdjustSlider(oldBpm, newBpm, tokens);
                }
                else if (hitObjectType == TYPE_SPINNER || hitObjectType == TYPE_SPINNER_NEW_COMBO)
                {
                    AdjustSpinner(oldBpm, newBpm, tokens);
                }
            }
        }

        private void WriteBeatmapFile(string pathAndFileName, List<String> lines)
        {
            using (StreamWriter sw = new StreamWriter(pathAndFileName, false))
            {
                for (int i = 0; i < lines.Count; i++)
                {
                    sw.WriteLine(lines[i]);
                }
            }
        }

        private void ParseBeatmapFile(string path)
        {
            if (selectedBeatmap == null)
            {
                selectedBeatmap = new Beatmap();
            }
            selectedBeatmap.ClearData();

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    bool readingMetadata = true;

                    // Metadata checksum
                    int dataFound = 0;
                    int difficultyDataFound = 0;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (readingMetadata)
                        {
                            // Done reading metadata
                            if (line.Contains("[HitObjects]"))
                            {
                                readingMetadata = false;
                            }
                            else
                            {
                                string[] tokens = line.Split(':');
                                if (tokens.Length > 1)
                                {
                                    string key = tokens[0];
                                    string value = tokens[1].Trim();

                                    if (((dataFound & TITLE_MASK) == 0) && key.Contains("Title"))
                                    {
                                        selectedBeatmap.Title = value;
                                        dataFound |= TITLE_MASK;
                                    }
                                    else if (((dataFound & ARTIST_MASK) == 0) && key.Contains("Artist"))
                                    {
                                        selectedBeatmap.Artist = value;
                                        dataFound |= ARTIST_MASK;
                                    }
                                    else if (((dataFound & SOURCE_MASK) == 0) && key.Contains("Source"))
                                    {
                                        selectedBeatmap.Source = value;
                                        dataFound |= SOURCE_MASK;
                                    }
                                    else if (((dataFound & VERSION_MASK) == 0) && key.Contains("Version"))
                                    {
                                        selectedBeatmap.Version = value;
                                        dataFound |= VERSION_MASK;
                                    }
                                    else if (((dataFound & CREATOR_MASK) == 0) && key.Contains("Creator"))
                                    {
                                        selectedBeatmap.Creator = value;
                                        dataFound |= CREATOR_MASK;
                                    }
                                    else if (((difficultyDataFound & OD_MASK) == 0) && key.Contains("OverallDifficulty"))
                                    {
                                        selectedBeatmap.OverallDifficulty = float.Parse(value);
                                        difficultyDataFound |= OD_MASK;
                                    }
                                    else if (((difficultyDataFound & AR_MASK) == 0) && key.Contains("ApproachRate"))
                                    {
                                        selectedBeatmap.ApproachRate = float.Parse(value);
                                        difficultyDataFound |= AR_MASK;
                                    }
                                    else if (((difficultyDataFound & CS_MASK) == 0) && key.Contains("CircleSize"))
                                    {
                                        selectedBeatmap.CircleSize = float.Parse(value);
                                        difficultyDataFound |= CS_MASK;
                                    }
                                    else if (((difficultyDataFound & HP_MASK) == 0) && key.Contains("HPDrainRate"))
                                    {
                                        selectedBeatmap.HPDrainRate = float.Parse(value);
                                        difficultyDataFound |= HP_MASK;
                                    }
                                }
                            }
                        }
                        else
                        {
                            // Reading HitObjects
                            hitObjects.Add(line);
                        }
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // Update UI with data
            UpdateUI();
        }

        private void UpdateUI()
        {
            // Metadata
            lblSelectedBeatmap.Text = selectedBeatmap.Source + " (" +
                selectedBeatmap.Artist + ") - " +
                selectedBeatmap.Title + " [" +
                selectedBeatmap.Version + "]";

            lblCreator.Text = selectedBeatmap.Creator;
            tbCreator.Text = selectedBeatmap.Creator;
            tbDifficultyName.Text = selectedBeatmap.Version;

            // Difficulty
            tbOD.Text = selectedBeatmap.OverallDifficulty.ToString();
            tbAR.Text = selectedBeatmap.ApproachRate.ToString();
            tbCS.Text = selectedBeatmap.CircleSize.ToString();
            tbHPDrain.Text = selectedBeatmap.HPDrainRate.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show dialog
            DialogResult dr = ofdSelectBeatmap.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // Check extension ending
                string extension = Path.GetExtension(ofdSelectBeatmap.FileName);
                if (extension.ToLower() == ".osu")
                {
                    // Parse beatmap for metadata
                    ParseBeatmapFile(ofdSelectBeatmap.FileName);
                }
            }
        }

        private void setSongDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Show dialog
            DialogResult dr = fbdSongs.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                songsFolder = fbdSongs.SelectedPath;
                ProcessSongsFolder(songsFolder);
            }
        }

        private void ProcessSongsFolder(string path)
        {
            // Get a collection of folder names for the list box
            List<string> beatmapFolders = new List<string>(Directory.EnumerateDirectories(path).Select(folder => new DirectoryInfo(folder).Name));
            lbBeatmaps.DataSource = beatmapFolders;
            lbBeatmaps.SelectedIndex = 0;
        }

        private void lbBeatmaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDifficulties();
        }

        private void UpdateDifficulties()
        {
            string difficultiesPath = songsFolder + Path.DirectorySeparatorChar + lbBeatmaps.GetItemText(lbBeatmaps.SelectedItem);
            
            difficulties = new List<string>(Directory.EnumerateFiles(difficultiesPath).
                Select(file => new DirectoryInfo(file).Name).
                Where(file => Path.GetExtension(file).Contains(".osu")));

            difficultyNames = new List<string>(difficulties);

            ProcessDifficultiesForUI();
        }

        private void ProcessDifficultiesForUI()
        {
            for (int i = 0; i < difficulties.Count; i++)
            {
                string difficulty = difficulties[i];
                int indexOfOpenBrace = difficulty.IndexOf('[');
                int indexOfCloseBrace = difficulty.IndexOf(']') + 1;
                difficulties[i] = difficulty.Substring(indexOfOpenBrace, indexOfCloseBrace - indexOfOpenBrace);
            }

            lbDifficulties.DataSource = difficulties;
        }

        private void lbDifficulties_SelectedIndexChanged(object sender, EventArgs e)
        {
            ParseBeatmapFile(songsFolder + Path.DirectorySeparatorChar +
                lbBeatmaps.GetItemText(lbBeatmaps.SelectedItem) + Path.DirectorySeparatorChar + 
                difficultyNames[lbDifficulties.SelectedIndex]);
        }
    }
}
