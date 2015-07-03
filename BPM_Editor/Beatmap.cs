using System;
using System.Text;

namespace BPM_Editor
{
    class Beatmap
    {
        // General Metadata
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

        private string difficulty;
        public string Difficulty
        {
            get { return difficulty; }
            set { difficulty = value; }
        }

        private string mapper;
        public string Mapper
        {
            get { return mapper; }
            set { mapper = value; }
        }

        private float bpm;
        public float BPM
        {
            get { return bpm; }
            set { bpm = value; }
        }

        private int objectCount;
        public int ObjectCount
        {
            get { return objectCount; }
            set { objectCount = value; }
        }

        // Difficulty
        private float circleSize;
        public float CircleSize
        {
            get { return circleSize; }
            set { circleSize = value; }
        }

        private float approachRate;
        public float ApproachRate
        {
            get { return approachRate; }
            set { approachRate = value; }
        }

        private float hpDrainRate;
        public float HPDrainRate
        {
            get { return hpDrainRate; }
            set { hpDrainRate = value; }
        }

        private float starRating;
        public float StarRating
        {
            get { return starRating; }
            set { starRating = value; }
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

        public void ClearData()
        {
            FileAddr = "";
            FileName = "";
            Difficulty = "";
            Mapper = "";
            BPM = 0.0f;
            ObjectCount = 0;
            CircleSize = 0.0f;
            ApproachRate = 0.0f;
            HPDrainRate = 0.0f;
            StarRating = 0.0f;

        }
    }
}