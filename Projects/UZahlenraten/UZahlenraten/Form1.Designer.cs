namespace UZahlenraten
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
            this.CmdErzeugen = new System.Windows.Forms.Button();
            this.CmdPruefen = new System.Windows.Forms.Button();
            this.LblEingabe = new System.Windows.Forms.Label();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdErzeugen
            // 
            this.CmdErzeugen.Location = new System.Drawing.Point(247, 12);
            this.CmdErzeugen.Name = "CmdErzeugen";
            this.CmdErzeugen.Size = new System.Drawing.Size(75, 23);
            this.CmdErzeugen.TabIndex = 0;
            this.CmdErzeugen.Text = "Erzeugen";
            this.CmdErzeugen.UseVisualStyleBackColor = true;
            this.CmdErzeugen.Click += new System.EventHandler(this.CmdErzeugen_Click);
            // 
            // CmdPruefen
            // 
            this.CmdPruefen.Location = new System.Drawing.Point(247, 41);
            this.CmdPruefen.Name = "CmdPruefen";
            this.CmdPruefen.Size = new System.Drawing.Size(75, 23);
            this.CmdPruefen.TabIndex = 1;
            this.CmdPruefen.Text = "Prüfen";
            this.CmdPruefen.UseVisualStyleBackColor = true;
            this.CmdPruefen.Click += new System.EventHandler(this.CmdPruefen_Click);
            // 
            // LblEingabe
            // 
            this.LblEingabe.AutoSize = true;
            this.LblEingabe.Location = new System.Drawing.Point(12, 47);
            this.LblEingabe.Name = "LblEingabe";
            this.LblEingabe.Size = new System.Drawing.Size(49, 13);
            this.LblEingabe.TabIndex = 2;
            this.LblEingabe.Text = "Eingabe:";
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(12, 81);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige.TabIndex = 3;
            this.LblAnzeige.Text = "(leer)";
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(121, 44);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.TxtEingabe);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.LblEingabe);
            this.Controls.Add(this.CmdPruefen);
            this.Controls.Add(this.CmdErzeugen);
            this.Name = "Form1";
            this.Text = "Zahl zwischen 1 und 100";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdErzeugen;
        private System.Windows.Forms.Button CmdPruefen;
        private System.Windows.Forms.Label LblEingabe;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.TextBox TxtEingabe;
    }
}

