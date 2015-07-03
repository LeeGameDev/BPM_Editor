namespace BPM_Editor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ofdSelectBeatmap = new System.Windows.Forms.OpenFileDialog();
            this.lblSelectedBeatmap = new System.Windows.Forms.Label();
            this.tbBPM = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbDifficultyName = new System.Windows.Forms.TextBox();
            this.cmdSave = new System.Windows.Forms.Button();
            this.lblCreator = new System.Windows.Forms.Label();
            this.tbCreator = new System.Windows.Forms.TextBox();
            this.lbBeatmaps = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSongDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fbdSongs = new System.Windows.Forms.FolderBrowserDialog();
            this.lbDifficulties = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.cmdRemoveDifficulty = new System.Windows.Forms.Button();
            this.labelDifficulties = new System.Windows.Forms.Label();
            this.labelAR = new System.Windows.Forms.Label();
            this.labelOD = new System.Windows.Forms.Label();
            this.labelCS = new System.Windows.Forms.Label();
            this.labelHPDrain = new System.Windows.Forms.Label();
            this.tbAR = new System.Windows.Forms.TextBox();
            this.tbOD = new System.Windows.Forms.TextBox();
            this.tbCS = new System.Windows.Forms.TextBox();
            this.tbHPDrain = new System.Windows.Forms.TextBox();
            this.labelCreator = new System.Windows.Forms.Label();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.labelBPM = new System.Windows.Forms.Label();
            this.cmdApply = new System.Windows.Forms.Button();
            this.cmdRevert = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdSelectBeatmap
            // 
            this.ofdSelectBeatmap.FileName = "ofdSelectBeatmap";
            this.ofdSelectBeatmap.Filter = "osu Files (*.osu)|*.osu";
            this.ofdSelectBeatmap.RestoreDirectory = true;
            // 
            // lblSelectedBeatmap
            // 
            this.lblSelectedBeatmap.AutoSize = true;
            this.lblSelectedBeatmap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedBeatmap.Location = new System.Drawing.Point(5, 3);
            this.lblSelectedBeatmap.Name = "lblSelectedBeatmap";
            this.lblSelectedBeatmap.Size = new System.Drawing.Size(162, 18);
            this.lblSelectedBeatmap.TabIndex = 0;
            this.lblSelectedBeatmap.Text = "No Beatmap Selected";
            // 
            // tbBPM
            // 
            this.tbBPM.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBPM.Location = new System.Drawing.Point(109, 45);
            this.tbBPM.Name = "tbBPM";
            this.tbBPM.Size = new System.Drawing.Size(52, 20);
            this.tbBPM.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdRevert);
            this.panel1.Controls.Add(this.labelBPM);
            this.panel1.Controls.Add(this.labelDifficulty);
            this.panel1.Controls.Add(this.labelCreator);
            this.panel1.Controls.Add(this.tbHPDrain);
            this.panel1.Controls.Add(this.tbCS);
            this.panel1.Controls.Add(this.labelHPDrain);
            this.panel1.Controls.Add(this.labelCS);
            this.panel1.Controls.Add(this.tbOD);
            this.panel1.Controls.Add(this.tbAR);
            this.panel1.Controls.Add(this.labelOD);
            this.panel1.Controls.Add(this.labelAR);
            this.panel1.Controls.Add(this.lblCreator);
            this.panel1.Controls.Add(this.tbCreator);
            this.panel1.Controls.Add(this.lblSelectedBeatmap);
            this.panel1.Controls.Add(this.tbDifficultyName);
            this.panel1.Controls.Add(this.tbBPM);
            this.panel1.Location = new System.Drawing.Point(346, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 233);
            this.panel1.TabIndex = 4;
            // 
            // tbDifficultyName
            // 
            this.tbDifficultyName.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDifficultyName.Location = new System.Drawing.Point(109, 71);
            this.tbDifficultyName.Name = "tbDifficultyName";
            this.tbDifficultyName.Size = new System.Drawing.Size(171, 20);
            this.tbDifficultyName.TabIndex = 6;
            // 
            // cmdSave
            // 
            this.cmdSave.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Location = new System.Drawing.Point(517, 282);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(153, 35);
            this.cmdSave.TabIndex = 4;
            this.cmdSave.Text = "Create new";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreator.Location = new System.Drawing.Point(18, 21);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(74, 14);
            this.lblCreator.TabIndex = 7;
            this.lblCreator.Text = "Mapped by: --";
            // 
            // tbCreator
            // 
            this.tbCreator.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCreator.Location = new System.Drawing.Point(109, 97);
            this.tbCreator.Name = "tbCreator";
            this.tbCreator.Size = new System.Drawing.Size(171, 20);
            this.tbCreator.TabIndex = 8;
            // 
            // lbBeatmaps
            // 
            this.lbBeatmaps.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBeatmaps.FormattingEnabled = true;
            this.lbBeatmaps.ItemHeight = 18;
            this.lbBeatmaps.Location = new System.Drawing.Point(12, 53);
            this.lbBeatmaps.Name = "lbBeatmaps";
            this.lbBeatmaps.Size = new System.Drawing.Size(327, 436);
            this.lbBeatmaps.TabIndex = 9;
            this.lbBeatmaps.SelectedIndexChanged += new System.EventHandler(this.lbBeatmaps_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(787, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setSongDirectoryToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // setSongDirectoryToolStripMenuItem
            // 
            this.setSongDirectoryToolStripMenuItem.Name = "setSongDirectoryToolStripMenuItem";
            this.setSongDirectoryToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.setSongDirectoryToolStripMenuItem.Text = "Set Song Directory";
            this.setSongDirectoryToolStripMenuItem.Click += new System.EventHandler(this.setSongDirectoryToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.openFileToolStripMenuItem.Text = "Open Beatmap...";
            this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lbDifficulties
            // 
            this.lbDifficulties.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDifficulties.FormattingEnabled = true;
            this.lbDifficulties.ItemHeight = 18;
            this.lbDifficulties.Location = new System.Drawing.Point(346, 282);
            this.lbDifficulties.Name = "lbDifficulties";
            this.lbDifficulties.Size = new System.Drawing.Size(167, 166);
            this.lbDifficulties.TabIndex = 12;
            this.lbDifficulties.SelectedIndexChanged += new System.EventHandler(this.lbDifficulties_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(65, 27);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 20);
            this.textBox2.TabIndex = 13;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(12, 24);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(47, 18);
            this.labelSearch.TabIndex = 14;
            this.labelSearch.Text = "Search";
            // 
            // cmdRemoveDifficulty
            // 
            this.cmdRemoveDifficulty.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRemoveDifficulty.Location = new System.Drawing.Point(345, 454);
            this.cmdRemoveDifficulty.Name = "cmdRemoveDifficulty";
            this.cmdRemoveDifficulty.Size = new System.Drawing.Size(120, 35);
            this.cmdRemoveDifficulty.TabIndex = 15;
            this.cmdRemoveDifficulty.Text = "Remove Difficulty";
            this.cmdRemoveDifficulty.UseVisualStyleBackColor = true;
            // 
            // labelDifficulties
            // 
            this.labelDifficulties.AutoSize = true;
            this.labelDifficulties.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifficulties.Location = new System.Drawing.Point(345, 263);
            this.labelDifficulties.Name = "labelDifficulties";
            this.labelDifficulties.Size = new System.Drawing.Size(72, 18);
            this.labelDifficulties.TabIndex = 16;
            this.labelDifficulties.Text = "Difficulties";
            // 
            // labelAR
            // 
            this.labelAR.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAR.Location = new System.Drawing.Point(8, 122);
            this.labelAR.Name = "labelAR";
            this.labelAR.Size = new System.Drawing.Size(95, 23);
            this.labelAR.TabIndex = 9;
            this.labelAR.Text = "AR";
            this.labelAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOD
            // 
            this.labelOD.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOD.Location = new System.Drawing.Point(8, 148);
            this.labelOD.Name = "labelOD";
            this.labelOD.Size = new System.Drawing.Size(95, 23);
            this.labelOD.TabIndex = 10;
            this.labelOD.Text = "OD";
            this.labelOD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCS
            // 
            this.labelCS.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCS.Location = new System.Drawing.Point(8, 174);
            this.labelCS.Name = "labelCS";
            this.labelCS.Size = new System.Drawing.Size(95, 23);
            this.labelCS.TabIndex = 11;
            this.labelCS.Text = "Circle Size";
            this.labelCS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHPDrain
            // 
            this.labelHPDrain.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHPDrain.Location = new System.Drawing.Point(8, 200);
            this.labelHPDrain.Name = "labelHPDrain";
            this.labelHPDrain.Size = new System.Drawing.Size(95, 23);
            this.labelHPDrain.TabIndex = 12;
            this.labelHPDrain.Text = "HP Drain";
            this.labelHPDrain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAR
            // 
            this.tbAR.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAR.Location = new System.Drawing.Point(109, 124);
            this.tbAR.Name = "tbAR";
            this.tbAR.Size = new System.Drawing.Size(171, 20);
            this.tbAR.TabIndex = 13;
            // 
            // tbOD
            // 
            this.tbOD.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOD.Location = new System.Drawing.Point(109, 150);
            this.tbOD.Name = "tbOD";
            this.tbOD.Size = new System.Drawing.Size(171, 20);
            this.tbOD.TabIndex = 14;
            // 
            // tbCS
            // 
            this.tbCS.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCS.Location = new System.Drawing.Point(109, 176);
            this.tbCS.Name = "tbCS";
            this.tbCS.Size = new System.Drawing.Size(171, 20);
            this.tbCS.TabIndex = 15;
            // 
            // tbHPDrain
            // 
            this.tbHPDrain.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHPDrain.Location = new System.Drawing.Point(109, 202);
            this.tbHPDrain.Name = "tbHPDrain";
            this.tbHPDrain.Size = new System.Drawing.Size(171, 20);
            this.tbHPDrain.TabIndex = 16;
            // 
            // labelCreator
            // 
            this.labelCreator.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreator.Location = new System.Drawing.Point(8, 95);
            this.labelCreator.Name = "labelCreator";
            this.labelCreator.Size = new System.Drawing.Size(95, 23);
            this.labelCreator.TabIndex = 17;
            this.labelCreator.Text = "Creator";
            this.labelCreator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifficulty.Location = new System.Drawing.Point(8, 69);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(95, 23);
            this.labelDifficulty.TabIndex = 18;
            this.labelDifficulty.Text = "Difficulty";
            this.labelDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBPM
            // 
            this.labelBPM.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBPM.Location = new System.Drawing.Point(8, 43);
            this.labelBPM.Name = "labelBPM";
            this.labelBPM.Size = new System.Drawing.Size(95, 23);
            this.labelBPM.TabIndex = 19;
            this.labelBPM.Text = "BPM";
            this.labelBPM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdApply
            // 
            this.cmdApply.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdApply.Location = new System.Drawing.Point(517, 323);
            this.cmdApply.Name = "cmdApply";
            this.cmdApply.Size = new System.Drawing.Size(153, 35);
            this.cmdApply.TabIndex = 17;
            this.cmdApply.Text = "Apply to this";
            this.cmdApply.UseVisualStyleBackColor = true;
            // 
            // cmdRevert
            // 
            this.cmdRevert.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRevert.Location = new System.Drawing.Point(207, 31);
            this.cmdRevert.Name = "cmdRevert";
            this.cmdRevert.Size = new System.Drawing.Size(73, 35);
            this.cmdRevert.TabIndex = 18;
            this.cmdRevert.Text = "Revert";
            this.cmdRevert.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 496);
            this.Controls.Add(this.cmdApply);
            this.Controls.Add(this.labelDifficulties);
            this.Controls.Add(this.cmdRemoveDifficulty);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.lbDifficulties);
            this.Controls.Add(this.lbBeatmaps);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "BPM Editor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdSelectBeatmap;
        private System.Windows.Forms.Label lblSelectedBeatmap;
        private System.Windows.Forms.TextBox tbBPM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox tbDifficultyName;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.TextBox tbCreator;
        private System.Windows.Forms.ListBox lbBeatmaps;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSongDirectoryToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog fbdSongs;
        private System.Windows.Forms.ListBox lbDifficulties;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button cmdRemoveDifficulty;
        private System.Windows.Forms.Label labelDifficulties;
        private System.Windows.Forms.Label labelOD;
        private System.Windows.Forms.Label labelAR;
        private System.Windows.Forms.Label labelHPDrain;
        private System.Windows.Forms.Label labelCS;
        private System.Windows.Forms.TextBox tbHPDrain;
        private System.Windows.Forms.TextBox tbCS;
        private System.Windows.Forms.TextBox tbOD;
        private System.Windows.Forms.TextBox tbAR;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.Label labelCreator;
        private System.Windows.Forms.Label labelBPM;
        private System.Windows.Forms.Button cmdApply;
        private System.Windows.Forms.Button cmdRevert;
    }
}

