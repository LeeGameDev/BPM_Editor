namespace osu_Beatmap_Editor
{
    partial class ManageModes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMapsFound = new System.Windows.Forms.Label();
            this.cbModes = new System.Windows.Forms.ComboBox();
            this.labelPropertyEditor = new System.Windows.Forms.Label();
            this.cmdDeleteMode = new System.Windows.Forms.Button();
            this.cmdProcessMaps = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmdProcessMaps);
            this.panel1.Controls.Add(this.lblMapsFound);
            this.panel1.Controls.Add(this.cbModes);
            this.panel1.Controls.Add(this.labelPropertyEditor);
            this.panel1.Controls.Add(this.cmdDeleteMode);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 136);
            this.panel1.TabIndex = 5;
            // 
            // lblMapsFound
            // 
            this.lblMapsFound.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapsFound.ForeColor = System.Drawing.Color.White;
            this.lblMapsFound.Location = new System.Drawing.Point(3, 93);
            this.lblMapsFound.Name = "lblMapsFound";
            this.lblMapsFound.Size = new System.Drawing.Size(203, 35);
            this.lblMapsFound.TabIndex = 24;
            this.lblMapsFound.Text = "0 maps found";
            this.lblMapsFound.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbModes
            // 
            this.cbModes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.cbModes.ForeColor = System.Drawing.Color.White;
            this.cbModes.FormattingEnabled = true;
            this.cbModes.Location = new System.Drawing.Point(3, 66);
            this.cbModes.Name = "cbModes";
            this.cbModes.Size = new System.Drawing.Size(226, 21);
            this.cbModes.TabIndex = 23;
            this.cbModes.Text = "Select a mode...";
            this.cbModes.SelectedIndexChanged += new System.EventHandler(this.cbModes_SelectedIndexChanged);
            // 
            // labelPropertyEditor
            // 
            this.labelPropertyEditor.AutoSize = true;
            this.labelPropertyEditor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPropertyEditor.ForeColor = System.Drawing.Color.White;
            this.labelPropertyEditor.Location = new System.Drawing.Point(-1, 0);
            this.labelPropertyEditor.Name = "labelPropertyEditor";
            this.labelPropertyEditor.Size = new System.Drawing.Size(331, 22);
            this.labelPropertyEditor.TabIndex = 22;
            this.labelPropertyEditor.Text = "Delete all maps for the selected Mode";
            // 
            // cmdDeleteMode
            // 
            this.cmdDeleteMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.cmdDeleteMode.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDeleteMode.ForeColor = System.Drawing.Color.White;
            this.cmdDeleteMode.Location = new System.Drawing.Point(212, 93);
            this.cmdDeleteMode.Name = "cmdDeleteMode";
            this.cmdDeleteMode.Size = new System.Drawing.Size(147, 35);
            this.cmdDeleteMode.TabIndex = 17;
            this.cmdDeleteMode.Text = "Delete All";
            this.cmdDeleteMode.UseVisualStyleBackColor = false;
            this.cmdDeleteMode.Click += new System.EventHandler(this.cmdDeleteMode_Click);
            // 
            // cmdProcessMaps
            // 
            this.cmdProcessMaps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.cmdProcessMaps.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdProcessMaps.ForeColor = System.Drawing.Color.White;
            this.cmdProcessMaps.Location = new System.Drawing.Point(3, 25);
            this.cmdProcessMaps.Name = "cmdProcessMaps";
            this.cmdProcessMaps.Size = new System.Drawing.Size(147, 35);
            this.cmdProcessMaps.TabIndex = 26;
            this.cmdProcessMaps.Text = "Process Maps";
            this.cmdProcessMaps.UseVisualStyleBackColor = false;
            this.cmdProcessMaps.Click += new System.EventHandler(this.cmdProcessMaps_Click);
            // 
            // ManageModes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(388, 160);
            this.Controls.Add(this.panel1);
            this.Name = "ManageModes";
            this.Text = "Manage Modes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPropertyEditor;
        private System.Windows.Forms.Button cmdDeleteMode;
        private System.Windows.Forms.ComboBox cbModes;
        private System.Windows.Forms.Label lblMapsFound;
        private System.Windows.Forms.Button cmdProcessMaps;
    }
}