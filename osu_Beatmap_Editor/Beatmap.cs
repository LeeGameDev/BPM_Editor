using System;
using System.Text;

namespace osu_Beatmap_Editor
{
    class Beatmap
    {
        #region Metadata
        private string fileAddr;
        public string FileAddr
        {
            get { return fileAddr; }
            set { fileAddr = value; }
        }

        private string fileName;
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string artist;
        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        private string source;
        public string Source
        {
            get { return source; }
            set { source = value; }
        }

        private string version;
        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        private string creator;
        public string Creator
        {
            get { return creator; }
            set { creator = value; }
        }

        private string mapper;
        public string Mapper
        {
            get { return mapper; }
            set { mapper = value; }
        }

        private decimal bpm;
        public decimal BPM
        {
            get { return bpm; }
            set { bpm = value; }
        }
        #endregion

        #region Difficulty
        private decimal overallDifficulty;
        public decimal OD
        {
            get { return overallDifficulty; }
            set { overallDifficulty = value; }
        }

        private decimal approachRate;
        public decimal AR
        {
            get { return approachRate; }
            set { approachRate = value; }
        }

        private decimal circleSize;
        public decimal CS
        {
            get { return circleSize; }
            set { circleSize = value; }
        }

        private decimal hpDrainRate;
        public decimal HP
        {
            get { return hpDrainRate; }
            set { hpDrainRate = value; }
        }
        #endregion

        #region Additional
        private int objectCount;
        public int ObjectCount
        {
            get { return objectCount; }
            set { objectCount = value; }
        }

        private int circleCount;
        public int CircleCount
        {
            get { return circleCount; }
            set { circleCount = value; }
        }

        private int sliderCount;
        public int SliderCount
        {
            get { return sliderCount; }
            set { sliderCount = value; }
        }

        private int spinnerCount;
        public int SpinnerCount
        {
            get { return spinnerCount; }
            set { spinnerCount = value; }
        }
        #endregion

        public void ClearData()
        {
            // Metadata
            FileAddr = "";
            FileName = "";
            Title = "";
            Artist = "";
            Source = "";
            Version = "";
            Creator = "";
            Mapper = "";
            BPM = 0;

            // Difficulty
            OD = 0;
            AR = 0;
            CS = 0;
            HP = 0;

            // Additional
            ObjectCount = 0;
            CircleCount = 0;
            SliderCount = 0;
            SpinnerCount = 0;
        }
    }
}