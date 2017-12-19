namespace Rechenoperatoren
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
            this.CmdAnzeigen1 = new System.Windows.Forms.Button();
            this.CmdAnzeigen2 = new System.Windows.Forms.Button();
            this.CmdAnzeigen3 = new System.Windows.Forms.Button();
            this.CmdAnzeigen4 = new System.Windows.Forms.Button();
            this.CmdAnzeigen5 = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdAnzeigen1
            // 
            this.CmdAnzeigen1.Location = new System.Drawing.Point(197, 12);
            this.CmdAnzeigen1.Name = "CmdAnzeigen1";
            this.CmdAnzeigen1.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen1.TabIndex = 0;
            this.CmdAnzeigen1.Text = "Anzeigen 1";
            this.CmdAnzeigen1.UseVisualStyleBackColor = true;
            this.CmdAnzeigen1.Click += new System.EventHandler(this.CmdAnzeigen1_Click);
            // 
            // CmdAnzeigen2
            // 
            this.CmdAnzeigen2.Location = new System.Drawing.Point(197, 41);
            this.CmdAnzeigen2.Name = "CmdAnzeigen2";
            this.CmdAnzeigen2.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen2.TabIndex = 1;
            this.CmdAnzeigen2.Text = "Anzeigen 2";
            this.CmdAnzeigen2.UseVisualStyleBackColor = true;
            this.CmdAnzeigen2.Click += new System.EventHandler(this.CmdAnzeigen2_Click);
            // 
            // CmdAnzeigen3
            // 
            this.CmdAnzeigen3.Location = new System.Drawing.Point(197, 70);
            this.CmdAnzeigen3.Name = "CmdAnzeigen3";
            this.CmdAnzeigen3.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen3.TabIndex = 2;
            this.CmdAnzeigen3.Text = "Anzeigen 3";
            this.CmdAnzeigen3.UseVisualStyleBackColor = true;
            this.CmdAnzeigen3.Click += new System.EventHandler(this.CmdAnzeigen3_Click);
            // 
            // CmdAnzeigen4
            // 
            this.CmdAnzeigen4.Location = new System.Drawing.Point(197, 99);
            this.CmdAnzeigen4.Name = "CmdAnzeigen4";
            this.CmdAnzeigen4.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen4.TabIndex = 3;
            this.CmdAnzeigen4.Text = "Anzeigen 4";
            this.CmdAnzeigen4.UseVisualStyleBackColor = true;
            this.CmdAnzeigen4.Click += new System.EventHandler(this.CmdAnzeigen4_Click);
            // 
            // CmdAnzeigen5
            // 
            this.CmdAnzeigen5.Location = new System.Drawing.Point(197, 128);
            this.CmdAnzeigen5.Name = "CmdAnzeigen5";
            this.CmdAnzeigen5.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeigen5.TabIndex = 4;
            this.CmdAnzeigen5.Text = "Anzeigen 5";
            this.CmdAnzeigen5.UseVisualStyleBackColor = true;
            this.CmdAnzeigen5.Click += new System.EventHandler(this.CmdAnzeigen5_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(12, 12);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige.TabIndex = 5;
            this.LblAnzeige.Text = "(leer)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdAnzeigen5);
            this.Controls.Add(this.CmdAnzeigen4);
            this.Controls.Add(this.CmdAnzeigen3);
            this.Controls.Add(this.CmdAnzeigen2);
            this.Controls.Add(this.CmdAnzeigen1);
            this.Name = "Form1";
            this.Text = "Rechenoperatoren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdAnzeigen1;
        private System.Windows.Forms.Button CmdAnzeigen2;
        private System.Windows.Forms.Button CmdAnzeigen3;
        private System.Windows.Forms.Button CmdAnzeigen4;
        private System.Windows.Forms.Button CmdAnzeigen5;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

