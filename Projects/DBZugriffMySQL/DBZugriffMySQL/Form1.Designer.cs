namespace DBZugriffMySQL
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
            this.CmdSenken = new System.Windows.Forms.Button();
            this.LstAnzeige = new System.Windows.Forms.ListBox();
            this.CmdErhoehen = new System.Windows.Forms.Button();
            this.CmdAlleSehen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdSenken
            // 
            this.CmdSenken.Location = new System.Drawing.Point(12, 70);
            this.CmdSenken.Name = "CmdSenken";
            this.CmdSenken.Size = new System.Drawing.Size(150, 23);
            this.CmdSenken.TabIndex = 24;
            this.CmdSenken.Text = "Gehälter senken";
            this.CmdSenken.UseVisualStyleBackColor = true;
            this.CmdSenken.Click += new System.EventHandler(this.CmdAendern_Click);
            // 
            // LstAnzeige
            // 
            this.LstAnzeige.FormattingEnabled = true;
            this.LstAnzeige.Location = new System.Drawing.Point(12, 99);
            this.LstAnzeige.Name = "LstAnzeige";
            this.LstAnzeige.Size = new System.Drawing.Size(268, 95);
            this.LstAnzeige.TabIndex = 23;
            // 
            // CmdErhoehen
            // 
            this.CmdErhoehen.Location = new System.Drawing.Point(12, 41);
            this.CmdErhoehen.Name = "CmdErhoehen";
            this.CmdErhoehen.Size = new System.Drawing.Size(150, 23);
            this.CmdErhoehen.TabIndex = 22;
            this.CmdErhoehen.Text = "Gehälter erhöhen";
            this.CmdErhoehen.UseVisualStyleBackColor = true;
            this.CmdErhoehen.Click += new System.EventHandler(this.CmdAendern_Click);
            // 
            // CmdAlleSehen
            // 
            this.CmdAlleSehen.Location = new System.Drawing.Point(12, 12);
            this.CmdAlleSehen.Name = "CmdAlleSehen";
            this.CmdAlleSehen.Size = new System.Drawing.Size(150, 23);
            this.CmdAlleSehen.TabIndex = 21;
            this.CmdAlleSehen.Text = "Alle Datensätze sehen";
            this.CmdAlleSehen.UseVisualStyleBackColor = true;
            this.CmdAlleSehen.Click += new System.EventHandler(this.CmdAlleSehen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.CmdSenken);
            this.Controls.Add(this.LstAnzeige);
            this.Controls.Add(this.CmdErhoehen);
            this.Controls.Add(this.CmdAlleSehen);
            this.Name = "Form1";
            this.Text = "Datenbank, Zugriff MySQL";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button CmdSenken;
        internal System.Windows.Forms.ListBox LstAnzeige;
        internal System.Windows.Forms.Button CmdErhoehen;
        internal System.Windows.Forms.Button CmdAlleSehen;
    }
}

