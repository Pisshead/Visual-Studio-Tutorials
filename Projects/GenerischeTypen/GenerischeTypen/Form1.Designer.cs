namespace GenerischeTypen
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
            this.CmdDictionary = new System.Windows.Forms.Button();
            this.CmdListLand = new System.Windows.Forms.Button();
            this.LstAusgabe = new System.Windows.Forms.ListBox();
            this.CmdListString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdDictionary
            // 
            this.CmdDictionary.Location = new System.Drawing.Point(290, 11);
            this.CmdDictionary.Margin = new System.Windows.Forms.Padding(2);
            this.CmdDictionary.Name = "CmdDictionary";
            this.CmdDictionary.Size = new System.Drawing.Size(135, 21);
            this.CmdDictionary.TabIndex = 12;
            this.CmdDictionary.Text = "Dictionary String Land";
            this.CmdDictionary.UseVisualStyleBackColor = true;
            this.CmdDictionary.Click += new System.EventHandler(this.CmdDictionary_Click);
            // 
            // CmdListLand
            // 
            this.CmdListLand.Location = new System.Drawing.Point(155, 11);
            this.CmdListLand.Margin = new System.Windows.Forms.Padding(2);
            this.CmdListLand.Name = "CmdListLand";
            this.CmdListLand.Size = new System.Drawing.Size(75, 21);
            this.CmdListLand.TabIndex = 11;
            this.CmdListLand.Text = "List Land";
            this.CmdListLand.UseVisualStyleBackColor = true;
            this.CmdListLand.Click += new System.EventHandler(this.CmdListLand_Click);
            // 
            // LstAusgabe
            // 
            this.LstAusgabe.FormattingEnabled = true;
            this.LstAusgabe.Location = new System.Drawing.Point(11, 40);
            this.LstAusgabe.Margin = new System.Windows.Forms.Padding(2);
            this.LstAusgabe.Name = "LstAusgabe";
            this.LstAusgabe.Size = new System.Drawing.Size(414, 160);
            this.LstAusgabe.TabIndex = 10;
            // 
            // CmdListString
            // 
            this.CmdListString.Location = new System.Drawing.Point(11, 11);
            this.CmdListString.Margin = new System.Windows.Forms.Padding(2);
            this.CmdListString.Name = "CmdListString";
            this.CmdListString.Size = new System.Drawing.Size(75, 21);
            this.CmdListString.TabIndex = 9;
            this.CmdListString.Text = "List String";
            this.CmdListString.UseVisualStyleBackColor = true;
            this.CmdListString.Click += new System.EventHandler(this.CmdListString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.CmdDictionary);
            this.Controls.Add(this.CmdListLand);
            this.Controls.Add(this.LstAusgabe);
            this.Controls.Add(this.CmdListString);
            this.Name = "Form1";
            this.Text = "Generische Typen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdDictionary;
        private System.Windows.Forms.Button CmdListLand;
        private System.Windows.Forms.ListBox LstAusgabe;
        private System.Windows.Forms.Button CmdListString;
    }
}

