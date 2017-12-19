namespace Laufzeitfehler
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
            this.TxtEingabe1 = new System.Windows.Forms.TextBox();
            this.TxtEingabe2 = new System.Windows.Forms.TextBox();
            this.LblAusgabe = new System.Windows.Forms.Label();
            this.CmdRechnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtEingabe1
            // 
            this.TxtEingabe1.Location = new System.Drawing.Point(12, 14);
            this.TxtEingabe1.Name = "TxtEingabe1";
            this.TxtEingabe1.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe1.TabIndex = 0;
            // 
            // TxtEingabe2
            // 
            this.TxtEingabe2.Location = new System.Drawing.Point(12, 40);
            this.TxtEingabe2.Name = "TxtEingabe2";
            this.TxtEingabe2.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe2.TabIndex = 1;
            // 
            // LblAusgabe
            // 
            this.LblAusgabe.AutoSize = true;
            this.LblAusgabe.Location = new System.Drawing.Point(12, 72);
            this.LblAusgabe.Name = "LblAusgabe";
            this.LblAusgabe.Size = new System.Drawing.Size(30, 13);
            this.LblAusgabe.TabIndex = 2;
            this.LblAusgabe.Text = "(leer)";
            // 
            // CmdRechnen
            // 
            this.CmdRechnen.Location = new System.Drawing.Point(197, 12);
            this.CmdRechnen.Name = "CmdRechnen";
            this.CmdRechnen.Size = new System.Drawing.Size(75, 23);
            this.CmdRechnen.TabIndex = 3;
            this.CmdRechnen.Text = "Rechnen";
            this.CmdRechnen.UseVisualStyleBackColor = true;
            this.CmdRechnen.Click += new System.EventHandler(this.CmdRechnen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdRechnen);
            this.Controls.Add(this.LblAusgabe);
            this.Controls.Add(this.TxtEingabe2);
            this.Controls.Add(this.TxtEingabe1);
            this.Name = "Form1";
            this.Text = "Laufzeitfehler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEingabe1;
        private System.Windows.Forms.TextBox TxtEingabe2;
        private System.Windows.Forms.Label LblAusgabe;
        private System.Windows.Forms.Button CmdRechnen;
    }
}

