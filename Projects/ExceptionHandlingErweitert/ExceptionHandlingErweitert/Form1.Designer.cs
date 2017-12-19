namespace ExceptionHandlingErweitert
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
            this.CmdRechnen = new System.Windows.Forms.Button();
            this.LblAusgabe = new System.Windows.Forms.Label();
            this.TxtEingabe1 = new System.Windows.Forms.TextBox();
            this.TxtEingabe2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdRechnen
            // 
            this.CmdRechnen.Location = new System.Drawing.Point(247, 12);
            this.CmdRechnen.Name = "CmdRechnen";
            this.CmdRechnen.Size = new System.Drawing.Size(75, 23);
            this.CmdRechnen.TabIndex = 0;
            this.CmdRechnen.Text = "Rechnen";
            this.CmdRechnen.UseVisualStyleBackColor = true;
            this.CmdRechnen.Click += new System.EventHandler(this.CmdRechnen_Click);
            // 
            // LblAusgabe
            // 
            this.LblAusgabe.AutoSize = true;
            this.LblAusgabe.Location = new System.Drawing.Point(12, 74);
            this.LblAusgabe.Name = "LblAusgabe";
            this.LblAusgabe.Size = new System.Drawing.Size(30, 13);
            this.LblAusgabe.TabIndex = 1;
            this.LblAusgabe.Text = "(leer)";
            // 
            // TxtEingabe1
            // 
            this.TxtEingabe1.Location = new System.Drawing.Point(12, 15);
            this.TxtEingabe1.Name = "TxtEingabe1";
            this.TxtEingabe1.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe1.TabIndex = 2;
            // 
            // TxtEingabe2
            // 
            this.TxtEingabe2.Location = new System.Drawing.Point(12, 41);
            this.TxtEingabe2.Name = "TxtEingabe2";
            this.TxtEingabe2.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.TxtEingabe2);
            this.Controls.Add(this.TxtEingabe1);
            this.Controls.Add(this.LblAusgabe);
            this.Controls.Add(this.CmdRechnen);
            this.Name = "Form1";
            this.Text = "Exception-Handling, erweitert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdRechnen;
        private System.Windows.Forms.Label LblAusgabe;
        private System.Windows.Forms.TextBox TxtEingabe1;
        private System.Windows.Forms.TextBox TxtEingabe2;
    }
}

