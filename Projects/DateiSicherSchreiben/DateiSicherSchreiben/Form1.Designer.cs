namespace DateiSicherSchreiben
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
            this.CmdAusnahme = new System.Windows.Forms.Button();
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdAusnahme
            // 
            this.CmdAusnahme.Location = new System.Drawing.Point(12, 12);
            this.CmdAusnahme.Name = "CmdAusnahme";
            this.CmdAusnahme.Size = new System.Drawing.Size(75, 23);
            this.CmdAusnahme.TabIndex = 14;
            this.CmdAusnahme.Text = "Ausnahme";
            this.CmdAusnahme.UseVisualStyleBackColor = true;
            this.CmdAusnahme.Click += new System.EventHandler(this.CmdAusnahme_Click);
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(12, 55);
            this.TxtEingabe.Multiline = true;
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(200, 150);
            this.TxtEingabe.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdAusnahme);
            this.Controls.Add(this.TxtEingabe);
            this.Name = "Form1";
            this.Text = "Datei sicher schreiben";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdAusnahme;
        internal System.Windows.Forms.TextBox TxtEingabe;
    }
}

