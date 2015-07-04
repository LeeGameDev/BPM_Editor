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

namespace BPM_Editor
{
    public partial class Form1 : Form
    {
        private void ProcessSongsFolder(string path)
        {
            // Get a collection of folder names for the list box
            beatmapFolders = new List<string>(Directory.EnumerateDirectories(path).Select(folder => new DirectoryInfo(folder).Name));
            beatmapNames = beatmapFolders;
            lbBeatmaps.DataSource = beatmapNames;
            lbBeatmaps.SelectedIndex = 0;
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

        private void Revert()
        {
            floatFieldBPM.Value = selectedBeatmap.BPM;
            floatFieldAR.Value = selectedBeatmap.AR;
            floatFieldOD.Value = selectedBeatmap.OD;
            floatFieldCS.Value = selectedBeatmap.CS;
            floatFieldHP.Value = selectedBeatmap.HP;
        }

        private string GetSelectedDifficultyPath()
        {
            return songsFolder + Path.DirectorySeparatorChar +
                lbBeatmaps.GetItemText(lbBeatmaps.SelectedItem) + Path.DirectorySeparatorChar +
                difficultyNames[lbDifficulties.SelectedIndex];
        }
        private string GetSelectedSongPath()
        {
            return songsFolder + Path.DirectorySeparatorChar + lbBeatmaps.GetItemText(lbBeatmaps.SelectedItem);
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