namespace Kontrollkaestchen
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
            this.LblTest1 = new System.Windows.Forms.Label();
            this.LblTest2 = new System.Windows.Forms.Label();
            this.CmdPruefen = new System.Windows.Forms.Button();
            this.CmdUmschalten = new System.Windows.Forms.Button();
            this.ChkSchalter = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LblTest1
            // 
            this.LblTest1.AutoSize = true;
            this.LblTest1.Location = new System.Drawing.Point(12, 17);
            this.LblTest1.Name = "LblTest1";
            this.LblTest1.Size = new System.Drawing.Size(30, 13);
            this.LblTest1.TabIndex = 0;
            this.LblTest1.Text = "(leer)";
            // 
            // LblTest2
            // 
            this.LblTest2.AutoSize = true;
            this.LblTest2.Location = new System.Drawing.Point(12, 59);
            this.LblTest2.Name = "LblTest2";
            this.LblTest2.Size = new System.Drawing.Size(30, 13);
            this.LblTest2.TabIndex = 1;
            this.LblTest2.Text = "(leer)";
            // 
            // CmdPruefen
            // 
            this.CmdPruefen.Location = new System.Drawing.Point(152, 12);
            this.CmdPruefen.Name = "CmdPruefen";
            this.CmdPruefen.Size = new System.Drawing.Size(120, 23);
            this.CmdPruefen.TabIndex = 2;
            this.CmdPruefen.Text = "Schalter prüfen";
            this.CmdPruefen.UseVisualStyleBackColor = true;
            this.CmdPruefen.Click += new System.EventHandler(this.CmdPruefen_Click);
            // 
            // CmdUmschalten
            // 
            this.CmdUmschalten.Location = new System.Drawing.Point(152, 81);
            this.CmdUmschalten.Name = "CmdUmschalten";
            this.CmdUmschalten.Size = new System.Drawing.Size(120, 23);
            this.CmdUmschalten.TabIndex = 3;
            this.CmdUmschalten.Text = "Schalter umschalten";
            this.CmdUmschalten.UseVisualStyleBackColor = true;
            this.CmdUmschalten.Click += new System.EventHandler(this.CmdUmschalten_Click);
            // 
            // ChkSchalter
            // 
            this.ChkSchalter.AutoSize = true;
            this.ChkSchalter.Location = new System.Drawing.Point(152, 59);
            this.ChkSchalter.Name = "ChkSchalter";
            this.ChkSchalter.Size = new System.Drawing.Size(65, 17);
            this.ChkSchalter.TabIndex = 4;
            this.ChkSchalter.Text = "Schalter";
            this.ChkSchalter.UseVisualStyleBackColor = true;
            this.ChkSchalter.CheckedChanged += new System.EventHandler(this.ChkSchalter_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ChkSchalter);
            this.Controls.Add(this.CmdUmschalten);
            this.Controls.Add(this.CmdPruefen);
            this.Controls.Add(this.LblTest2);
            this.Controls.Add(this.LblTest1);
            this.Name = "Form1";
            this.Text = "Kontrollkästchen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTest1;
        private System.Windows.Forms.Label LblTest2;
        private System.Windows.Forms.Button CmdPruefen;
        private System.Windows.Forms.Button CmdUmschalten;
        private System.Windows.Forms.CheckBox ChkSchalter;
    }
}

