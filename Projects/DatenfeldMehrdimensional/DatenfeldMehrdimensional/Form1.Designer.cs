namespace DatenfeldMehrdimensional
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
            this.CmdInit = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdAnzeige = new System.Windows.Forms.Button();
            this.LstSpalte2 = new System.Windows.Forms.ListBox();
            this.LstSpalte1 = new System.Windows.Forms.ListBox();
            this.LstSpalte0 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CmdInit
            // 
            this.CmdInit.Location = new System.Drawing.Point(247, 41);
            this.CmdInit.Name = "CmdInit";
            this.CmdInit.Size = new System.Drawing.Size(75, 23);
            this.CmdInit.TabIndex = 29;
            this.CmdInit.Text = "Initialisieren";
            this.CmdInit.UseVisualStyleBackColor = true;
            this.CmdInit.Click += new System.EventHandler(this.CmdInit_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(192, 130);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige.TabIndex = 28;
            this.LblAnzeige.Text = "(leer)";
            // 
            // CmdAnzeige
            // 
            this.CmdAnzeige.Location = new System.Drawing.Point(247, 12);
            this.CmdAnzeige.Name = "CmdAnzeige";
            this.CmdAnzeige.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeige.TabIndex = 27;
            this.CmdAnzeige.Text = "Anzeige";
            this.CmdAnzeige.UseVisualStyleBackColor = true;
            this.CmdAnzeige.Click += new System.EventHandler(this.CmdAnzeige_Click);
            // 
            // LstSpalte2
            // 
            this.LstSpalte2.FormattingEnabled = true;
            this.LstSpalte2.Location = new System.Drawing.Point(126, 12);
            this.LstSpalte2.Name = "LstSpalte2";
            this.LstSpalte2.Size = new System.Drawing.Size(51, 134);
            this.LstSpalte2.TabIndex = 26;
            this.LstSpalte2.Click += new System.EventHandler(this.LstSpalte_Click);
            // 
            // LstSpalte1
            // 
            this.LstSpalte1.FormattingEnabled = true;
            this.LstSpalte1.Location = new System.Drawing.Point(69, 12);
            this.LstSpalte1.Name = "LstSpalte1";
            this.LstSpalte1.Size = new System.Drawing.Size(51, 134);
            this.LstSpalte1.TabIndex = 25;
            this.LstSpalte1.Click += new System.EventHandler(this.LstSpalte_Click);
            // 
            // LstSpalte0
            // 
            this.LstSpalte0.FormattingEnabled = true;
            this.LstSpalte0.Location = new System.Drawing.Point(12, 12);
            this.LstSpalte0.Name = "LstSpalte0";
            this.LstSpalte0.Size = new System.Drawing.Size(51, 134);
            this.LstSpalte0.TabIndex = 24;
            this.LstSpalte0.Click += new System.EventHandler(this.LstSpalte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.CmdInit);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdAnzeige);
            this.Controls.Add(this.LstSpalte2);
            this.Controls.Add(this.LstSpalte1);
            this.Controls.Add(this.LstSpalte0);
            this.Name = "Form1";
            this.Text = "Datenfeld, mehrdimensional";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdInit;
        internal System.Windows.Forms.Label LblAnzeige;
        internal System.Windows.Forms.Button CmdAnzeige;
        internal System.Windows.Forms.ListBox LstSpalte2;
        internal System.Windows.Forms.ListBox LstSpalte1;
        internal System.Windows.Forms.ListBox LstSpalte0;
    }
}

