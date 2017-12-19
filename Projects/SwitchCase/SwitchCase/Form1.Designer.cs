namespace SwitchCase
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
            this.CmdAnzeige1 = new System.Windows.Forms.Button();
            this.CmdAnzeige2 = new System.Windows.Forms.Button();
            this.NumX = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumX)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(12, 46);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige.TabIndex = 0;
            this.LblAnzeige.Text = "(leer)";
            // 
            // CmdAnzeige1
            // 
            this.CmdAnzeige1.Location = new System.Drawing.Point(197, 12);
            this.CmdAnzeige1.Name = "CmdAnzeige1";
            this.CmdAnzeige1.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeige1.TabIndex = 1;
            this.CmdAnzeige1.Text = "Anzeigen 1";
            this.CmdAnzeige1.UseVisualStyleBackColor = true;
            this.CmdAnzeige1.Click += new System.EventHandler(this.CmdAnzeige1_Click);
            // 
            // CmdAnzeige2
            // 
            this.CmdAnzeige2.Location = new System.Drawing.Point(197, 41);
            this.CmdAnzeige2.Name = "CmdAnzeige2";
            this.CmdAnzeige2.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeige2.TabIndex = 2;
            this.CmdAnzeige2.Text = "Anzeigen 2";
            this.CmdAnzeige2.UseVisualStyleBackColor = true;
            this.CmdAnzeige2.Click += new System.EventHandler(this.CmdAnzeige2_Click);
            // 
            // NumX
            // 
            this.NumX.Location = new System.Drawing.Point(15, 15);
            this.NumX.Name = "NumX";
            this.NumX.Size = new System.Drawing.Size(100, 20);
            this.NumX.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.NumX);
            this.Controls.Add(this.CmdAnzeige2);
            this.Controls.Add(this.CmdAnzeige1);
            this.Controls.Add(this.LblAnzeige);
            this.Name = "Form1";
            this.Text = "switch case";
            ((System.ComponentModel.ISupportInitialize)(this.NumX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdAnzeige1;
        private System.Windows.Forms.Button CmdAnzeige2;
        private System.Windows.Forms.NumericUpDown NumX;
    }
}

