namespace RekursiverAufruf
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
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdRekursion = new System.Windows.Forms.Button();
            this.CmdSchleife = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(16, 17);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige.TabIndex = 14;
            this.LblAnzeige.Text = "(leer)";
            // 
            // CmdRekursion
            // 
            this.CmdRekursion.Location = new System.Drawing.Point(197, 41);
            this.CmdRekursion.Name = "CmdRekursion";
            this.CmdRekursion.Size = new System.Drawing.Size(75, 23);
            this.CmdRekursion.TabIndex = 13;
            this.CmdRekursion.Text = "Rekursion";
            this.CmdRekursion.UseVisualStyleBackColor = true;
            this.CmdRekursion.Click += new System.EventHandler(this.CmdRekursion_Click);
            // 
            // CmdSchleife
            // 
            this.CmdSchleife.Location = new System.Drawing.Point(197, 12);
            this.CmdSchleife.Name = "CmdSchleife";
            this.CmdSchleife.Size = new System.Drawing.Size(75, 23);
            this.CmdSchleife.TabIndex = 12;
            this.CmdSchleife.Text = "Schleife";
            this.CmdSchleife.UseVisualStyleBackColor = true;
            this.CmdSchleife.Click += new System.EventHandler(this.CmdSchleife_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdRekursion);
            this.Controls.Add(this.CmdSchleife);
            this.Name = "Form1";
            this.Text = "Rekursiver Aufruf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LblAnzeige;
        internal System.Windows.Forms.Button CmdRekursion;
        internal System.Windows.Forms.Button CmdSchleife;
    }
}

