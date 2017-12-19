namespace USteuerbetrag
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
            this.LblGehalt = new System.Windows.Forms.Label();
            this.LblSteuerbetrag = new System.Windows.Forms.Label();
            this.CmdBerechnen = new System.Windows.Forms.Button();
            this.TxtGehalt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblGehalt
            // 
            this.LblGehalt.AutoSize = true;
            this.LblGehalt.Location = new System.Drawing.Point(12, 18);
            this.LblGehalt.Name = "LblGehalt";
            this.LblGehalt.Size = new System.Drawing.Size(41, 13);
            this.LblGehalt.TabIndex = 0;
            this.LblGehalt.Text = "Gehalt:";
            // 
            // LblSteuerbetrag
            // 
            this.LblSteuerbetrag.AutoSize = true;
            this.LblSteuerbetrag.Location = new System.Drawing.Point(127, 37);
            this.LblSteuerbetrag.Name = "LblSteuerbetrag";
            this.LblSteuerbetrag.Size = new System.Drawing.Size(30, 13);
            this.LblSteuerbetrag.TabIndex = 1;
            this.LblSteuerbetrag.Text = "(leer)";
            // 
            // CmdBerechnen
            // 
            this.CmdBerechnen.Location = new System.Drawing.Point(12, 69);
            this.CmdBerechnen.Name = "CmdBerechnen";
            this.CmdBerechnen.Size = new System.Drawing.Size(75, 23);
            this.CmdBerechnen.TabIndex = 2;
            this.CmdBerechnen.Text = "Berechnen";
            this.CmdBerechnen.UseVisualStyleBackColor = true;
            this.CmdBerechnen.Click += new System.EventHandler(this.CmdBerechnen_Click);
            // 
            // TxtGehalt
            // 
            this.TxtGehalt.Location = new System.Drawing.Point(12, 34);
            this.TxtGehalt.Name = "TxtGehalt";
            this.TxtGehalt.Size = new System.Drawing.Size(100, 20);
            this.TxtGehalt.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TxtGehalt);
            this.Controls.Add(this.CmdBerechnen);
            this.Controls.Add(this.LblSteuerbetrag);
            this.Controls.Add(this.LblGehalt);
            this.Name = "Form1";
            this.Text = "Steuerbetrag";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblGehalt;
        private System.Windows.Forms.Label LblSteuerbetrag;
        private System.Windows.Forms.Button CmdBerechnen;
        private System.Windows.Forms.TextBox TxtGehalt;
    }
}

