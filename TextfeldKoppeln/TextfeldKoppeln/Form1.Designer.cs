namespace TextfeldKoppeln
{
    partial class FrmTextfeldKoppeln
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtProjektmappenname = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblProjektmappenname = new System.Windows.Forms.Label();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.ChkTextfelderKoppeln = new System.Windows.Forms.CheckBox();
            this.LblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(13, 13);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 0;
            this.TxtName.Click += new System.EventHandler(this.TxtName_Click);
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // TxtProjektmappenname
            // 
            this.TxtProjektmappenname.Location = new System.Drawing.Point(13, 40);
            this.TxtProjektmappenname.Name = "TxtProjektmappenname";
            this.TxtProjektmappenname.Size = new System.Drawing.Size(100, 20);
            this.TxtProjektmappenname.TabIndex = 1;
            this.TxtProjektmappenname.Click += new System.EventHandler(this.TxtProjektmappenname_Click);
            this.TxtProjektmappenname.Enter += new System.EventHandler(this.TxtProjektmappenname_Enter);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(120, 13);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 2;
            this.LblName.Text = "Name";
            // 
            // LblProjektmappenname
            // 
            this.LblProjektmappenname.AutoSize = true;
            this.LblProjektmappenname.Location = new System.Drawing.Point(120, 40);
            this.LblProjektmappenname.Name = "LblProjektmappenname";
            this.LblProjektmappenname.Size = new System.Drawing.Size(104, 13);
            this.LblProjektmappenname.TabIndex = 3;
            this.LblProjektmappenname.Text = "Projektmappenname";
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(302, 226);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 4;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // ChkTextfelderKoppeln
            // 
            this.ChkTextfelderKoppeln.AutoSize = true;
            this.ChkTextfelderKoppeln.Checked = true;
            this.ChkTextfelderKoppeln.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkTextfelderKoppeln.Location = new System.Drawing.Point(13, 67);
            this.ChkTextfelderKoppeln.Name = "ChkTextfelderKoppeln";
            this.ChkTextfelderKoppeln.Size = new System.Drawing.Size(114, 17);
            this.ChkTextfelderKoppeln.TabIndex = 5;
            this.ChkTextfelderKoppeln.Text = "Textfelder koppeln";
            this.ChkTextfelderKoppeln.UseVisualStyleBackColor = true;
            this.ChkTextfelderKoppeln.CheckedChanged += new System.EventHandler(this.ChkTextfelderKoppeln_CheckedChanged);
            // 
            // LblWarning
            // 
            this.LblWarning.AutoSize = true;
            this.LblWarning.Location = new System.Drawing.Point(157, 68);
            this.LblWarning.Name = "LblWarning";
            this.LblWarning.Size = new System.Drawing.Size(0, 13);
            this.LblWarning.TabIndex = 6;
            // 
            // FrmTextfeldKoppeln
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 261);
            this.Controls.Add(this.LblWarning);
            this.Controls.Add(this.ChkTextfelderKoppeln);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.LblProjektmappenname);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtProjektmappenname);
            this.Controls.Add(this.TxtName);
            this.Name = "FrmTextfeldKoppeln";
            this.Text = "Textfeld koppeln";
            this.Activated += new System.EventHandler(this.FrmTextfeldKoppeln_Activated);
            this.Load += new System.EventHandler(this.FrmTextfeldKoppeln_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtProjektmappenname;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblProjektmappenname;
        private System.Windows.Forms.Button CmdEnde;
        private System.Windows.Forms.CheckBox ChkTextfelderKoppeln;
        private System.Windows.Forms.Label LblWarning;
    }
}

