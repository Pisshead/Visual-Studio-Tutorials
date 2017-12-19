namespace DBMehrereTabellen
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
            this.CmdAlleProjekteZeitsumme = new System.Windows.Forms.Button();
            this.CmdAlleProjekteAllePersonenzeiten = new System.Windows.Forms.Button();
            this.CmdAllePersonenZeitsumme = new System.Windows.Forms.Button();
            this.CmdAllePersonenAlleProjektzeiten = new System.Windows.Forms.Button();
            this.CmdAlleKundenAlleProjekte = new System.Windows.Forms.Button();
            this.CmdAnzahlKunden = new System.Windows.Forms.Button();
            this.CmdAllePersonen = new System.Windows.Forms.Button();
            this.LstAnzeige = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CmdAlleProjekteZeitsumme
            // 
            this.CmdAlleProjekteZeitsumme.Location = new System.Drawing.Point(12, 186);
            this.CmdAlleProjekteZeitsumme.Name = "CmdAlleProjekteZeitsumme";
            this.CmdAlleProjekteZeitsumme.Size = new System.Drawing.Size(300, 23);
            this.CmdAlleProjekteZeitsumme.TabIndex = 64;
            this.CmdAlleProjekteZeitsumme.Text = "Alle Projekte mit Zeitsumme";
            this.CmdAlleProjekteZeitsumme.UseVisualStyleBackColor = true;
            this.CmdAlleProjekteZeitsumme.Click += new System.EventHandler(this.CmdAlleProjekteZeitsumme_Click);
            // 
            // CmdAlleProjekteAllePersonenzeiten
            // 
            this.CmdAlleProjekteAllePersonenzeiten.Location = new System.Drawing.Point(12, 157);
            this.CmdAlleProjekteAllePersonenzeiten.Name = "CmdAlleProjekteAllePersonenzeiten";
            this.CmdAlleProjekteAllePersonenzeiten.Size = new System.Drawing.Size(300, 23);
            this.CmdAlleProjekteAllePersonenzeiten.TabIndex = 63;
            this.CmdAlleProjekteAllePersonenzeiten.Text = "Alle Projekte mit allen Personenzeiten";
            this.CmdAlleProjekteAllePersonenzeiten.UseVisualStyleBackColor = true;
            this.CmdAlleProjekteAllePersonenzeiten.Click += new System.EventHandler(this.CmdAlleProjekteAllePersonenzeiten_Click);
            // 
            // CmdAllePersonenZeitsumme
            // 
            this.CmdAllePersonenZeitsumme.Location = new System.Drawing.Point(12, 128);
            this.CmdAllePersonenZeitsumme.Name = "CmdAllePersonenZeitsumme";
            this.CmdAllePersonenZeitsumme.Size = new System.Drawing.Size(300, 23);
            this.CmdAllePersonenZeitsumme.TabIndex = 62;
            this.CmdAllePersonenZeitsumme.Text = "Alle Personen mit Zeitsumme";
            this.CmdAllePersonenZeitsumme.UseVisualStyleBackColor = true;
            this.CmdAllePersonenZeitsumme.Click += new System.EventHandler(this.CmdAllePersonenZeitsumme_Click);
            // 
            // CmdAllePersonenAlleProjektzeiten
            // 
            this.CmdAllePersonenAlleProjektzeiten.Location = new System.Drawing.Point(12, 99);
            this.CmdAllePersonenAlleProjektzeiten.Name = "CmdAllePersonenAlleProjektzeiten";
            this.CmdAllePersonenAlleProjektzeiten.Size = new System.Drawing.Size(300, 23);
            this.CmdAllePersonenAlleProjektzeiten.TabIndex = 61;
            this.CmdAllePersonenAlleProjektzeiten.Text = "Alle Personen mit allen Projektzeiten";
            this.CmdAllePersonenAlleProjektzeiten.UseVisualStyleBackColor = true;
            this.CmdAllePersonenAlleProjektzeiten.Click += new System.EventHandler(this.CmdAllePersonenAlleProjektzeiten_Click);
            // 
            // CmdAlleKundenAlleProjekte
            // 
            this.CmdAlleKundenAlleProjekte.Location = new System.Drawing.Point(12, 70);
            this.CmdAlleKundenAlleProjekte.Name = "CmdAlleKundenAlleProjekte";
            this.CmdAlleKundenAlleProjekte.Size = new System.Drawing.Size(300, 23);
            this.CmdAlleKundenAlleProjekte.TabIndex = 60;
            this.CmdAlleKundenAlleProjekte.Text = "Alle Kunden mit allen Projekten";
            this.CmdAlleKundenAlleProjekte.UseVisualStyleBackColor = true;
            this.CmdAlleKundenAlleProjekte.Click += new System.EventHandler(this.CmdAlleKundenAlleProjekte_Click);
            // 
            // CmdAnzahlKunden
            // 
            this.CmdAnzahlKunden.Location = new System.Drawing.Point(12, 41);
            this.CmdAnzahlKunden.Name = "CmdAnzahlKunden";
            this.CmdAnzahlKunden.Size = new System.Drawing.Size(300, 23);
            this.CmdAnzahlKunden.TabIndex = 59;
            this.CmdAnzahlKunden.Text = "Anzahl der Kunden";
            this.CmdAnzahlKunden.UseVisualStyleBackColor = true;
            this.CmdAnzahlKunden.Click += new System.EventHandler(this.CmdAnzahlKunden_Click);
            // 
            // CmdAllePersonen
            // 
            this.CmdAllePersonen.Location = new System.Drawing.Point(12, 12);
            this.CmdAllePersonen.Name = "CmdAllePersonen";
            this.CmdAllePersonen.Size = new System.Drawing.Size(300, 23);
            this.CmdAllePersonen.TabIndex = 58;
            this.CmdAllePersonen.Text = "Alle Personen";
            this.CmdAllePersonen.UseVisualStyleBackColor = true;
            this.CmdAllePersonen.Click += new System.EventHandler(this.CmdAllePersonen_Click);
            // 
            // LstAnzeige
            // 
            this.LstAnzeige.FormattingEnabled = true;
            this.LstAnzeige.Location = new System.Drawing.Point(12, 215);
            this.LstAnzeige.Name = "LstAnzeige";
            this.LstAnzeige.Size = new System.Drawing.Size(300, 95);
            this.LstAnzeige.TabIndex = 57;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 321);
            this.Controls.Add(this.CmdAlleProjekteZeitsumme);
            this.Controls.Add(this.CmdAlleProjekteAllePersonenzeiten);
            this.Controls.Add(this.CmdAllePersonenZeitsumme);
            this.Controls.Add(this.CmdAllePersonenAlleProjektzeiten);
            this.Controls.Add(this.CmdAlleKundenAlleProjekte);
            this.Controls.Add(this.CmdAnzahlKunden);
            this.Controls.Add(this.CmdAllePersonen);
            this.Controls.Add(this.LstAnzeige);
            this.Name = "Form1";
            this.Text = "Datenbank, mehrere Tabellen";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button CmdAlleProjekteZeitsumme;
        internal System.Windows.Forms.Button CmdAlleProjekteAllePersonenzeiten;
        internal System.Windows.Forms.Button CmdAllePersonenZeitsumme;
        internal System.Windows.Forms.Button CmdAllePersonenAlleProjektzeiten;
        internal System.Windows.Forms.Button CmdAlleKundenAlleProjekte;
        internal System.Windows.Forms.Button CmdAnzahlKunden;
        internal System.Windows.Forms.Button CmdAllePersonen;
        internal System.Windows.Forms.ListBox LstAnzeige;
    }
}

