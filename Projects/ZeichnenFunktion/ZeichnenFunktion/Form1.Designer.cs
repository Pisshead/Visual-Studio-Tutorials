namespace ZeichnenFunktion
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
            this.CmdZeichnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdZeichnen
            // 
            this.CmdZeichnen.Location = new System.Drawing.Point(317, 246);
            this.CmdZeichnen.Name = "CmdZeichnen";
            this.CmdZeichnen.Size = new System.Drawing.Size(75, 23);
            this.CmdZeichnen.TabIndex = 0;
            this.CmdZeichnen.Text = "Zeichnen";
            this.CmdZeichnen.UseVisualStyleBackColor = true;
            this.CmdZeichnen.Click += new System.EventHandler(this.CmdZeichnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 281);
            this.Controls.Add(this.CmdZeichnen);
            this.Name = "Form1";
            this.Text = "Funktion zeichnen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdZeichnen;
    }
}

