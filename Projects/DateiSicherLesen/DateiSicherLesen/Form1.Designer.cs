namespace DateiSicherLesen
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
            this.CmdPfad = new System.Windows.Forms.Button();
            this.CmdAusnahme = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdExistenz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdPfad
            // 
            this.CmdPfad.Location = new System.Drawing.Point(197, 70);
            this.CmdPfad.Name = "CmdPfad";
            this.CmdPfad.Size = new System.Drawing.Size(75, 23);
            this.CmdPfad.TabIndex = 19;
            this.CmdPfad.Text = "Pfad";
            this.CmdPfad.UseVisualStyleBackColor = true;
            this.CmdPfad.Click += new System.EventHandler(this.CmdPfad_Click);
            // 
            // CmdAusnahme
            // 
            this.CmdAusnahme.Location = new System.Drawing.Point(197, 41);
            this.CmdAusnahme.Name = "CmdAusnahme";
            this.CmdAusnahme.Size = new System.Drawing.Size(75, 23);
            this.CmdAusnahme.TabIndex = 18;
            this.CmdAusnahme.Text = "Ausnahme";
            this.CmdAusnahme.UseVisualStyleBackColor = true;
            this.CmdAusnahme.Click += new System.EventHandler(this.CmdAusnahme_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(12, 48);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige.TabIndex = 17;
            this.LblAnzeige.Text = "(leer)";
            // 
            // CmdExistenz
            // 
            this.CmdExistenz.Location = new System.Drawing.Point(197, 12);
            this.CmdExistenz.Name = "CmdExistenz";
            this.CmdExistenz.Size = new System.Drawing.Size(75, 23);
            this.CmdExistenz.TabIndex = 16;
            this.CmdExistenz.Text = "Existenz";
            this.CmdExistenz.UseVisualStyleBackColor = true;
            this.CmdExistenz.Click += new System.EventHandler(this.CmdExistenz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdPfad);
            this.Controls.Add(this.CmdAusnahme);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdExistenz);
            this.Name = "Form1";
            this.Text = "Datei sicher lesen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdPfad;
        internal System.Windows.Forms.Button CmdAusnahme;
        internal System.Windows.Forms.Label LblAnzeige;
        internal System.Windows.Forms.Button CmdExistenz;
    }
}

