namespace StringGrundlagen
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
            this.CmdSplitten = new System.Windows.Forms.Button();
            this.CmdTrimmen = new System.Windows.Forms.Button();
            this.CmdSucheAlle = new System.Windows.Forms.Button();
            this.CmdSucheEins = new System.Windows.Forms.Button();
            this.LblSuche = new System.Windows.Forms.Label();
            this.TxtSuche = new System.Windows.Forms.TextBox();
            this.LblEingabe = new System.Windows.Forms.Label();
            this.CmdZeichen = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdLaenge = new System.Windows.Forms.Button();
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdSplitten
            // 
            this.CmdSplitten.Location = new System.Drawing.Point(197, 99);
            this.CmdSplitten.Name = "CmdSplitten";
            this.CmdSplitten.Size = new System.Drawing.Size(75, 23);
            this.CmdSplitten.TabIndex = 58;
            this.CmdSplitten.Text = "Splitten";
            this.CmdSplitten.UseVisualStyleBackColor = true;
            this.CmdSplitten.Click += new System.EventHandler(this.CmdSplitten_Click);
            // 
            // CmdTrimmen
            // 
            this.CmdTrimmen.Location = new System.Drawing.Point(197, 70);
            this.CmdTrimmen.Name = "CmdTrimmen";
            this.CmdTrimmen.Size = new System.Drawing.Size(75, 23);
            this.CmdTrimmen.TabIndex = 57;
            this.CmdTrimmen.Text = "Trimmen";
            this.CmdTrimmen.UseVisualStyleBackColor = true;
            this.CmdTrimmen.Click += new System.EventHandler(this.CmdTrimmen_Click);
            // 
            // CmdSucheAlle
            // 
            this.CmdSucheAlle.Location = new System.Drawing.Point(197, 198);
            this.CmdSucheAlle.Name = "CmdSucheAlle";
            this.CmdSucheAlle.Size = new System.Drawing.Size(75, 23);
            this.CmdSucheAlle.TabIndex = 56;
            this.CmdSucheAlle.Text = "Suche alle";
            this.CmdSucheAlle.UseVisualStyleBackColor = true;
            this.CmdSucheAlle.Click += new System.EventHandler(this.CmdSucheAlle_Click);
            // 
            // CmdSucheEins
            // 
            this.CmdSucheEins.Location = new System.Drawing.Point(197, 169);
            this.CmdSucheEins.Name = "CmdSucheEins";
            this.CmdSucheEins.Size = new System.Drawing.Size(75, 23);
            this.CmdSucheEins.TabIndex = 55;
            this.CmdSucheEins.Text = "Suche eins";
            this.CmdSucheEins.UseVisualStyleBackColor = true;
            this.CmdSucheEins.Click += new System.EventHandler(this.CmdSucheEins_Click);
            // 
            // LblSuche
            // 
            this.LblSuche.AutoSize = true;
            this.LblSuche.Location = new System.Drawing.Point(127, 147);
            this.LblSuche.Name = "LblSuche";
            this.LblSuche.Size = new System.Drawing.Size(41, 13);
            this.LblSuche.TabIndex = 54;
            this.LblSuche.Text = "Suche:";
            // 
            // TxtSuche
            // 
            this.TxtSuche.Location = new System.Drawing.Point(172, 143);
            this.TxtSuche.Name = "TxtSuche";
            this.TxtSuche.Size = new System.Drawing.Size(100, 20);
            this.TxtSuche.TabIndex = 53;
            // 
            // LblEingabe
            // 
            this.LblEingabe.AutoSize = true;
            this.LblEingabe.Location = new System.Drawing.Point(9, 17);
            this.LblEingabe.Name = "LblEingabe";
            this.LblEingabe.Size = new System.Drawing.Size(49, 13);
            this.LblEingabe.TabIndex = 52;
            this.LblEingabe.Text = "Eingabe:";
            // 
            // CmdZeichen
            // 
            this.CmdZeichen.Location = new System.Drawing.Point(197, 41);
            this.CmdZeichen.Name = "CmdZeichen";
            this.CmdZeichen.Size = new System.Drawing.Size(75, 23);
            this.CmdZeichen.TabIndex = 51;
            this.CmdZeichen.Text = "Zeichen";
            this.CmdZeichen.UseVisualStyleBackColor = true;
            this.CmdZeichen.Click += new System.EventHandler(this.CmdZeichen_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(13, 70);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige.TabIndex = 50;
            this.LblAnzeige.Text = "(leer)";
            // 
            // CmdLaenge
            // 
            this.CmdLaenge.Location = new System.Drawing.Point(197, 12);
            this.CmdLaenge.Name = "CmdLaenge";
            this.CmdLaenge.Size = new System.Drawing.Size(75, 23);
            this.CmdLaenge.TabIndex = 49;
            this.CmdLaenge.Text = "Länge";
            this.CmdLaenge.UseVisualStyleBackColor = true;
            this.CmdLaenge.Click += new System.EventHandler(this.CmdLaenge_Click);
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(9, 33);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(150, 20);
            this.TxtEingabe.TabIndex = 48;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdSplitten);
            this.Controls.Add(this.CmdTrimmen);
            this.Controls.Add(this.CmdSucheAlle);
            this.Controls.Add(this.CmdSucheEins);
            this.Controls.Add(this.LblSuche);
            this.Controls.Add(this.TxtSuche);
            this.Controls.Add(this.LblEingabe);
            this.Controls.Add(this.CmdZeichen);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdLaenge);
            this.Controls.Add(this.TxtEingabe);
            this.Name = "Form1";
            this.Text = "Strings, Grundlagen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdSplitten;
        internal System.Windows.Forms.Button CmdTrimmen;
        internal System.Windows.Forms.Button CmdSucheAlle;
        internal System.Windows.Forms.Button CmdSucheEins;
        internal System.Windows.Forms.Label LblSuche;
        internal System.Windows.Forms.TextBox TxtSuche;
        internal System.Windows.Forms.Label LblEingabe;
        internal System.Windows.Forms.Button CmdZeichen;
        internal System.Windows.Forms.Label LblAnzeige;
        internal System.Windows.Forms.Button CmdLaenge;
        internal System.Windows.Forms.TextBox TxtEingabe;
    }
}

