namespace WhileDoWhileSchleifen
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
            this.CmdWhile = new System.Windows.Forms.Button();
            this.CmdDoWhile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(12, 17);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige.TabIndex = 0;
            this.LblAnzeige.Text = "(leer)";
            // 
            // CmdWhile
            // 
            this.CmdWhile.Location = new System.Drawing.Point(197, 12);
            this.CmdWhile.Name = "CmdWhile";
            this.CmdWhile.Size = new System.Drawing.Size(75, 23);
            this.CmdWhile.TabIndex = 1;
            this.CmdWhile.Text = "while";
            this.CmdWhile.UseVisualStyleBackColor = true;
            this.CmdWhile.Click += new System.EventHandler(this.CmdWhile_Click);
            // 
            // CmdDoWhile
            // 
            this.CmdDoWhile.Location = new System.Drawing.Point(197, 41);
            this.CmdDoWhile.Name = "CmdDoWhile";
            this.CmdDoWhile.Size = new System.Drawing.Size(75, 23);
            this.CmdDoWhile.TabIndex = 2;
            this.CmdDoWhile.Text = "do-while";
            this.CmdDoWhile.UseVisualStyleBackColor = true;
            this.CmdDoWhile.Click += new System.EventHandler(this.CmdDoWhile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdDoWhile);
            this.Controls.Add(this.CmdWhile);
            this.Controls.Add(this.LblAnzeige);
            this.Name = "Form1";
            this.Text = "while / do-while";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdWhile;
        private System.Windows.Forms.Button CmdDoWhile;
    }
}

