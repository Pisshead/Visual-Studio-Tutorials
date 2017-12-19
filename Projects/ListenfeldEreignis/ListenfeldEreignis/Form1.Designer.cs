namespace ListenfeldEreignis
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
            this.LstSpeisen = new System.Windows.Forms.ListBox();
            this.CmdEreignis = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstSpeisen
            // 
            this.LstSpeisen.FormattingEnabled = true;
            this.LstSpeisen.Location = new System.Drawing.Point(12, 12);
            this.LstSpeisen.Name = "LstSpeisen";
            this.LstSpeisen.Size = new System.Drawing.Size(120, 95);
            this.LstSpeisen.TabIndex = 0;
            this.LstSpeisen.SelectedIndexChanged += new System.EventHandler(this.LstSpeisen_SelectedIndexChanged);
            // 
            // CmdEreignis
            // 
            this.CmdEreignis.Location = new System.Drawing.Point(197, 11);
            this.CmdEreignis.Name = "CmdEreignis";
            this.CmdEreignis.Size = new System.Drawing.Size(75, 23);
            this.CmdEreignis.TabIndex = 1;
            this.CmdEreignis.Text = "Ereignis";
            this.CmdEreignis.UseVisualStyleBackColor = true;
            this.CmdEreignis.Click += new System.EventHandler(this.CmdEreignis_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(17, 131);
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
            this.Controls.Add(this.CmdEreignis);
            this.Controls.Add(this.LstSpeisen);
            this.Name = "Form1";
            this.Text = "Listenfeld-Ereignis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstSpeisen;
        private System.Windows.Forms.Button CmdEreignis;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

