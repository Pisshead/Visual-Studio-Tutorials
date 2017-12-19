namespace UDatenfeldEindimensional
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
            this.CmdMinima = new System.Windows.Forms.Button();
            this.LstZahl = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(115, 50);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 14;
            // 
            // CmdMinima
            // 
            this.CmdMinima.Location = new System.Drawing.Point(118, 12);
            this.CmdMinima.Name = "CmdMinima";
            this.CmdMinima.Size = new System.Drawing.Size(75, 23);
            this.CmdMinima.TabIndex = 13;
            this.CmdMinima.Text = "Minima";
            this.CmdMinima.UseVisualStyleBackColor = true;
            this.CmdMinima.Click += new System.EventHandler(this.CmdMinima_Click);
            // 
            // LstZahl
            // 
            this.LstZahl.FormattingEnabled = true;
            this.LstZahl.Location = new System.Drawing.Point(12, 12);
            this.LstZahl.Name = "LstZahl";
            this.LstZahl.Size = new System.Drawing.Size(75, 147);
            this.LstZahl.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdMinima);
            this.Controls.Add(this.LstZahl);
            this.Name = "Form1";
            this.Text = "Datenfeld, eindimensional";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label LblAnzeige;
        internal System.Windows.Forms.Button CmdMinima;
        internal System.Windows.Forms.ListBox LstZahl;
    }
}

