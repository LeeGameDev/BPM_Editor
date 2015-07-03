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
            this.cmdSelectBeatmap = new System.Windows.Forms.Button();
            this.tbBPM = new System.Windows.Forms.TextBox();
            this.labelNewBPM = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbDifficultyName = new System.Windows.Forms.TextBox();
            this.lblDifficultyName = new System.Windows.Forms.Label();
            this.cmdSave = new System.Windows.Forms.Button();
            this.lbHitObjects = new System.Windows.Forms.ListBox();
            this.lbNewHitObjects = new System.Windows.Forms.ListBox();
            this.labelOldBPM = new System.Windows.Forms.Label();
            this.lblOldBPM = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdSelectBeatmap
            // 
            this.ofdSelectBeatmap.FileName = "ofdSelectBeatmap";
            this.ofdSelectBeatmap.Filter = "osu Files (*.osu)|*.osu";
            // 
            // lblSelectedBeatmap
            // 
            this.lblSelectedBeatmap.AutoSize = true;
            this.lblSelectedBeatmap.Location = new System.Drawing.Point(12, 38);
            this.lblSelectedBeatmap.Name = "lblSelectedBeatmap";
            this.lblSelectedBeatmap.Size = new System.Drawing.Size(111, 13);
            this.lblSelectedBeatmap.TabIndex = 0;
            this.lblSelectedBeatmap.Text = "No Beatmap Selected";
            // 
            // cmdSelectBeatmap
            // 
            this.cmdSelectBeatmap.Location = new System.Drawing.Point(12, 12);
            this.cmdSelectBeatmap.Name = "cmdSelectBeatmap";
            this.cmdSelectBeatmap.Size = new System.Drawing.Size(75, 23);
            this.cmdSelectBeatmap.TabIndex = 1;
            this.cmdSelectBeatmap.Text = "Open File...";
            this.cmdSelectBeatmap.UseVisualStyleBackColor = true;
            this.cmdSelectBeatmap.Click += new System.EventHandler(this.cmdSelectBeatmap_Click);
            // 
            // tbBPM
            // 
            this.tbBPM.Location = new System.Drawing.Point(195, 3);
            this.tbBPM.Name = "tbBPM";
            this.tbBPM.Size = new System.Drawing.Size(62, 20);
            this.tbBPM.TabIndex = 2;
            // 
            // labelNewBPM
            // 
            this.labelNewBPM.AutoSize = true;
            this.labelNewBPM.Location = new System.Drawing.Point(134, 6);
            this.labelNewBPM.Name = "labelNewBPM";
            this.labelNewBPM.Size = new System.Drawing.Size(55, 13);
            this.labelNewBPM.TabIndex = 3;
            this.labelNewBPM.Text = "New BPM";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblOldBPM);
            this.panel1.Controls.Add(this.labelOldBPM);
            this.panel1.Controls.Add(this.tbDifficultyName);
            this.panel1.Controls.Add(this.lblDifficultyName);
            this.panel1.Controls.Add(this.cmdSave);
            this.panel1.Controls.Add(this.labelNewBPM);
            this.panel1.Controls.Add(this.tbBPM);
            this.panel1.Location = new System.Drawing.Point(15, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 102);
            this.panel1.TabIndex = 4;
            // 
            // tbDifficultyName
            // 
            this.tbDifficultyName.Location = new System.Drawing.Point(87, 42);
            this.tbDifficultyName.Name = "tbDifficultyName";
            this.tbDifficultyName.Size = new System.Drawing.Size(100, 20);
            this.tbDifficultyName.TabIndex = 6;
            // 
            // lblDifficultyName
            // 
            this.lblDifficultyName.AutoSize = true;
            this.lblDifficultyName.Location = new System.Drawing.Point(3, 45);
            this.lblDifficultyName.Name = "lblDifficultyName";
            this.lblDifficultyName.Size = new System.Drawing.Size(78, 13);
            this.lblDifficultyName.TabIndex = 5;
            this.lblDifficultyName.Text = "Difficulty Name";
            // 
            // cmdSave
            // 
            this.cmdSave.Location = new System.Drawing.Point(6, 68);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 4;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // lbHitObjects
            // 
            this.lbHitObjects.FormattingEnabled = true;
            this.lbHitObjects.Location = new System.Drawing.Point(12, 162);
            this.lbHitObjects.Name = "lbHitObjects";
            this.lbHitObjects.Size = new System.Drawing.Size(327, 238);
            this.lbHitObjects.TabIndex = 5;
            // 
            // lbNewHitObjects
            // 
            this.lbNewHitObjects.FormattingEnabled = true;
            this.lbNewHitObjects.Location = new System.Drawing.Point(345, 162);
            this.lbNewHitObjects.Name = "lbNewHitObjects";
            this.lbNewHitObjects.Size = new System.Drawing.Size(327, 238);
            this.lbNewHitObjects.TabIndex = 6;
            // 
            // labelOldBPM
            // 
            this.labelOldBPM.AutoSize = true;
            this.labelOldBPM.Location = new System.Drawing.Point(3, 6);
            this.labelOldBPM.Name = "labelOldBPM";
            this.labelOldBPM.Size = new System.Drawing.Size(49, 13);
            this.labelOldBPM.TabIndex = 7;
            this.labelOldBPM.Text = "Old BPM";
            // 
            // lblOldBPM
            // 
            this.lblOldBPM.AutoSize = true;
            this.lblOldBPM.Location = new System.Drawing.Point(58, 6);
            this.lblOldBPM.Name = "lblOldBPM";
            this.lblOldBPM.Size = new System.Drawing.Size(13, 13);
            this.lblOldBPM.TabIndex = 8;
            this.lblOldBPM.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 429);
            this.Controls.Add(this.lbNewHitObjects);
            this.Controls.Add(this.lbHitObjects);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdSelectBeatmap);
            this.Controls.Add(this.lblSelectedBeatmap);
            this.Name = "Form1";
            this.Text = "BPM Editor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdSelectBeatmap;
        private System.Windows.Forms.Label lblSelectedBeatmap;
        private System.Windows.Forms.Button cmdSelectBeatmap;
        private System.Windows.Forms.TextBox tbBPM;
        private System.Windows.Forms.Label labelNewBPM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.TextBox tbDifficultyName;
        private System.Windows.Forms.Label lblDifficultyName;
        private System.Windows.Forms.ListBox lbHitObjects;
        private System.Windows.Forms.ListBox lbNewHitObjects;
        private System.Windows.Forms.Label lblOldBPM;
        private System.Windows.Forms.Label labelOldBPM;
    }
}

