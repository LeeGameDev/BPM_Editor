using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu_Beatmap_Editor
{
    public partial class Form1 : Form
    {
        private string songsFolder = "";
        private Beatmap selectedBeatmap = null;
        
        private List<string> beatmapFolders = new List<string>();           // Complete list
        private List<string> beatmapNames = new List<string>();             // Used for UI only
        private List<string> difficulties = new List<string>();             // Complete list
        private List<string> difficultyNames = new List<string>();          // Used for UI only

        private List<String> hitObjects = new List<string>();
        private List<String> newHitObjects = new List<string>();

        #region Bit Masks
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

        private Color COLOUR_VALUE_CHANGED = Color.FromArgb(255, 21, 131, 178);
        private Color COLOUR_VALUE_DEFAULT = Color.FromArgb(255, 255, 255, 255);
        #endregion

        public Form1()
        {
            InitializeComponent();
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColours());
        }

        #region BPM_Adjustments
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
        #endregion

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
                    bool readingBPM = false;

                    // Metadata checksum
                    int dataFound = 0;
                    int difficultyDataFound = 0;

                    while ((line = sr.ReadLine()) != null)
                    {
                        if (readingMetadata)
                        {
                            // Done reading metadata
                            if (line.Contains("[TimingPoints]"))
                            {
                                readingBPM = true;
                            }
                            else if (readingBPM)
                            {
                                readingBPM = false;

                                // Formula: bpm = (ms/min) / (ms/beat)
                                string[] tokens = line.Split(',');

                                decimal msPerBeat = decimal.Parse(tokens[1]);
                                selectedBeatmap.BPM = 60000 / msPerBeat;
                            }
                            else if (line.Contains("[HitObjects]"))
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
                                        selectedBeatmap.OD = decimal.Parse(value);
                                        difficultyDataFound |= OD_MASK;
                                    }
                                    else if (((difficultyDataFound & AR_MASK) == 0) && key.Contains("ApproachRate"))
                                    {
                                        selectedBeatmap.AR = decimal.Parse(value);
                                        difficultyDataFound |= AR_MASK;
                                    }
                                    else if (((difficultyDataFound & CS_MASK) == 0) && key.Contains("CircleSize"))
                                    {
                                        selectedBeatmap.CS = decimal.Parse(value);
                                        difficultyDataFound |= CS_MASK;
                                    }
                                    else if (((difficultyDataFound & HP_MASK) == 0) && key.Contains("HPDrainRate"))
                                    {
                                        selectedBeatmap.HP = decimal.Parse(value);
                                        difficultyDataFound |= HP_MASK;
                                    }
                                }
                            }
                        }
                        else
                        {
                            // Reading HitObjects
                            hitObjects.Add(line);

                            // Get the hit object type
                            string[] tokens = line.Split(',');
                            byte hitObjectType = Byte.Parse(tokens[3]);

                            selectedBeatmap.ObjectCount++;
                            // Adjust the hit object to the new bpm based on its type
                            if (hitObjectType == TYPE_CIRCLE || hitObjectType == TYPE_CIRCLE_NEW_COMBO)
                            {
                                selectedBeatmap.CircleCount++;
                            }
                            else if (hitObjectType == TYPE_SLIDER || hitObjectType == TYPE_SLIDER_NEW_COMBO)
                            {
                                selectedBeatmap.SliderCount++;
                            }
                            else if (hitObjectType == TYPE_SPINNER || hitObjectType == TYPE_SPINNER_NEW_COMBO)
                            {
                                selectedBeatmap.SpinnerCount++;
                            }
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

            string sourceAndArtist = (selectedBeatmap.Source == "") ?
                selectedBeatmap.Artist :
                selectedBeatmap.Source + " (" +
                selectedBeatmap.Artist + ") -" ;

            lblSelectedBeatmap.Text =
                sourceAndArtist + " " + 
                selectedBeatmap.Title + " [" +
                selectedBeatmap.Version + "]";

            lblCreator.Text = "Mapped by " + selectedBeatmap.Creator;

            lblBoldInfo.Text =
                "BPM: " + string.Format("{0:0.0}", selectedBeatmap.BPM) +
                "   Objects: " + selectedBeatmap.ObjectCount;

            lblHitObjects.Text =
                "Circles: " + selectedBeatmap.CircleCount +
                "   Sliders: " + selectedBeatmap.SliderCount +
                "   Spinners: " + selectedBeatmap.SpinnerCount;

            lblDifficultyRating.Text =
                "CS:" + selectedBeatmap.CS.ToString() +
                "   AR:" + selectedBeatmap.AR.ToString() +
                "   OD:" + selectedBeatmap.OD.ToString() +
                "   HP:" + selectedBeatmap.HP.ToString();

            floatFieldBPM.Text = selectedBeatmap.BPM.ToString();
            tbCreator.Text = selectedBeatmap.Creator;
            tbDifficultyName.Text = selectedBeatmap.Version;

            // Difficulty
            floatFieldOD.Value = (decimal)selectedBeatmap.OD;
            floatFieldAR.Value = (decimal)selectedBeatmap.AR;
            floatFieldCS.Value = (decimal)selectedBeatmap.CS;
            floatFieldHP.Value = (decimal)selectedBeatmap.HP;
        }

        private void lbBeatmaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDifficulties();
        }
        private void lbDifficulties_SelectedIndexChanged(object sender, EventArgs e)
        {
            ParseBeatmapFile(songsFolder + Path.DirectorySeparatorChar +
                lbBeatmaps.GetItemText(lbBeatmaps.SelectedItem) + Path.DirectorySeparatorChar +
                difficultyNames[lbDifficulties.SelectedIndex]);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            // if the search textbox is empty
            if (tbSearch.Text == "")
            {
                // display all beatmap folders
                beatmapNames = beatmapFolders;
            }
            else
            {
                // display all beatmap folders containing the text in the search textbox
                beatmapNames = beatmapFolders.FindAll(folder => folder.ToLower().Contains(tbSearch.Text.ToLower()));
            }
            // reset the datasource
            lbBeatmaps.DataSource = beatmapNames;
        }

        #region Float Fields
        private void floatFieldBPM_ValueChanged(object sender, EventArgs e)
        {
            FieldValueChanged((NumericUpDown)sender, (decimal)selectedBeatmap.BPM);
        }
        private void floatFieldBPMMultiplier_ValueChanged(object sender, EventArgs e)
        {

        }
        private void floatFieldAR_ValueChanged(object sender, EventArgs e)
        {
            FieldValueChanged((NumericUpDown)sender, (decimal)selectedBeatmap.AR);
        }
        private void floatFieldOD_ValueChanged(object sender, EventArgs e)
        {
            FieldValueChanged((NumericUpDown)sender, (decimal)selectedBeatmap.OD);
        }
        private void floatFieldCS_ValueChanged(object sender, EventArgs e)
        {
            FieldValueChanged((NumericUpDown)sender, (decimal)selectedBeatmap.CS);
        }
        private void floatFieldHP_ValueChanged(object sender, EventArgs e)
        {
            FieldValueChanged((NumericUpDown)sender, (decimal)selectedBeatmap.HP);
        }
        private void FieldValueChanged(NumericUpDown sender, decimal defaultValue)
        {
            sender.ForeColor = (sender.Value == defaultValue) ? COLOUR_VALUE_DEFAULT : COLOUR_VALUE_CHANGED;
        }
        #endregion

        private void cmdRevert_Click(object sender, EventArgs e)
        {
            Revert();
        }
        private void cmdApply_Click(object sender, EventArgs e)
        {

        }
        private void cmdCreateNew_Click(object sender, EventArgs e)
        {

        }

        private void cmdRemoveDifficulty_Click(object sender, EventArgs e)
        {

        }

        private void lbBeatmaps_DrawItem(object sender, DrawItemEventArgs e)
        {
            AlternatingBackColour(
                (ListBox)sender,
                Color.FromArgb(255, 37, 37, 37),
                Color.FromArgb(255, 47, 47, 47),
                e);
        }
        private void lbDifficulties_DrawItem(object sender, DrawItemEventArgs e)
        {
            AlternatingBackColour(
                (ListBox)sender,
                Color.FromArgb(255, 37, 37, 37),
                Color.FromArgb(255, 47, 47, 47),
                e);
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
        private void openInWindowsExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPathInWindowsExplorer(GetSelectedSongPath());
        }
        private void openDifficultyContainingFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPathInWindowsExplorer(GetSelectedDifficultyPath());
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
