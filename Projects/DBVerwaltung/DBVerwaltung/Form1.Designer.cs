namespace DBVerwaltung
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
            this.CmdNameSuchen = new System.Windows.Forms.Button();
            this.LblGeburtstag = new System.Windows.Forms.Label();
            this.LblGehalt = new System.Windows.Forms.Label();
            this.LblPersonalnummer = new System.Windows.Forms.Label();
            this.LblVorname = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtGeburtstag = new System.Windows.Forms.TextBox();
            this.TxtGehalt = new System.Windows.Forms.TextBox();
            this.TxtPersonalnummer = new System.Windows.Forms.TextBox();
            this.TxtVorname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LstAnzeige = new System.Windows.Forms.ListBox();
            this.CmdLoeschen = new System.Windows.Forms.Button();
            this.CmdAendern = new System.Windows.Forms.Button();
            this.CmdEinfuegen = new System.Windows.Forms.Button();
            this.CmdAlleSehen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdNameSuchen
            // 
            this.CmdNameSuchen.Location = new System.Drawing.Point(230, 12);
            this.CmdNameSuchen.Name = "CmdNameSuchen";
            this.CmdNameSuchen.Size = new System.Drawing.Size(100, 23);
            this.CmdNameSuchen.TabIndex = 111;
            this.CmdNameSuchen.Text = "Name suchen";
            this.CmdNameSuchen.UseVisualStyleBackColor = true;
            this.CmdNameSuchen.Click += new System.EventHandler(this.CmdNameSuchen_Click);
            // 
            // LblGeburtstag
            // 
            this.LblGeburtstag.AutoSize = true;
            this.LblGeburtstag.Location = new System.Drawing.Point(136, 147);
            this.LblGeburtstag.Name = "LblGeburtstag";
            this.LblGeburtstag.Size = new System.Drawing.Size(62, 13);
            this.LblGeburtstag.TabIndex = 110;
            this.LblGeburtstag.Text = "Geburtstag:";
            // 
            // LblGehalt
            // 
            this.LblGehalt.AutoSize = true;
            this.LblGehalt.Location = new System.Drawing.Point(136, 121);
            this.LblGehalt.Name = "LblGehalt";
            this.LblGehalt.Size = new System.Drawing.Size(41, 13);
            this.LblGehalt.TabIndex = 109;
            this.LblGehalt.Text = "Gehalt:";
            // 
            // LblPersonalnummer
            // 
            this.LblPersonalnummer.AutoSize = true;
            this.LblPersonalnummer.Location = new System.Drawing.Point(136, 95);
            this.LblPersonalnummer.Name = "LblPersonalnummer";
            this.LblPersonalnummer.Size = new System.Drawing.Size(88, 13);
            this.LblPersonalnummer.TabIndex = 108;
            this.LblPersonalnummer.Text = "Personalnummer:";
            // 
            // LblVorname
            // 
            this.LblVorname.AutoSize = true;
            this.LblVorname.Location = new System.Drawing.Point(136, 69);
            this.LblVorname.Name = "LblVorname";
            this.LblVorname.Size = new System.Drawing.Size(52, 13);
            this.LblVorname.TabIndex = 107;
            this.LblVorname.Text = "Vorname:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Location = new System.Drawing.Point(136, 43);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(38, 13);
            this.LblName.TabIndex = 106;
            this.LblName.Text = "Name:";
            // 
            // TxtGeburtstag
            // 
            this.TxtGeburtstag.Location = new System.Drawing.Point(230, 144);
            this.TxtGeburtstag.Name = "TxtGeburtstag";
            this.TxtGeburtstag.Size = new System.Drawing.Size(100, 20);
            this.TxtGeburtstag.TabIndex = 105;
            // 
            // TxtGehalt
            // 
            this.TxtGehalt.Location = new System.Drawing.Point(230, 118);
            this.TxtGehalt.Name = "TxtGehalt";
            this.TxtGehalt.Size = new System.Drawing.Size(100, 20);
            this.TxtGehalt.TabIndex = 104;
            // 
            // TxtPersonalnummer
            // 
            this.TxtPersonalnummer.Location = new System.Drawing.Point(230, 92);
            this.TxtPersonalnummer.Name = "TxtPersonalnummer";
            this.TxtPersonalnummer.Size = new System.Drawing.Size(100, 20);
            this.TxtPersonalnummer.TabIndex = 103;
            // 
            // TxtVorname
            // 
            this.TxtVorname.Location = new System.Drawing.Point(230, 66);
            this.TxtVorname.Name = "TxtVorname";
            this.TxtVorname.Size = new System.Drawing.Size(100, 20);
            this.TxtVorname.TabIndex = 102;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(230, 40);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 20);
            this.TxtName.TabIndex = 101;
            // 
            // LstAnzeige
            // 
            this.LstAnzeige.FormattingEnabled = true;
            this.LstAnzeige.Location = new System.Drawing.Point(12, 182);
            this.LstAnzeige.Name = "LstAnzeige";
            this.LstAnzeige.Size = new System.Drawing.Size(318, 121);
            this.LstAnzeige.TabIndex = 100;
            this.LstAnzeige.SelectedIndexChanged += new System.EventHandler(this.LstAnzeige_SelectedIndexChanged);
            // 
            // CmdLoeschen
            // 
            this.CmdLoeschen.Location = new System.Drawing.Point(12, 99);
            this.CmdLoeschen.Name = "CmdLoeschen";
            this.CmdLoeschen.Size = new System.Drawing.Size(75, 23);
            this.CmdLoeschen.TabIndex = 99;
            this.CmdLoeschen.Text = "Löschen";
            this.CmdLoeschen.UseVisualStyleBackColor = true;
            this.CmdLoeschen.Click += new System.EventHandler(this.CmdLoeschen_Click);
            // 
            // CmdAendern
            // 
            this.CmdAendern.Location = new System.Drawing.Point(12, 69);
            this.CmdAendern.Name = "CmdAendern";
            this.CmdAendern.Size = new System.Drawing.Size(75, 23);
            this.CmdAendern.TabIndex = 98;
            this.CmdAendern.Text = "Ändern";
            this.CmdAendern.UseVisualStyleBackColor = true;
            this.CmdAendern.Click += new System.EventHandler(this.CmdAendern_Click);
            // 
            // CmdEinfuegen
            // 
            this.CmdEinfuegen.Location = new System.Drawing.Point(12, 40);
            this.CmdEinfuegen.Name = "CmdEinfuegen";
            this.CmdEinfuegen.Size = new System.Drawing.Size(75, 23);
            this.CmdEinfuegen.TabIndex = 97;
            this.CmdEinfuegen.Text = "Einfügen";
            this.CmdEinfuegen.UseVisualStyleBackColor = true;
            this.CmdEinfuegen.Click += new System.EventHandler(this.CmdEinfuegen_Click);
            // 
            // CmdAlleSehen
            // 
            this.CmdAlleSehen.Location = new System.Drawing.Point(12, 12);
            this.CmdAlleSehen.Name = "CmdAlleSehen";
            this.CmdAlleSehen.Size = new System.Drawing.Size(75, 23);
            this.CmdAlleSehen.TabIndex = 96;
            this.CmdAlleSehen.Text = "Alle sehen";
            this.CmdAlleSehen.UseVisualStyleBackColor = true;
            this.CmdAlleSehen.Click += new System.EventHandler(this.CmdAlleSehen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 321);
            this.Controls.Add(this.CmdNameSuchen);
            this.Controls.Add(this.LblGeburtstag);
            this.Controls.Add(this.LblGehalt);
            this.Controls.Add(this.LblPersonalnummer);
            this.Controls.Add(this.LblVorname);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.TxtGeburtstag);
            this.Controls.Add(this.TxtGehalt);
            this.Controls.Add(this.TxtPersonalnummer);
            this.Controls.Add(this.TxtVorname);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.LstAnzeige);
            this.Controls.Add(this.CmdLoeschen);
            this.Controls.Add(this.CmdAendern);
            this.Controls.Add(this.CmdEinfuegen);
            this.Controls.Add(this.CmdAlleSehen);
            this.Name = "Form1";
            this.Text = "Datenbank, Verwaltung";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdNameSuchen;
        internal System.Windows.Forms.Label LblGeburtstag;
        internal System.Windows.Forms.Label LblGehalt;
        internal System.Windows.Forms.Label LblPersonalnummer;
        internal System.Windows.Forms.Label LblVorname;
        internal System.Windows.Forms.Label LblName;
        internal System.Windows.Forms.TextBox TxtGeburtstag;
        internal System.Windows.Forms.TextBox TxtGehalt;
        internal System.Windows.Forms.TextBox TxtPersonalnummer;
        internal System.Windows.Forms.TextBox TxtVorname;
        internal System.Windows.Forms.TextBox TxtName;
        internal System.Windows.Forms.ListBox LstAnzeige;
        internal System.Windows.Forms.Button CmdLoeschen;
        internal System.Windows.Forms.Button CmdAendern;
        internal System.Windows.Forms.Button CmdEinfuegen;
        internal System.Windows.Forms.Button CmdAlleSehen;
    }
}

