namespace UMethoden
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
            this.LblAnzeige2 = new System.Windows.Forms.Label();
            this.LblAnzeige1 = new System.Windows.Forms.Label();
            this.CmdFelder = new System.Windows.Forms.Button();
            this.CmdMittelwert2 = new System.Windows.Forms.Button();
            this.CmdMittelwert1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAnzeige2
            // 
            this.LblAnzeige2.AutoSize = true;
            this.LblAnzeige2.Location = new System.Drawing.Point(16, 46);
            this.LblAnzeige2.Name = "LblAnzeige2";
            this.LblAnzeige2.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige2.TabIndex = 20;
            // 
            // LblAnzeige1
            // 
            this.LblAnzeige1.AutoSize = true;
            this.LblAnzeige1.Location = new System.Drawing.Point(16, 17);
            this.LblAnzeige1.Name = "LblAnzeige1";
            this.LblAnzeige1.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige1.TabIndex = 19;
            // 
            // CmdFelder
            // 
            this.CmdFelder.Location = new System.Drawing.Point(247, 84);
            this.CmdFelder.Name = "CmdFelder";
            this.CmdFelder.Size = new System.Drawing.Size(75, 23);
            this.CmdFelder.TabIndex = 18;
            this.CmdFelder.Text = "Felder";
            this.CmdFelder.UseVisualStyleBackColor = true;
            this.CmdFelder.Click += new System.EventHandler(this.CmdFelder_Click);
            // 
            // CmdMittelwert2
            // 
            this.CmdMittelwert2.Location = new System.Drawing.Point(247, 41);
            this.CmdMittelwert2.Name = "CmdMittelwert2";
            this.CmdMittelwert2.Size = new System.Drawing.Size(75, 23);
            this.CmdMittelwert2.TabIndex = 17;
            this.CmdMittelwert2.Text = "Mittelwert 2";
            this.CmdMittelwert2.UseVisualStyleBackColor = true;
            this.CmdMittelwert2.Click += new System.EventHandler(this.CmdMittelwert2_Click);
            // 
            // CmdMittelwert1
            // 
            this.CmdMittelwert1.Location = new System.Drawing.Point(247, 12);
            this.CmdMittelwert1.Name = "CmdMittelwert1";
            this.CmdMittelwert1.Size = new System.Drawing.Size(75, 23);
            this.CmdMittelwert1.TabIndex = 16;
            this.CmdMittelwert1.Text = "Mittelwert 1";
            this.CmdMittelwert1.UseVisualStyleBackColor = true;
            this.CmdMittelwert1.Click += new System.EventHandler(this.CmdMittelwert1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.LblAnzeige2);
            this.Controls.Add(this.LblAnzeige1);
            this.Controls.Add(this.CmdFelder);
            this.Controls.Add(this.CmdMittelwert2);
            this.Controls.Add(this.CmdMittelwert1);
            this.Name = "Form1";
            this.Text = "Methoden";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAnzeige2;
        private System.Windows.Forms.Label LblAnzeige1;
        private System.Windows.Forms.Button CmdFelder;
        private System.Windows.Forms.Button CmdMittelwert2;
        private System.Windows.Forms.Button CmdMittelwert1;
    }
}

