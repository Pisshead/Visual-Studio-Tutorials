namespace TextfeldKoppeln
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblProjektmappenname = new System.Windows.Forms.Label();
            this.TxtProjektmappenname = new System.Windows.Forms.TextBox();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblProjektmappenname
            // 
            this.LblProjektmappenname.AutoSize = true;
            this.LblProjektmappenname.Location = new System.Drawing.Point(164, 41);
            this.LblProjektmappenname.Name = "LblProjektmappenname";
            this.LblProjektmappenname.Size = new System.Drawing.Size(104, 13);
            this.LblProjektmappenname.TabIndex = 7;
            this.LblProjektmappenname.Text = "Projektmappenname";
            // 
            // TxtProjektmappenname
            // 
            this.TxtProjektmappenname.Location = new System.Drawing.Point(12, 38);
            this.TxtProjektmappenname.Name = "TxtProjektmappenname";
            this.TxtProjektmappenname.Size = new System.Drawing.Size(150, 20);
            this.TxtProjektmappenname.TabIndex = 6;
            this.TxtProjektmappenname.Click += new System.EventHandler(this.TxtProjektmappenname_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(164, 15);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(35, 13);
            this.LblName.TabIndex = 5;
            this.LblName.Text = "Name";
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(12, 12);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(150, 20);
            this.TxtName.TabIndex = 4;
            this.TxtName.Text = "Hallo";
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LblProjektmappenname);
            this.Controls.Add(this.TxtProjektmappenname);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtName);
            this.Name = "Form1";
            this.Text = "Textfelder koppeln";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblProjektmappenname;
        private System.Windows.Forms.TextBox TxtProjektmappenname;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtName;
    }
}

