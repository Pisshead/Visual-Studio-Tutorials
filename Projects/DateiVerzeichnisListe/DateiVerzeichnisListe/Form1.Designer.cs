namespace DateiVerzeichnisListe
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
            this.LblAktuellesVerzeichnis = new System.Windows.Forms.Label();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdNachOben = new System.Windows.Forms.Button();
            this.CmdInVerzeichnis = new System.Windows.Forms.Button();
            this.CmdSystemEintraege = new System.Windows.Forms.Button();
            this.LstAnzeige = new System.Windows.Forms.ListBox();
            this.CmdDateiliste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAktuellesVerzeichnis
            // 
            this.LblAktuellesVerzeichnis.AutoSize = true;
            this.LblAktuellesVerzeichnis.Location = new System.Drawing.Point(19, 46);
            this.LblAktuellesVerzeichnis.Name = "LblAktuellesVerzeichnis";
            this.LblAktuellesVerzeichnis.Size = new System.Drawing.Size(30, 13);
            this.LblAktuellesVerzeichnis.TabIndex = 36;
            this.LblAktuellesVerzeichnis.Text = "(leer)";
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(17, 240);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige.TabIndex = 35;
            this.LblAnzeige.Text = "(leer)";
            // 
            // CmdNachOben
            // 
            this.CmdNachOben.Location = new System.Drawing.Point(300, 12);
            this.CmdNachOben.Name = "CmdNachOben";
            this.CmdNachOben.Size = new System.Drawing.Size(80, 23);
            this.CmdNachOben.TabIndex = 34;
            this.CmdNachOben.Text = "nach oben";
            this.CmdNachOben.UseVisualStyleBackColor = true;
            this.CmdNachOben.Click += new System.EventHandler(this.CmdNachOben_Click);
            // 
            // CmdInVerzeichnis
            // 
            this.CmdInVerzeichnis.Location = new System.Drawing.Point(214, 12);
            this.CmdInVerzeichnis.Name = "CmdInVerzeichnis";
            this.CmdInVerzeichnis.Size = new System.Drawing.Size(80, 23);
            this.CmdInVerzeichnis.TabIndex = 33;
            this.CmdInVerzeichnis.Text = "in Verzeichnis";
            this.CmdInVerzeichnis.UseVisualStyleBackColor = true;
            this.CmdInVerzeichnis.Click += new System.EventHandler(this.CmdInVerzeichnis_Click);
            // 
            // CmdSystemEintraege
            // 
            this.CmdSystemEintraege.Location = new System.Drawing.Point(98, 12);
            this.CmdSystemEintraege.Name = "CmdSystemEintraege";
            this.CmdSystemEintraege.Size = new System.Drawing.Size(90, 23);
            this.CmdSystemEintraege.TabIndex = 32;
            this.CmdSystemEintraege.Text = "Systemeinträge";
            this.CmdSystemEintraege.UseVisualStyleBackColor = true;
            this.CmdSystemEintraege.Click += new System.EventHandler(this.CmdSystemEintraege_Click);
            // 
            // LstAnzeige
            // 
            this.LstAnzeige.FormattingEnabled = true;
            this.LstAnzeige.Location = new System.Drawing.Point(12, 70);
            this.LstAnzeige.Name = "LstAnzeige";
            this.LstAnzeige.Size = new System.Drawing.Size(368, 160);
            this.LstAnzeige.TabIndex = 31;
            this.LstAnzeige.SelectedIndexChanged += new System.EventHandler(this.LstAnzeige_SelectedIndexChanged);
            // 
            // CmdDateiliste
            // 
            this.CmdDateiliste.Location = new System.Drawing.Point(12, 12);
            this.CmdDateiliste.Name = "CmdDateiliste";
            this.CmdDateiliste.Size = new System.Drawing.Size(80, 23);
            this.CmdDateiliste.TabIndex = 30;
            this.CmdDateiliste.Text = "Dateiliste";
            this.CmdDateiliste.UseVisualStyleBackColor = true;
            this.CmdDateiliste.Click += new System.EventHandler(this.CmdDateiliste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.LblAktuellesVerzeichnis);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdNachOben);
            this.Controls.Add(this.CmdInVerzeichnis);
            this.Controls.Add(this.CmdSystemEintraege);
            this.Controls.Add(this.LstAnzeige);
            this.Controls.Add(this.CmdDateiliste);
            this.Name = "Form1";
            this.Text = "Datei- und Verzeichnisliste";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LblAktuellesVerzeichnis;
        internal System.Windows.Forms.Label LblAnzeige;
        internal System.Windows.Forms.Button CmdNachOben;
        internal System.Windows.Forms.Button CmdInVerzeichnis;
        internal System.Windows.Forms.Button CmdSystemEintraege;
        internal System.Windows.Forms.ListBox LstAnzeige;
        internal System.Windows.Forms.Button CmdDateiliste;
    }
}

