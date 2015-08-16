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
using BMAPI.v1;
using BMAPI.v1.HitObjects;
using BMAPI.v1.Events;

namespace osu_Beatmap_Editor
{
    public partial class Form1 : Form
    {
        private Beatmap selectedBeatmap = null;
        
        private List<string> beatmapNames = new List<string>();
        private List<string> difficultyPaths = new List<string>();
        private List<string> difficultyDisplayNames = new List<string>();
        private List<BMAPI.v1.Beatmap> difficulties = new List<Beatmap>();

        private Color COLOUR_VALUE_CHANGED = Color.FromArgb(255, 21, 131, 178);
        private Color COLOUR_VALUE_DEFAULT = Color.FromArgb(255, 255, 255, 255);
        
        private double minBPM = 0;
        private double maxBPM = 0;

        public Form1()
        {
            InitializeComponent();
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new CustomProfessionalColours());
        }

        #region Adjust HitObject Times
        private BMAPI.v1.HitObjects.CircleObject AdjustCircleObject<T>(BMAPI.v1.HitObjects.CircleObject circle, float oldBpm, float newBpm)
        {
            // Create new CircleObject with adjusted start time
            BMAPI.v1.HitObjects.CircleObject newCircle = new BMAPI.v1.HitObjects.CircleObject(circle);
            newCircle.StartTime = circle.StartTime / (newBpm / oldBpm);

            return newCircle;
        }
        private BMAPI.v1.HitObjects.SpinnerObject AdjustSpinner(BMAPI.v1.HitObjects.SpinnerObject spinner, float oldBpm, float newBpm)
        {
            // Compute BPM ratio
            float bpmRatio = newBpm / oldBpm;

            // Create new SpinnerObject with adjusted start-end time
            BMAPI.v1.HitObjects.SpinnerObject newSpinner = new BMAPI.v1.HitObjects.SpinnerObject(spinner);
            newSpinner.StartTime = spinner.StartTime / bpmRatio;
            newSpinner.StartTime = spinner.EndTime / bpmRatio;

            return newSpinner;
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
            // Assign new Beatmap
            selectedBeatmap = new Beatmap(path);

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

            // BPM: Min - Max
            List<TimingPoint> timingPoints = new List<TimingPoint>(selectedBeatmap.TimingPoints.Where(tp => !tp.InheritsBPM));
            minBPM = 60000 / timingPoints.Min(tp => tp.BpmDelay);
            maxBPM = 60000 / timingPoints.Max(tp => tp.BpmDelay);
            bool isSingleBPM = (maxBPM - minBPM == 0);
            string bpmFormat = (isSingleBPM) ?
                "BPM: " + string.Format("{0:0.0}", minBPM) :
                "BPM: " + string.Format("{0:0.0} - {1:0.0}", minBPM, maxBPM);
            lblBPMInfo.Text = bpmFormat +
                "   Objects: " + selectedBeatmap.HitObjects.Count;

            int[] hitObjectsCount = UpdateHitObjectsCount(selectedBeatmap.HitObjects);
            lblHitObjects.Text =
                "Circles: " + hitObjectsCount[0] +
                "   Sliders: " + hitObjectsCount[1] +
                "   Spinners: " + hitObjectsCount[2];

            lblDifficultyRating.Text =
                "CS:" + selectedBeatmap.CircleSize +
                "   AR:" + selectedBeatmap.ApproachRate +
                "   OD:" + selectedBeatmap.OverallDifficulty +
                "   HP:" + selectedBeatmap.HPDrainRate;

            floatFieldBPM.Text = selectedBeatmap.BPM.ToString();
            cbEncoding.SelectedIndex = (int)selectedBeatmap.Encoding;
            tbCreator.Text = selectedBeatmap.Creator;
            tbDifficultyName.Text = selectedBeatmap.Version;

            // Difficulty
            floatFieldCS.Value = (decimal)selectedBeatmap.CircleSize;
            floatFieldAR.Value = (decimal)selectedBeatmap.ApproachRate;
            floatFieldOD.Value = (decimal)selectedBeatmap.OverallDifficulty;
            floatFieldHP.Value = (decimal)selectedBeatmap.HPDrainRate;
        }

