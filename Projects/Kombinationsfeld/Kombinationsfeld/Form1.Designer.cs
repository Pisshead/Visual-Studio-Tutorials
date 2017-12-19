namespace Kombinationsfeld
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
            this.CmbWerkzeug1 = new System.Windows.Forms.ComboBox();
            this.CmdAnzeige1 = new System.Windows.Forms.Button();
            this.LblAnzeige1 = new System.Windows.Forms.Label();
            this.LblAnzeige2 = new System.Windows.Forms.Label();
            this.CmdAnzeige2 = new System.Windows.Forms.Button();
            this.CmbWerkzeug2 = new System.Windows.Forms.ComboBox();
            this.LblAnzeige3 = new System.Windows.Forms.Label();
            this.CmdAnzeige3 = new System.Windows.Forms.Button();
            this.CmbWerkzeug3 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // CmbWerkzeug1
            // 
            this.CmbWerkzeug1.FormattingEnabled = true;
            this.CmbWerkzeug1.Location = new System.Drawing.Point(12, 12);
            this.CmbWerkzeug1.Name = "CmbWerkzeug1";
            this.CmbWerkzeug1.Size = new System.Drawing.Size(121, 21);
            this.CmbWerkzeug1.TabIndex = 0;
            // 
            // CmdAnzeige1
            // 
            this.CmdAnzeige1.Location = new System.Drawing.Point(173, 12);
            this.CmdAnzeige1.Name = "CmdAnzeige1";
            this.CmdAnzeige1.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeige1.TabIndex = 1;
            this.CmdAnzeige1.Text = "Anzeigen 1";
            this.CmdAnzeige1.UseVisualStyleBackColor = true;
            this.CmdAnzeige1.Click += new System.EventHandler(this.CmdAnzeige1_Click);
            // 
            // LblAnzeige1
            // 
            this.LblAnzeige1.AutoSize = true;
            this.LblAnzeige1.Location = new System.Drawing.Point(284, 17);
            this.LblAnzeige1.Name = "LblAnzeige1";
            this.LblAnzeige1.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige1.TabIndex = 2;
            this.LblAnzeige1.Text = "(leer)";
            // 
            // LblAnzeige2
            // 
            this.LblAnzeige2.AutoSize = true;
            this.LblAnzeige2.Location = new System.Drawing.Point(284, 44);
            this.LblAnzeige2.Name = "LblAnzeige2";
            this.LblAnzeige2.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige2.TabIndex = 5;
            this.LblAnzeige2.Text = "(leer)";
            // 
            // CmdAnzeige2
            // 
            this.CmdAnzeige2.Location = new System.Drawing.Point(173, 39);
            this.CmdAnzeige2.Name = "CmdAnzeige2";
            this.CmdAnzeige2.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeige2.TabIndex = 4;
            this.CmdAnzeige2.Text = "Anzeigen 2";
            this.CmdAnzeige2.UseVisualStyleBackColor = true;
            this.CmdAnzeige2.Click += new System.EventHandler(this.CmdAnzeige2_Click);
            // 
            // CmbWerkzeug2
            // 
            this.CmbWerkzeug2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbWerkzeug2.FormattingEnabled = true;
            this.CmbWerkzeug2.Location = new System.Drawing.Point(12, 39);
            this.CmbWerkzeug2.Name = "CmbWerkzeug2";
            this.CmbWerkzeug2.Size = new System.Drawing.Size(121, 21);
            this.CmbWerkzeug2.TabIndex = 3;
            // 
            // LblAnzeige3
            // 
            this.LblAnzeige3.AutoSize = true;
            this.LblAnzeige3.Location = new System.Drawing.Point(284, 71);
            this.LblAnzeige3.Name = "LblAnzeige3";
            this.LblAnzeige3.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige3.TabIndex = 8;
            this.LblAnzeige3.Text = "(leer)";
            // 
            // CmdAnzeige3
            // 
            this.CmdAnzeige3.Location = new System.Drawing.Point(173, 66);
            this.CmdAnzeige3.Name = "CmdAnzeige3";
            this.CmdAnzeige3.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeige3.TabIndex = 7;
            this.CmdAnzeige3.Text = "Anzeigen 3";
            this.CmdAnzeige3.UseVisualStyleBackColor = true;
            this.CmdAnzeige3.Click += new System.EventHandler(this.CmdAnzeige3_Click);
            // 
            // CmbWerkzeug3
            // 
            this.CmbWerkzeug3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CmbWerkzeug3.FormattingEnabled = true;
            this.CmbWerkzeug3.Location = new System.Drawing.Point(12, 66);
            this.CmbWerkzeug3.Name = "CmbWerkzeug3";
            this.CmbWerkzeug3.Size = new System.Drawing.Size(121, 150);
            this.CmbWerkzeug3.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.LblAnzeige3);
            this.Controls.Add(this.CmdAnzeige3);
            this.Controls.Add(this.CmbWerkzeug3);
            this.Controls.Add(this.LblAnzeige2);
            this.Controls.Add(this.CmdAnzeige2);
            this.Controls.Add(this.CmbWerkzeug2);
            this.Controls.Add(this.LblAnzeige1);
            this.Controls.Add(this.CmdAnzeige1);
            this.Controls.Add(this.CmbWerkzeug1);
            this.Name = "Form1";
            this.Text = "Kombinationsfeld";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CmbWerkzeug1;
        private System.Windows.Forms.Button CmdAnzeige1;
        private System.Windows.Forms.Label LblAnzeige1;
        private System.Windows.Forms.Label LblAnzeige2;
        private System.Windows.Forms.Button CmdAnzeige2;
        private System.Windows.Forms.ComboBox CmbWerkzeug2;
        private System.Windows.Forms.Label LblAnzeige3;
        private System.Windows.Forms.Button CmdAnzeige3;
        private System.Windows.Forms.ComboBox CmbWerkzeug3;
    }
}

