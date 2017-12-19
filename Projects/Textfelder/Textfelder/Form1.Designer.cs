namespace Textfelder
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
            this.CmdAusgabe = new System.Windows.Forms.Button();
            this.CmdRechnen = new System.Windows.Forms.Button();
            this.LblAusgabe = new System.Windows.Forms.Label();
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdAusgabe
            // 
            this.CmdAusgabe.Location = new System.Drawing.Point(197, 12);
            this.CmdAusgabe.Name = "CmdAusgabe";
            this.CmdAusgabe.Size = new System.Drawing.Size(75, 23);
            this.CmdAusgabe.TabIndex = 0;
            this.CmdAusgabe.Text = "Ausgabe";
            this.CmdAusgabe.UseVisualStyleBackColor = true;
            this.CmdAusgabe.Click += new System.EventHandler(this.CmdAusgabe_Click);
            // 
            // CmdRechnen
            // 
            this.CmdRechnen.Location = new System.Drawing.Point(197, 41);
            this.CmdRechnen.Name = "CmdRechnen";
            this.CmdRechnen.Size = new System.Drawing.Size(75, 23);
            this.CmdRechnen.TabIndex = 1;
            this.CmdRechnen.Text = "Rechnen";
            this.CmdRechnen.UseVisualStyleBackColor = true;
            this.CmdRechnen.Click += new System.EventHandler(this.CmdRechnen_Click);
            // 
            // LblAusgabe
            // 
            this.LblAusgabe.AutoSize = true;
            this.LblAusgabe.Location = new System.Drawing.Point(12, 78);
            this.LblAusgabe.Name = "LblAusgabe";
            this.LblAusgabe.Size = new System.Drawing.Size(30, 13);
            this.LblAusgabe.TabIndex = 2;
            this.LblAusgabe.Text = "(leer)";
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(12, 12);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TxtEingabe);
            this.Controls.Add(this.LblAusgabe);
            this.Controls.Add(this.CmdRechnen);
            this.Controls.Add(this.CmdAusgabe);
            this.Name = "Form1";
            this.Text = "Textfelder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdAusgabe;
        private System.Windows.Forms.Button CmdRechnen;
        private System.Windows.Forms.Label LblAusgabe;
        private System.Windows.Forms.TextBox TxtEingabe;
    }
}

