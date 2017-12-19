namespace UVergleichsoperatoren
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
            this.CmdVergleich1 = new System.Windows.Forms.Button();
            this.CmdVergleich2 = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdVergleich1
            // 
            this.CmdVergleich1.Location = new System.Drawing.Point(197, 12);
            this.CmdVergleich1.Name = "CmdVergleich1";
            this.CmdVergleich1.Size = new System.Drawing.Size(75, 23);
            this.CmdVergleich1.TabIndex = 0;
            this.CmdVergleich1.Text = "Vergleich 1";
            this.CmdVergleich1.UseVisualStyleBackColor = true;
            this.CmdVergleich1.Click += new System.EventHandler(this.CmdVergleich1_Click);
            // 
            // CmdVergleich2
            // 
            this.CmdVergleich2.Location = new System.Drawing.Point(197, 41);
            this.CmdVergleich2.Name = "CmdVergleich2";
            this.CmdVergleich2.Size = new System.Drawing.Size(75, 23);
            this.CmdVergleich2.TabIndex = 1;
            this.CmdVergleich2.Text = "Vergleich 2";
            this.CmdVergleich2.UseVisualStyleBackColor = true;
            this.CmdVergleich2.Click += new System.EventHandler(this.CmdVergleich2_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(12, 17);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige.TabIndex = 2;
            this.LblAnzeige.Text = "(leer)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdVergleich2);
            this.Controls.Add(this.CmdVergleich1);
            this.Name = "Form1";
            this.Text = "Vergleichsoperatoren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdVergleich1;
        private System.Windows.Forms.Button CmdVergleich2;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

