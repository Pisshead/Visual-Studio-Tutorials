namespace Ereigniskette
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
            this.LblAnzeige1 = new System.Windows.Forms.Label();
            this.LblAnzeige2 = new System.Windows.Forms.Label();
            this.CmdEreignis1 = new System.Windows.Forms.Button();
            this.CmdEreignis2 = new System.Windows.Forms.Button();
            this.CmdEreignis3 = new System.Windows.Forms.Button();
            this.CmdLoeschen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAnzeige1
            // 
            this.LblAnzeige1.AutoSize = true;
            this.LblAnzeige1.Location = new System.Drawing.Point(12, 17);
            this.LblAnzeige1.Name = "LblAnzeige1";
            this.LblAnzeige1.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige1.TabIndex = 0;
            this.LblAnzeige1.Text = "(leer)";
            // 
            // LblAnzeige2
            // 
            this.LblAnzeige2.AutoSize = true;
            this.LblAnzeige2.Location = new System.Drawing.Point(12, 46);
            this.LblAnzeige2.Name = "LblAnzeige2";
            this.LblAnzeige2.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige2.TabIndex = 1;
            this.LblAnzeige2.Text = "(leer)";
            // 
            // CmdEreignis1
            // 
            this.CmdEreignis1.Location = new System.Drawing.Point(197, 12);
            this.CmdEreignis1.Name = "CmdEreignis1";
            this.CmdEreignis1.Size = new System.Drawing.Size(75, 23);
            this.CmdEreignis1.TabIndex = 2;
            this.CmdEreignis1.Text = "Ereignis 1";
            this.CmdEreignis1.UseVisualStyleBackColor = true;
            this.CmdEreignis1.Click += new System.EventHandler(this.CmdEreignis1_Click);
            // 
            // CmdEreignis2
            // 
            this.CmdEreignis2.Location = new System.Drawing.Point(197, 41);
            this.CmdEreignis2.Name = "CmdEreignis2";
            this.CmdEreignis2.Size = new System.Drawing.Size(75, 23);
            this.CmdEreignis2.TabIndex = 3;
            this.CmdEreignis2.Text = "Ereignis 2";
            this.CmdEreignis2.UseVisualStyleBackColor = true;
            this.CmdEreignis2.Click += new System.EventHandler(this.CmdEreignis2_Click);
            // 
            // CmdEreignis3
            // 
            this.CmdEreignis3.Location = new System.Drawing.Point(197, 70);
            this.CmdEreignis3.Name = "CmdEreignis3";
            this.CmdEreignis3.Size = new System.Drawing.Size(75, 23);
            this.CmdEreignis3.TabIndex = 4;
            this.CmdEreignis3.Text = "Ereignis 1+2";
            this.CmdEreignis3.UseVisualStyleBackColor = true;
            this.CmdEreignis3.Click += new System.EventHandler(this.CmdEreignis3_Click);
            // 
            // CmdLoeschen
            // 
            this.CmdLoeschen.Location = new System.Drawing.Point(197, 99);
            this.CmdLoeschen.Name = "CmdLoeschen";
            this.CmdLoeschen.Size = new System.Drawing.Size(75, 23);
            this.CmdLoeschen.TabIndex = 5;
            this.CmdLoeschen.Text = "Löschen";
            this.CmdLoeschen.UseVisualStyleBackColor = true;
            this.CmdLoeschen.Click += new System.EventHandler(this.CmdLoeschen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdLoeschen);
            this.Controls.Add(this.CmdEreignis3);
            this.Controls.Add(this.CmdEreignis2);
            this.Controls.Add(this.CmdEreignis1);
            this.Controls.Add(this.LblAnzeige2);
            this.Controls.Add(this.LblAnzeige1);
            this.Name = "Form1";
            this.Text = "Ereigniskette";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAnzeige1;
        private System.Windows.Forms.Label LblAnzeige2;
        private System.Windows.Forms.Button CmdEreignis1;
        private System.Windows.Forms.Button CmdEreignis2;
        private System.Windows.Forms.Button CmdEreignis3;
        private System.Windows.Forms.Button CmdLoeschen;
    }
}

