namespace DateiSchreiben
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
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.CmdSchreiben = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(12, 55);
            this.TxtEingabe.Multiline = true;
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(200, 150);
            this.TxtEingabe.TabIndex = 11;
            // 
            // CmdSchreiben
            // 
            this.CmdSchreiben.Location = new System.Drawing.Point(12, 12);
            this.CmdSchreiben.Name = "CmdSchreiben";
            this.CmdSchreiben.Size = new System.Drawing.Size(75, 23);
            this.CmdSchreiben.TabIndex = 10;
            this.CmdSchreiben.Text = "Schreiben";
            this.CmdSchreiben.UseVisualStyleBackColor = true;
            this.CmdSchreiben.Click += new System.EventHandler(this.CmdSchreiben_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TxtEingabe);
            this.Controls.Add(this.CmdSchreiben);
            this.Name = "Form1";
            this.Text = "Datei schreiben";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TxtEingabe;
        internal System.Windows.Forms.Button CmdSchreiben;
    }
}

