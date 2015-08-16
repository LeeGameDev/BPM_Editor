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

namespace osu_Beatmap_Editor
{
    public partial class Form1 : Form
    {
        private void ProcessSongsFolder()
        {
            UpdateBeatmapNames(Program.beatmapFolders);

            // Get a collection of difficulty file names for the UI
            UpdateDifficulties();
        }

        private void UpdateBeatmapNames(List<string> beatmapFolders)
        {
            // Update UI
            lbBeatmaps.DataSource = GetBeatmapFolderNames(beatmapFolders);
        }

        private List<string> GetBeatmapFolderNames(List<string> beatmapFolders)
        {
            beatmapNames = new List<string>(beatmapFolders.Select(file => new DirectoryInfo(file).Name));

            return beatmapNames;
        }

        // Gets the names of the files with .osu extension for the selected beatmap
        private void UpdateDifficulties()
        {
            // Get the files in the beatmap folder
            string difficultiesPath = Program.songsFolder + Path.DirectorySeparatorChar + lbBeatmaps.GetItemText(lbBeatmaps.SelectedItem);

            difficultyPaths = new List<string>(Directory.EnumerateFiles(difficultiesPath).
                Where(file => Path.GetExtension(file).Contains(".osu")));

            // Create a List of Beatmaps from these files
            difficulties.Clear();
            for (int i = 0; i < difficultyPaths.Count; i++)
            {
                difficulties.Add(new Beatmap(difficultyPaths[i]));
            }

            difficultyDisplayNames = new List<string>(difficulties.Select(diff => diff.Version));

            lbDifficulties.DataSource = difficultyDisplayNames;
        }

        private void RevertProperties()
        {
            // string properties
            tbDifficultyName.Text = selectedBeatmap.Version;
            tbCreator.Text = selectedBeatmap.Creator;

            // decimal properties
            floatFieldBPM.Value = (decimal)selectedBeatmap.BPM;
            floatFieldAR.Value = (decimal)selectedBeatmap.ApproachRate;
            floatFieldOD.Value = (decimal)selectedBeatmap.OverallDifficulty;
            floatFieldCS.Value = (decimal)selectedBeatmap.CircleSize;
            floatFieldHP.Value = (decimal)selectedBeatmap.HPDrainRate;
        }

        private void ApplyToDifficulty()
        {
            UpdateBeatmapProperties(ref selectedBeatmap);

            selectedBeatmap.Save(selectedBeatmap.Filename);
        }

        private void SaveDifficultyAs()
        {
            // Create new instance of a beatmap based on an existing beatmap difficulty
            Beatmap bm = new Beatmap(GetSelectedDifficultyPath());

            // Update properties with new values
            UpdateBeatmapProperties(ref bm);

            // Check if BPM is different
            double newBPM = (double)floatFieldBPM.Value;
            if (bm.BPM != newBPM)
            {
                double bpmRatio = bm.BPM / newBPM;
                ApplyNewBPM(selectedBeatmap, newBPM, bpmRatio);
            }

            // Save
            string diffPath = GetSelectedDifficultyPath().Replace(difficultyPaths[lbDifficulties.SelectedIndex], "[" + tbDifficultyName.Text + "]");

            bm.Save(diffPath);
        }

        private void UpdateBeatmapProperties(ref Beatmap bm)
        {
            // Set properties in selected beatmap difficulty:
            bm.Version = tbDifficultyName.Text;
            bm.Creator = tbCreator.Text;
            bm.ApproachRate = (float)floatFieldAR.Value;
            bm.OverallDifficulty = (float)floatFieldOD.Value;
            bm.CircleSize= (float)floatFieldCS.Value;
            bm.HPDrainRate = (float)floatFieldHP.Value;
        }

        private void RemoveDifficulty()
        {
            try
            {
                File.Delete(GetSelectedDifficultyPath());
            }
            catch
            {

            }

            UpdateDifficulties();
        }

        private string GetSelectedDifficultyPath()
        {
            return difficultyPaths[lbDifficulties.SelectedIndex];
        }
        private string GetSelectedSongPath()
        {
            return Program.songsFolder + Path.DirectorySeparatorChar + lbBeatmaps.GetItemText(lbBeatmaps.SelectedItem);
        }

        private void OpenPathInWindowsExplorer(string path)
        {
            Process.Start("explorer.exe", "/select, \"" + path + "\"");
        }

        private void AlternatingBackColour(ListBox lb, Color main, Color off, DrawItemEventArgs e)
        {
            bool isSelected = ((e.State & DrawItemState.Selected) == DrawItemState.Selected);

            if (e.Index > -1)
            {
                Color color = isSelected ? SystemColors.Highlight : (e.Index % 2 == 0) ? main : off;

                // Background item brush
                SolidBrush backgroundBrush = new SolidBrush(color);
                // Text color brush
                SolidBrush textBrush = new SolidBrush(e.ForeColor);

                // Draw the background
                e.Graphics.FillRectangle(backgroundBrush, e.Bounds);
                // Draw the text
                e.Graphics.DrawString(lb.Items[e.Index].ToString(), e.Font, textBrush, e.Bounds, StringFormat.GenericDefault);

                // Clean up
                backgroundBrush.Dispose();
                textBrush.Dispose();
            }
            e.DrawFocusRectangle();
        }
    }


    class CustomProfessionalColours : ProfessionalColorTable
    {
        public override Color MenuStripGradientBegin
        {
            get
            {
                return Color.FromArgb(255, 47, 47, 47);
            }
        }
        public override Color MenuStripGradientEnd
        {
            get
            {
                return Color.FromArgb(255, 37, 37, 37);
            }
        }
        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return Color.FromArgb(255, 21, 131, 178);
            }
        }
        public override Color MenuItemPressedGradientMiddle
        {
            get
            {
                return Color.FromArgb(255, 21, 131, 178);
            }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return Color.FromArgb(255, 21, 131, 178);
            }
        }
    }
}