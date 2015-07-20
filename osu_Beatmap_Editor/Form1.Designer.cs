namespace osu_Beatmap_Editor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPropertyEditor = new System.Windows.Forms.Label();
            this.floatFieldHP = new System.Windows.Forms.NumericUpDown();
            this.cmdApply = new System.Windows.Forms.Button();
            this.floatFieldCS = new System.Windows.Forms.NumericUpDown();
            this.floatFieldOD = new System.Windows.Forms.NumericUpDown();
            this.floatFieldAR = new System.Windows.Forms.NumericUpDown();
            this.floatFieldBPM = new System.Windows.Forms.NumericUpDown();
            this.labelBPM = new System.Windows.Forms.Label();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.labelCreator = new System.Windows.Forms.Label();
            this.cmdRevert = new System.Windows.Forms.Button();
            this.tbCreator = new System.Windows.Forms.TextBox();
            this.labelAR = new System.Windows.Forms.Label();
            this.tbDifficultyName = new System.Windows.Forms.TextBox();
            this.labelHPDrain = new System.Windows.Forms.Label();
            this.labelOD = new System.Windows.Forms.Label();
            this.labelCS = new System.Windows.Forms.Label();
            this.lblDifficultyRating = new System.Windows.Forms.Label();
            this.lblHitObjects = new System.Windows.Forms.Label();
            this.lblBPMInfo = new System.Windows.Forms.Label();
            this.lblCreator = new System.Windows.Forms.Label();
            this.cmdCreateNew = new System.Windows.Forms.Button();
            this.lbBeatmaps = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setSongDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openInWindowsExplorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDifficultyContainingFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageModesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fbdSongs = new System.Windows.Forms.FolderBrowserDialog();
            this.lbDifficulties = new System.Windows.Forms.ListBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.cmdRemoveDifficulty = new System.Windows.Forms.Button();
            this.labelDifficulties = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbEncoding = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.floatFieldHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floatFieldCS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floatFieldOD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floatFieldAR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floatFieldBPM)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.lblSelectedBeatmap.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedBeatmap.ForeColor = System.Drawing.Color.White;
            this.lblSelectedBeatmap.Location = new System.Drawing.Point(0, 1);
            this.lblSelectedBeatmap.Name = "lblSelectedBeatmap";
            this.lblSelectedBeatmap.Size = new System.Drawing.Size(465, 22);
            this.lblSelectedBeatmap.TabIndex = 0;
            this.lblSelectedBeatmap.Text = "No Beatmap Selected";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbEncoding);
            this.panel1.Controls.Add(this.labelPropertyEditor);
            this.panel1.Controls.Add(this.floatFieldHP);
            this.panel1.Controls.Add(this.cmdApply);
            this.panel1.Controls.Add(this.floatFieldCS);
            this.panel1.Controls.Add(this.floatFieldOD);
            this.panel1.Controls.Add(this.floatFieldAR);
            this.panel1.Controls.Add(this.floatFieldBPM);
            this.panel1.Controls.Add(this.labelBPM);
            this.panel1.Controls.Add(this.labelDifficulty);
            this.panel1.Controls.Add(this.labelCreator);
            this.panel1.Controls.Add(this.cmdRevert);
            this.panel1.Controls.Add(this.tbCreator);
            this.panel1.Controls.Add(this.labelAR);
            this.panel1.Controls.Add(this.tbDifficultyName);
            this.panel1.Controls.Add(this.labelHPDrain);
            this.panel1.Controls.Add(this.labelOD);
            this.panel1.Controls.Add(this.labelCS);
            this.panel1.Location = new System.Drawing.Point(483, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 233);
            this.panel1.TabIndex = 4;
            // 
            // labelPropertyEditor
            // 
            this.labelPropertyEditor.AutoSize = true;
            this.labelPropertyEditor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPropertyEditor.ForeColor = System.Drawing.Color.White;
            this.labelPropertyEditor.Location = new System.Drawing.Point(3, 1);
            this.labelPropertyEditor.Name = "labelPropertyEditor";
            this.labelPropertyEditor.Size = new System.Drawing.Size(137, 22);
            this.labelPropertyEditor.TabIndex = 22;
            this.labelPropertyEditor.Text = "Property Editor";
            // 
            // floatFieldHP
            // 
            this.floatFieldHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.floatFieldHP.DecimalPlaces = 1;
            this.floatFieldHP.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floatFieldHP.ForeColor = System.Drawing.Color.White;
            this.floatFieldHP.Location = new System.Drawing.Point(241, 155);
            this.floatFieldHP.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.floatFieldHP.Name = "floatFieldHP";
            this.floatFieldHP.Size = new System.Drawing.Size(62, 23);
            this.floatFieldHP.TabIndex = 25;
            this.floatFieldHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.floatFieldHP.ValueChanged += new System.EventHandler(this.floatFieldHP_ValueChanged);
            // 
            // cmdApply
            // 
            this.cmdApply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.cmdApply.Enabled = false;
            this.cmdApply.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdApply.ForeColor = System.Drawing.Color.White;
            this.cmdApply.Location = new System.Drawing.Point(159, 190);
            this.cmdApply.Name = "cmdApply";
            this.cmdApply.Size = new System.Drawing.Size(147, 35);
            this.cmdApply.TabIndex = 17;
            this.cmdApply.Text = "Apply";
            this.cmdApply.UseVisualStyleBackColor = false;
            this.cmdApply.Click += new System.EventHandler(this.cmdApply_Click);
            // 
            // floatFieldCS
            // 
            this.floatFieldCS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.floatFieldCS.DecimalPlaces = 1;
            this.floatFieldCS.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floatFieldCS.ForeColor = System.Drawing.Color.White;
            this.floatFieldCS.Location = new System.Drawing.Point(241, 129);
            this.floatFieldCS.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.floatFieldCS.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.floatFieldCS.Name = "floatFieldCS";
            this.floatFieldCS.Size = new System.Drawing.Size(62, 23);
            this.floatFieldCS.TabIndex = 24;
            this.floatFieldCS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.floatFieldCS.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.floatFieldCS.ValueChanged += new System.EventHandler(this.floatFieldCS_ValueChanged);
            // 
            // floatFieldOD
            // 
            this.floatFieldOD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.floatFieldOD.DecimalPlaces = 1;
            this.floatFieldOD.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floatFieldOD.ForeColor = System.Drawing.Color.White;
            this.floatFieldOD.Location = new System.Drawing.Point(72, 155);
            this.floatFieldOD.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.floatFieldOD.Name = "floatFieldOD";
            this.floatFieldOD.Size = new System.Drawing.Size(62, 23);
            this.floatFieldOD.TabIndex = 23;
            this.floatFieldOD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.floatFieldOD.ValueChanged += new System.EventHandler(this.floatFieldOD_ValueChanged);
            // 
            // floatFieldAR
            // 
            this.floatFieldAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.floatFieldAR.DecimalPlaces = 1;
            this.floatFieldAR.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floatFieldAR.ForeColor = System.Drawing.Color.White;
            this.floatFieldAR.Location = new System.Drawing.Point(72, 129);
            this.floatFieldAR.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.floatFieldAR.Name = "floatFieldAR";
            this.floatFieldAR.Size = new System.Drawing.Size(62, 23);
            this.floatFieldAR.TabIndex = 22;
            this.floatFieldAR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.floatFieldAR.ValueChanged += new System.EventHandler(this.floatFieldAR_ValueChanged);
            // 
            // floatFieldBPM
            // 
            this.floatFieldBPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.floatFieldBPM.DecimalPlaces = 2;
            this.floatFieldBPM.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.floatFieldBPM.ForeColor = System.Drawing.Color.White;
            this.floatFieldBPM.Location = new System.Drawing.Point(72, 40);
            this.floatFieldBPM.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.floatFieldBPM.Name = "floatFieldBPM";
            this.floatFieldBPM.Size = new System.Drawing.Size(85, 23);
            this.floatFieldBPM.TabIndex = 18;
            this.floatFieldBPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.floatFieldBPM.ValueChanged += new System.EventHandler(this.floatFieldBPM_ValueChanged);
            // 
            // labelBPM
            // 
            this.labelBPM.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBPM.ForeColor = System.Drawing.Color.White;
            this.labelBPM.Location = new System.Drawing.Point(7, 40);
            this.labelBPM.Name = "labelBPM";
            this.labelBPM.Size = new System.Drawing.Size(59, 23);
            this.labelBPM.TabIndex = 19;
            this.labelBPM.Text = "BPM";
            this.labelBPM.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifficulty.ForeColor = System.Drawing.Color.White;
            this.labelDifficulty.Location = new System.Drawing.Point(5, 67);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(95, 23);
            this.labelDifficulty.TabIndex = 18;
            this.labelDifficulty.Text = "Difficulty";
            this.labelDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCreator
            // 
            this.labelCreator.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreator.ForeColor = System.Drawing.Color.White;
            this.labelCreator.Location = new System.Drawing.Point(5, 93);
            this.labelCreator.Name = "labelCreator";
            this.labelCreator.Size = new System.Drawing.Size(95, 23);
            this.labelCreator.TabIndex = 17;
            this.labelCreator.Text = "Creator";
            this.labelCreator.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdRevert
            // 
            this.cmdRevert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.cmdRevert.Enabled = false;
            this.cmdRevert.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRevert.ForeColor = System.Drawing.Color.White;
            this.cmdRevert.Location = new System.Drawing.Point(3, 190);
            this.cmdRevert.Name = "cmdRevert";
            this.cmdRevert.Size = new System.Drawing.Size(150, 34);
            this.cmdRevert.TabIndex = 18;
            this.cmdRevert.Text = "Revert";
            this.cmdRevert.UseVisualStyleBackColor = false;
            this.cmdRevert.Click += new System.EventHandler(this.cmdRevert_Click);
            // 
            // tbCreator
            // 
            this.tbCreator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tbCreator.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCreator.ForeColor = System.Drawing.Color.White;
            this.tbCreator.Location = new System.Drawing.Point(106, 95);
            this.tbCreator.Name = "tbCreator";
            this.tbCreator.Size = new System.Drawing.Size(199, 20);
            this.tbCreator.TabIndex = 8;
            // 
            // labelAR
            // 
            this.labelAR.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAR.ForeColor = System.Drawing.Color.White;
            this.labelAR.Location = new System.Drawing.Point(5, 129);
            this.labelAR.Name = "labelAR";
            this.labelAR.Size = new System.Drawing.Size(61, 23);
            this.labelAR.TabIndex = 9;
            this.labelAR.Text = "AR";
            this.labelAR.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbDifficultyName
            // 
            this.tbDifficultyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tbDifficultyName.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDifficultyName.ForeColor = System.Drawing.Color.White;
            this.tbDifficultyName.Location = new System.Drawing.Point(106, 69);
            this.tbDifficultyName.Name = "tbDifficultyName";
            this.tbDifficultyName.Size = new System.Drawing.Size(199, 20);
            this.tbDifficultyName.TabIndex = 6;
            // 
            // labelHPDrain
            // 
            this.labelHPDrain.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHPDrain.ForeColor = System.Drawing.Color.White;
            this.labelHPDrain.Location = new System.Drawing.Point(140, 155);
            this.labelHPDrain.Name = "labelHPDrain";
            this.labelHPDrain.Size = new System.Drawing.Size(95, 23);
            this.labelHPDrain.TabIndex = 12;
            this.labelHPDrain.Text = "HP Drain";
            this.labelHPDrain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelOD
            // 
            this.labelOD.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOD.ForeColor = System.Drawing.Color.White;
            this.labelOD.Location = new System.Drawing.Point(5, 155);
            this.labelOD.Name = "labelOD";
            this.labelOD.Size = new System.Drawing.Size(61, 23);
            this.labelOD.TabIndex = 10;
            this.labelOD.Text = "OD";
            this.labelOD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCS
            // 
            this.labelCS.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCS.ForeColor = System.Drawing.Color.White;
            this.labelCS.Location = new System.Drawing.Point(140, 129);
            this.labelCS.Name = "labelCS";
            this.labelCS.Size = new System.Drawing.Size(95, 23);
            this.labelCS.TabIndex = 11;
            this.labelCS.Text = "Circle Size";
            this.labelCS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDifficultyRating
            // 
            this.lblDifficultyRating.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficultyRating.ForeColor = System.Drawing.Color.White;
            this.lblDifficultyRating.Location = new System.Drawing.Point(0, 98);
            this.lblDifficultyRating.Name = "lblDifficultyRating";
            this.lblDifficultyRating.Size = new System.Drawing.Size(465, 18);
            this.lblDifficultyRating.TabIndex = 21;
            this.lblDifficultyRating.Text = "CS:-   AR:-   OD:-   HP:-";
            // 
            // lblHitObjects
            // 
            this.lblHitObjects.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHitObjects.ForeColor = System.Drawing.Color.White;
            this.lblHitObjects.Location = new System.Drawing.Point(0, 72);
            this.lblHitObjects.Name = "lblHitObjects";
            this.lblHitObjects.Size = new System.Drawing.Size(465, 18);
            this.lblHitObjects.TabIndex = 20;
            this.lblHitObjects.Text = "Circles: --   Sliders: --   Spinners: --";
            // 
            // lblBPMInfo
            // 
            this.lblBPMInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBPMInfo.ForeColor = System.Drawing.Color.White;
            this.lblBPMInfo.Location = new System.Drawing.Point(0, 46);
            this.lblBPMInfo.Name = "lblBPMInfo";
            this.lblBPMInfo.Size = new System.Drawing.Size(465, 18);
            this.lblBPMInfo.TabIndex = 19;
            this.lblBPMInfo.Text = "BPM: --   Objects: --";
            // 
            // lblCreator
            // 
            this.lblCreator.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreator.ForeColor = System.Drawing.Color.White;
            this.lblCreator.Location = new System.Drawing.Point(7, 23);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(458, 16);
            this.lblCreator.TabIndex = 7;
            this.lblCreator.Text = "Mapped by: --";
            // 
            // cmdCreateNew
            // 
            this.cmdCreateNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.cmdCreateNew.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCreateNew.ForeColor = System.Drawing.Color.White;
            this.cmdCreateNew.Location = new System.Drawing.Point(800, 413);
            this.cmdCreateNew.Name = "cmdCreateNew";
            this.cmdCreateNew.Size = new System.Drawing.Size(153, 35);
            this.cmdCreateNew.TabIndex = 4;
            this.cmdCreateNew.Text = "Create new";
            this.cmdCreateNew.UseVisualStyleBackColor = false;
            this.cmdCreateNew.Click += new System.EventHandler(this.cmdCreateNew_Click);
            // 
            // lbBeatmaps
            // 
            this.lbBeatmaps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.lbBeatmaps.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbBeatmaps.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBeatmaps.ForeColor = System.Drawing.Color.White;
            this.lbBeatmaps.FormattingEnabled = true;
            this.lbBeatmaps.ItemHeight = 18;
            this.lbBeatmaps.Location = new System.Drawing.Point(12, 197);
            this.lbBeatmaps.Name = "lbBeatmaps";
            this.lbBeatmaps.Size = new System.Drawing.Size(465, 292);
            this.lbBeatmaps.TabIndex = 9;
            this.lbBeatmaps.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbBeatmaps_DrawItem);
            this.lbBeatmaps.SelectedIndexChanged += new System.EventHandler(this.lbBeatmaps_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(961, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setSongDirectoryToolStripMenuItem,
            this.openInWindowsExplorerToolStripMenuItem,
            this.openDifficultyContainingFolderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // setSongDirectoryToolStripMenuItem
            // 
            this.setSongDirectoryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.setSongDirectoryToolStripMenuItem.Name = "setSongDirectoryToolStripMenuItem";
            this.setSongDirectoryToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.setSongDirectoryToolStripMenuItem.Text = "Set Songs Directory...";
            this.setSongDirectoryToolStripMenuItem.Click += new System.EventHandler(this.setSongDirectoryToolStripMenuItem_Click);
            // 
            // openInWindowsExplorerToolStripMenuItem
            // 
            this.openInWindowsExplorerToolStripMenuItem.Name = "openInWindowsExplorerToolStripMenuItem";
            this.openInWindowsExplorerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openInWindowsExplorerToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.openInWindowsExplorerToolStripMenuItem.Text = "Open Song Folder";
            this.openInWindowsExplorerToolStripMenuItem.Click += new System.EventHandler(this.openInWindowsExplorerToolStripMenuItem_Click);
            // 
            // openDifficultyContainingFolderToolStripMenuItem
            // 
            this.openDifficultyContainingFolderToolStripMenuItem.Name = "openDifficultyContainingFolderToolStripMenuItem";
            this.openDifficultyContainingFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.O)));
            this.openDifficultyContainingFolderToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.openDifficultyContainingFolderToolStripMenuItem.Text = "Open Difficulty Folder";
            this.openDifficultyContainingFolderToolStripMenuItem.Click += new System.EventHandler(this.openDifficultyContainingFolderToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageModesToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // manageModesToolStripMenuItem
            // 
            this.manageModesToolStripMenuItem.Name = "manageModesToolStripMenuItem";
            this.manageModesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.manageModesToolStripMenuItem.Text = "Manage Modes";
            this.manageModesToolStripMenuItem.Click += new System.EventHandler(this.manageModesToolStripMenuItem_Click);
            // 
            // fbdSongs
            // 
            this.fbdSongs.SelectedPath = "C:\\Program Files (x86)\\osu!\\osu! stream client\\Songs";
            // 
            // lbDifficulties
            // 
            this.lbDifficulties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.lbDifficulties.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbDifficulties.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDifficulties.ForeColor = System.Drawing.Color.White;
            this.lbDifficulties.FormattingEnabled = true;
            this.lbDifficulties.ItemHeight = 18;
            this.lbDifficulties.Location = new System.Drawing.Point(483, 287);
            this.lbDifficulties.Name = "lbDifficulties";
            this.lbDifficulties.Size = new System.Drawing.Size(311, 202);
            this.lbDifficulties.TabIndex = 12;
            this.lbDifficulties.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbDifficulties_DrawItem);
            this.lbDifficulties.SelectedIndexChanged += new System.EventHandler(this.lbDifficulties_SelectedIndexChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.tbSearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.White;
            this.tbSearch.Location = new System.Drawing.Point(76, 156);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(401, 26);
            this.tbSearch.TabIndex = 13;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.ForeColor = System.Drawing.Color.White;
            this.labelSearch.Location = new System.Drawing.Point(12, 159);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(58, 22);
            this.labelSearch.TabIndex = 14;
            this.labelSearch.Text = "Search";
            // 
            // cmdRemoveDifficulty
            // 
            this.cmdRemoveDifficulty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.cmdRemoveDifficulty.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRemoveDifficulty.ForeColor = System.Drawing.Color.White;
            this.cmdRemoveDifficulty.Location = new System.Drawing.Point(800, 454);
            this.cmdRemoveDifficulty.Name = "cmdRemoveDifficulty";
            this.cmdRemoveDifficulty.Size = new System.Drawing.Size(151, 35);
            this.cmdRemoveDifficulty.TabIndex = 15;
            this.cmdRemoveDifficulty.Text = "Remove Difficulty";
            this.cmdRemoveDifficulty.UseVisualStyleBackColor = false;
            this.cmdRemoveDifficulty.Click += new System.EventHandler(this.cmdRemoveDifficulty_Click);
            // 
            // labelDifficulties
            // 
            this.labelDifficulties.AutoSize = true;
            this.labelDifficulties.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDifficulties.ForeColor = System.Drawing.Color.White;
            this.labelDifficulties.Location = new System.Drawing.Point(479, 263);
            this.labelDifficulties.Name = "labelDifficulties";
            this.labelDifficulties.Size = new System.Drawing.Size(102, 24);
            this.labelDifficulties.TabIndex = 16;
            this.labelDifficulties.Text = "Difficulties";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblSelectedBeatmap);
            this.panel2.Controls.Add(this.lblCreator);
            this.panel2.Controls.Add(this.lblBPMInfo);
            this.panel2.Controls.Add(this.lblHitObjects);
            this.panel2.Controls.Add(this.lblDifficultyRating);
            this.panel2.Location = new System.Drawing.Point(12, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 121);
            this.panel2.TabIndex = 18;
            // 
            // cbEncoding
            // 
            this.cbEncoding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEncoding.FormattingEnabled = true;
            this.cbEncoding.Items.AddRange(new object[] {
            "MP3",
            "WAV"});
            this.cbEncoding.Location = new System.Drawing.Point(251, 40);
            this.cbEncoding.Name = "cbEncoding";
            this.cbEncoding.Size = new System.Drawing.Size(55, 21);
            this.cbEncoding.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(163, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Encoding";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(961, 499);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.labelDifficulties);
            this.Controls.Add(this.cmdRemoveDifficulty);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.cmdCreateNew);
            this.Controls.Add(this.lbDifficulties);
            this.Controls.Add(this.lbBeatmaps);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "osu! Beatmap Editor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.floatFieldHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floatFieldCS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floatFieldOD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floatFieldAR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floatFieldBPM)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdSelectBeatmap;
        private System.Windows.Forms.Label lblSelectedBeatmap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdCreateNew;
        private System.Windows.Forms.TextBox tbDifficultyName;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.TextBox tbCreator;
        private System.Windows.Forms.ListBox lbBeatmaps;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setSongDirectoryToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog fbdSongs;
        private System.Windows.Forms.ListBox lbDifficulties;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button cmdRemoveDifficulty;
        private System.Windows.Forms.Label labelDifficulties;
        private System.Windows.Forms.Label labelOD;
        private System.Windows.Forms.Label labelAR;
        private System.Windows.Forms.Label labelHPDrain;
        private System.Windows.Forms.Label labelCS;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.Label labelCreator;
        private System.Windows.Forms.Label labelBPM;
        private System.Windows.Forms.Button cmdApply;
        private System.Windows.Forms.Button cmdRevert;
        private System.Windows.Forms.Label lblBPMInfo;
        private System.Windows.Forms.Label lblHitObjects;
        private System.Windows.Forms.Label lblDifficultyRating;
        private System.Windows.Forms.NumericUpDown floatFieldBPM;
        private System.Windows.Forms.NumericUpDown floatFieldHP;
        private System.Windows.Forms.NumericUpDown floatFieldCS;
        private System.Windows.Forms.NumericUpDown floatFieldOD;
        private System.Windows.Forms.NumericUpDown floatFieldAR;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPropertyEditor;
        private System.Windows.Forms.ToolStripMenuItem openInWindowsExplorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDifficultyContainingFolderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageModesToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbEncoding;
        private System.Windows.Forms.Label label1;
    }
}

