namespace ListenfeldMethoden
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
            this.LstSpeisen = new System.Windows.Forms.ListBox();
            this.LblAuswahl = new System.Windows.Forms.Label();
            this.CmdLoeschen = new System.Windows.Forms.Button();
            this.CmdErsetzen = new System.Windows.Forms.Button();
            this.TxtErsetzen = new System.Windows.Forms.TextBox();
            this.TxtNeu = new System.Windows.Forms.TextBox();
            this.CmdEinfuegen = new System.Windows.Forms.Button();
            this.LblEinfuegen = new System.Windows.Forms.Label();
            this.OptEnde = new System.Windows.Forms.RadioButton();
            this.OptAnfang = new System.Windows.Forms.RadioButton();
            this.OptAuswahl = new System.Windows.Forms.RadioButton();
            this.CmdAllesLoeschen = new System.Windows.Forms.Button();
            this.LblNeu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstSpeisen
            // 
            this.LstSpeisen.FormattingEnabled = true;
            this.LstSpeisen.Location = new System.Drawing.Point(12, 12);
            this.LstSpeisen.Name = "LstSpeisen";
            this.LstSpeisen.Size = new System.Drawing.Size(120, 95);
            this.LstSpeisen.TabIndex = 0;
            // 
            // LblAuswahl
            // 
            this.LblAuswahl.AutoSize = true;
            this.LblAuswahl.Location = new System.Drawing.Point(12, 125);
            this.LblAuswahl.Name = "LblAuswahl";
            this.LblAuswahl.Size = new System.Drawing.Size(117, 13);
            this.LblAuswahl.TabIndex = 1;
            this.LblAuswahl.Text = "Ausgewähltes Element:";
            // 
            // CmdLoeschen
            // 
            this.CmdLoeschen.Location = new System.Drawing.Point(12, 141);
            this.CmdLoeschen.Name = "CmdLoeschen";
            this.CmdLoeschen.Size = new System.Drawing.Size(100, 23);
            this.CmdLoeschen.TabIndex = 2;
            this.CmdLoeschen.Text = "Löschen";
            this.CmdLoeschen.UseVisualStyleBackColor = true;
            this.CmdLoeschen.Click += new System.EventHandler(this.CmdLoeschen_Click);
            // 
            // CmdErsetzen
            // 
            this.CmdErsetzen.Location = new System.Drawing.Point(12, 170);
            this.CmdErsetzen.Name = "CmdErsetzen";
            this.CmdErsetzen.Size = new System.Drawing.Size(100, 23);
            this.CmdErsetzen.TabIndex = 3;
            this.CmdErsetzen.Text = "Ersetzen durch:";
            this.CmdErsetzen.UseVisualStyleBackColor = true;
            this.CmdErsetzen.Click += new System.EventHandler(this.CmdErsetzen_Click);
            // 
            // TxtErsetzen
            // 
            this.TxtErsetzen.Location = new System.Drawing.Point(12, 199);
            this.TxtErsetzen.Name = "TxtErsetzen";
            this.TxtErsetzen.Size = new System.Drawing.Size(100, 20);
            this.TxtErsetzen.TabIndex = 4;
            // 
            // TxtNeu
            // 
            this.TxtNeu.Location = new System.Drawing.Point(161, 28);
            this.TxtNeu.Name = "TxtNeu";
            this.TxtNeu.Size = new System.Drawing.Size(100, 20);
            this.TxtNeu.TabIndex = 5;
            // 
            // CmdEinfuegen
            // 
            this.CmdEinfuegen.Location = new System.Drawing.Point(161, 54);
            this.CmdEinfuegen.Name = "CmdEinfuegen";
            this.CmdEinfuegen.Size = new System.Drawing.Size(100, 23);
            this.CmdEinfuegen.TabIndex = 6;
            this.CmdEinfuegen.Text = "Einfügen";
            this.CmdEinfuegen.UseVisualStyleBackColor = true;
            this.CmdEinfuegen.Click += new System.EventHandler(this.CmdEinfuegen_Click);
            // 
            // LblEinfuegen
            // 
            this.LblEinfuegen.AutoSize = true;
            this.LblEinfuegen.Location = new System.Drawing.Point(158, 94);
            this.LblEinfuegen.Name = "LblEinfuegen";
            this.LblEinfuegen.Size = new System.Drawing.Size(58, 13);
            this.LblEinfuegen.TabIndex = 7;
            this.LblEinfuegen.Text = "Einfügeort:";
            // 
            // OptEnde
            // 
            this.OptEnde.AutoSize = true;
            this.OptEnde.Checked = true;
            this.OptEnde.Location = new System.Drawing.Point(161, 113);
            this.OptEnde.Name = "OptEnde";
            this.OptEnde.Size = new System.Drawing.Size(111, 17);
            this.OptEnde.TabIndex = 8;
            this.OptEnde.TabStop = true;
            this.OptEnde.Text = "Am Ende der Liste";
            this.OptEnde.UseVisualStyleBackColor = true;
            // 
            // OptAnfang
            // 
            this.OptAnfang.AutoSize = true;
            this.OptAnfang.Location = new System.Drawing.Point(161, 136);
            this.OptAnfang.Name = "OptAnfang";
            this.OptAnfang.Size = new System.Drawing.Size(120, 17);
            this.OptAnfang.TabIndex = 9;
            this.OptAnfang.Text = "Am Anfang der Liste";
            this.OptAnfang.UseVisualStyleBackColor = true;
            // 
            // OptAuswahl
            // 
            this.OptAuswahl.AutoSize = true;
            this.OptAuswahl.Location = new System.Drawing.Point(161, 159);
            this.OptAuswahl.Name = "OptAuswahl";
            this.OptAuswahl.Size = new System.Drawing.Size(153, 17);
            this.OptAuswahl.TabIndex = 10;
            this.OptAuswahl.Text = "Vor ausgewähltem Element";
            this.OptAuswahl.UseVisualStyleBackColor = true;
            // 
            // CmdAllesLoeschen
            // 
            this.CmdAllesLoeschen.Location = new System.Drawing.Point(161, 196);
            this.CmdAllesLoeschen.Name = "CmdAllesLoeschen";
            this.CmdAllesLoeschen.Size = new System.Drawing.Size(100, 23);
            this.CmdAllesLoeschen.TabIndex = 11;
            this.CmdAllesLoeschen.Text = "Alles löschen";
            this.CmdAllesLoeschen.UseVisualStyleBackColor = true;
            this.CmdAllesLoeschen.Click += new System.EventHandler(this.CmdAllesLoeschen_Click);
            // 
            // LblNeu
            // 
            this.LblNeu.AutoSize = true;
            this.LblNeu.Location = new System.Drawing.Point(158, 12);
            this.LblNeu.Name = "LblNeu";
            this.LblNeu.Size = new System.Drawing.Size(82, 13);
            this.LblNeu.TabIndex = 12;
            this.LblNeu.Text = "Neues Element:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.LblNeu);
            this.Controls.Add(this.CmdAllesLoeschen);
            this.Controls.Add(this.OptAuswahl);
            this.Controls.Add(this.OptAnfang);
            this.Controls.Add(this.OptEnde);
            this.Controls.Add(this.LblEinfuegen);
            this.Controls.Add(this.CmdEinfuegen);
            this.Controls.Add(this.TxtNeu);
            this.Controls.Add(this.TxtErsetzen);
            this.Controls.Add(this.CmdErsetzen);
            this.Controls.Add(this.CmdLoeschen);
            this.Controls.Add(this.LblAuswahl);
            this.Controls.Add(this.LstSpeisen);
            this.Name = "Form1";
            this.Text = "Listenfeld-Methoden";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstSpeisen;
        private System.Windows.Forms.Label LblAuswahl;
        private System.Windows.Forms.Button CmdLoeschen;
        private System.Windows.Forms.Button CmdErsetzen;
        private System.Windows.Forms.TextBox TxtErsetzen;
        private System.Windows.Forms.TextBox TxtNeu;
        private System.Windows.Forms.Button CmdEinfuegen;
        private System.Windows.Forms.Label LblEinfuegen;
        private System.Windows.Forms.RadioButton OptEnde;
        private System.Windows.Forms.RadioButton OptAnfang;
        private System.Windows.Forms.RadioButton OptAuswahl;
        private System.Windows.Forms.Button CmdAllesLoeschen;
        private System.Windows.Forms.Label LblNeu;
    }
}

