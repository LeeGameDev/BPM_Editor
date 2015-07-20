using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu_Beatmap_Editor
{
    public partial class ManageModes : Form
    {
        private List<BMAPI.v1.Beatmap> selectedModeBeatmaps = new List<BMAPI.v1.Beatmap>();     // Complete list
        private int mapCount = 0;

        public ManageModes()
        {
            InitializeComponent();
        }

        private void cmdProcessMaps_Click(object sender, EventArgs e)
        {
            if (Program.songsFolder != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                Program.ProcessBeatmaps();
                cbModes.DataSource = Enum.GetValues(typeof(BMAPI.v1.GameMode));
            }
        }

        private void cbModes_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMapsFoundCount();
        }

        private void cmdDeleteMode_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete all beatmaps with this Game Mode?", "Remove Mode", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                for (int i = 0; i < selectedModeBeatmaps.Count; i++)
                {
                    File.Delete(selectedModeBeatmaps[i].Filename);
                }
            }
        }

        private void UpdateMapsFoundCount()
        {
            BMAPI.v1.GameMode mode;
            Enum.TryParse<BMAPI.v1.GameMode>(cbModes.SelectedValue.ToString(), out mode);
            mapCount = GetMapsFound(mode);

            lblMapsFound.Text = mapCount + " maps found";

            cmdDeleteMode.Enabled = (mapCount == 0);
        }

        /// <summary>
        /// Computes and returns the number of maps that were made for the specified GameMode
        /// </summary>
        /// <param name="mode"></param>
        /// <returns>int: count</returns>
        private int GetMapsFound(BMAPI.v1.GameMode mode)
        {
            selectedModeBeatmaps.Clear();
            for (int i = 0; i < Program.difficulties.Count; i++)
            {
                BMAPI.v1.Beatmap map = Program.difficulties[i];
                if (map.Mode == mode)
                {
                    selectedModeBeatmaps.Add(map);
                }
            }

            return selectedModeBeatmaps.Count;
        }
    }
}