        // Counts the different types of HitObjects and updates the UI
        private int[] UpdateHitObjectsCount(List<CircleObject> hitObjects)
        {
            // Holds the count for the various types of HitObjects
            int[] hitObjectsCount = new int[3];
            hitObjectsCount[0] = 0;
            hitObjectsCount[1] = 0;
            hitObjectsCount[2] = 0;

            foreach(CircleObject hitObj in hitObjects)
            {
                if (hitObj.GetType() == typeof(CircleObject))
                {
                    hitObjectsCount[0]++;
                }
                else if (hitObj.GetType() == typeof(SliderObject))
                {
                    hitObjectsCount[1]++;
                }
                else if (hitObj.GetType() == typeof(SpinnerObject))
                {
                    hitObjectsCount[2]++;
                }
            }

            return hitObjectsCount;
        }

        private void lbBeatmaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDifficulties();
        }
        private void lbDifficulties_SelectedIndexChanged(object sender, EventArgs e)
        {
            ParseBeatmapFile(difficultyPaths[lbDifficulties.SelectedIndex]);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            // if the search textbox is empty
            if (tbSearch.Text == "")
            {
                // display all beatmap folders
                beatmapNames = GetBeatmapFolderNames(Program.beatmapFolders);
            }
            else
            {
                // display all beatmap folders containing the text in the search textbox
                beatmapNames = GetBeatmapFolderNames(Program.beatmapFolders).FindAll(folder => folder.ToLower().Contains(tbSearch.Text.ToLower()));
            }
            // reset the datasource
            lbBeatmaps.DataSource = beatmapNames;
        }

        #region Float Fields
        private void floatFieldBPM_ValueChanged(object sender, EventArgs e)
        {
            FieldValueChanged((NumericUpDown)sender, (decimal)selectedBeatmap.BPM);
        }
        private void floatFieldAR_ValueChanged(object sender, EventArgs e)
        {
            FieldValueChanged((NumericUpDown)sender, (decimal)selectedBeatmap.ApproachRate);
        }
        private void floatFieldOD_ValueChanged(object sender, EventArgs e)
        {
            FieldValueChanged((NumericUpDown)sender, (decimal)selectedBeatmap.OverallDifficulty);
        }
        private void floatFieldCS_ValueChanged(object sender, EventArgs e)
        {
            FieldValueChanged((NumericUpDown)sender, (decimal)selectedBeatmap.CircleSize);
        }
        private void floatFieldHP_ValueChanged(object sender, EventArgs e)
        {
            FieldValueChanged((NumericUpDown)sender, (decimal)selectedBeatmap.HPDrainRate);
        }
        private void FieldValueChanged(NumericUpDown sender, decimal defaultValue)
        {
            sender.ForeColor = (sender.Value == defaultValue) ? COLOUR_VALUE_DEFAULT : COLOUR_VALUE_CHANGED;
        }
        #endregion

        private void cmdRevert_Click(object sender, EventArgs e)
        {
            if (selectedBeatmap != null)
            {
                RevertProperties();
            }
        }
        private void cmdApply_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to apply changes to this file?", "Apply changes to this difficulty", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ApplyToDifficulty();
            }
        }
        private void cmdCreateNew_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Create new difficulty?", "Create difficulty", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SaveDifficultyAs();
                UpdateDifficulties();
            }
        }
        private void cmdRemoveDifficulty_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to PERMANENTLY delete this file?", "Remove difficulty", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                RemoveDifficulty();
            }
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
                Cursor.Current = Cursors.WaitCursor;
                Program.songsFolder = fbdSongs.SelectedPath;
                Program.ProcessBeatmaps();
                ProcessSongsFolder();
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
        private void manageModesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageModes mmForm = new ManageModes();
            mmForm.ShowDialog();
        }

        private static string GetTempPath(string ext)
        {
            return Path.GetTempPath() + Guid.NewGuid() + ext;
        }
        public static void CopyFile(string src, string dst)
        {
            using (FileStream srcStream = new FileStream(src, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (FileStream dstStream = new FileStream(dst, FileMode.Create))
            {
                srcStream.CopyTo(dstStream);
            }
        }

        public void ApplyNewBPM(Beatmap bm, double newBPM, double bpmRatio)
        {
            ProcessBPMChanges(bm, newBPM, bpmRatio);

            // Copy the original file
            string selectedSongPath = GetSelectedSongPath() + Path.DirectorySeparatorChar;
            string audioExt = bm.AudioFilename.Substring(bm.AudioFilename.LastIndexOf('.'));

            string tempDecoded = GetTempPath(".wav");
            string tempStretched = GetTempPath(".wav");
            string tempEncoded = GetTempPath(".mp3");
            string newAudioFilename = "";

            double tempo = (Math.Pow(bpmRatio, -1) - 1) * 100;

            Process p = new Process();

            // Decode mp3 to wav
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = false;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.FileName = "lame.exe";
            p.StartInfo.Arguments = string.Format("--decode \"{0}\" \"{1}\"", selectedSongPath + bm.AudioFilename, tempDecoded);
            p.Start();
            p.WaitForExit();

            // Stretch the BPM to desired BPM
            p.StartInfo.FileName = "soundstretch.exe";
            p.StartInfo.Arguments = string.Format("\"{0}\" \"{1}\" -tempo={2}", tempDecoded, tempStretched, tempo);
            p.Start();
            p.WaitForExit();

            if (cbEncoding.SelectedIndex == (int)EncodingType.MP3)
            {
                // Encode wav as mp3
                p.StartInfo.FileName = "lame.exe";
                p.StartInfo.Arguments = string.Format("\"{0}\" \"{1}\"", tempStretched, tempEncoded);
                p.Start();
                p.WaitForExit();

                // Create a copy of the final audio file
                newAudioFilename = selectedSongPath + tbDifficultyName.Text + "_" + newBPM + ".mp3";
                CopyFile(tempEncoded, newAudioFilename);

                // Cleanup
                File.Delete(tempEncoded);   // .wav->.mp3
            }
            else
            {
                // Create a copy of the final audio file
                newAudioFilename = selectedSongPath + tbDifficultyName.Text + "_" + newBPM + ".wav";
                CopyFile(tempStretched, newAudioFilename);
            }

            bm.AudioFilename = newAudioFilename;

            string newFilename = bm.Filename.Substring(0, bm.Filename.LastIndexOf('[')) + "[" + tbDifficultyName.Text + "].osu";
            bm.Save(newFilename);

            // Cleanup
            File.Delete(tempDecoded);       // .mp3->.wav
            File.Delete(tempStretched);     // .wav->.wav
        }
        private void ProcessBPMChanges(Beatmap bm, double newBPM, double bpmRatio)
        {
            // Process TimingPoints
            ProcessTimingPoints(bm.TimingPoints, newBPM, bpmRatio);

            // Process Events
            ProcessEvents(bm.Events, bpmRatio);

            // Process hitobjects
            ProcessHitObjects(bm.HitObjects, bpmRatio);
        }
        private void ProcessTimingPoints(List<TimingPoint> timingPoints, double newBPM, double bpmRatio)
        {
            foreach (TimingPoint tp in timingPoints)
            {
                if (tp.InheritsBPM == false)
                {
                    float newDelay = 60000 / (float)newBPM;
                    tp.BpmDelay = newDelay;
                    tp.Time = (int)(tp.Time * bpmRatio);
                }
            }
        }
        private void ProcessEvents(List<EventBase> events, double bpmRatio)
        {
            foreach (EventBase e in selectedBeatmap.Events)
            {
                e.StartTime = (int)(e.StartTime * bpmRatio);
                if (e.GetType() == typeof(BreakEvent))
                {
                    ((BreakEvent)e).EndTime = (int)(((BreakEvent)e).EndTime * bpmRatio);
                }
            }
        }
        private void ProcessHitObjects(List<CircleObject> hitObjects, double bpmRatio)
        {
            foreach (CircleObject hitObject in hitObjects)
            {
                hitObject.StartTime = (int)(hitObject.StartTime * bpmRatio);
                if (hitObject.GetType() == typeof(SpinnerObject))
                {
                    ((SpinnerObject)hitObject).EndTime = (int)(((SpinnerObject)hitObject).EndTime * bpmRatio);
                }
            }
        }

        private void tbDifficultyName_TextChanged(object sender, EventArgs e)
        {
            TextBoxFieldChanged((TextBox)sender, selectedBeatmap.Version);
        }
        private void tbCreator_TextChanged(object sender, EventArgs e)
        {
            TextBoxFieldChanged((TextBox)sender, selectedBeatmap.Creator);
        }
        private void TextBoxFieldChanged(TextBox sender, string defaultValue)
        {
            sender.ForeColor = (sender.Text == defaultValue) ? COLOUR_VALUE_DEFAULT : COLOUR_VALUE_CHANGED;
        }
    }
}