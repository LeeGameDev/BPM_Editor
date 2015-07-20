using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace osu_Beatmap_Editor
{
    static class Program
    {
        public static string songsFolder;
        public static List<string> beatmapFolders = new List<string>();     // Full path
        public static List<string> difficultyFolders = new List<string>();  // Full path
        public static List<BMAPI.v1.Beatmap> difficulties = new List<BMAPI.v1.Beatmap>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        /// <summary>
        /// Searches the Songs/ directory for all beatmaps, and all difficulties and caches the results for future use
        /// </summary>
        public static void ProcessBeatmaps()
        {
            // Find all beatmap folders
            beatmapFolders = new List<string>(Directory.EnumerateDirectories(songsFolder));

            difficulties.Clear();
            // Generate a list of Beatmap difficulties within each beatmap folder
            for (int i = 0; i < beatmapFolders.Count; i++)
            {
                // Find all .osu files
                difficultyFolders = new List<string>(Directory.EnumerateFiles(beatmapFolders[i]).
                    Where(file => Path.GetExtension(file).Contains(".osu")));

                // Generate a list of Beatmap objects from the .osu files
                for (int j = 0; j < difficultyFolders.Count; j++)
                {
                    BMAPI.v1.Beatmap currentMap = new BMAPI.v1.Beatmap(difficultyFolders[j]);
                    difficulties.Add(currentMap);
                }
            }
        }
    }
}
