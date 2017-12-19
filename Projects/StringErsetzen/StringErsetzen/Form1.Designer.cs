namespace StringErsetzen
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
            this.TxtErsetzen = new System.Windows.Forms.TextBox();
            this.TxtSuchen = new System.Windows.Forms.TextBox();
            this.LblErsetzen = new System.Windows.Forms.Label();
            this.LblSuchen = new System.Windows.Forms.Label();
            this.LblEingabe = new System.Windows.Forms.Label();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdErsetzen = new System.Windows.Forms.Button();
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtErsetzen
            // 
            this.TxtErsetzen.Location = new System.Drawing.Point(21, 182);
            this.TxtErsetzen.Name = "TxtErsetzen";
            this.TxtErsetzen.Size = new System.Drawing.Size(50, 20);
            this.TxtErsetzen.TabIndex = 86;
            // 
            // TxtSuchen
            // 
            this.TxtSuchen.Location = new System.Drawing.Point(21, 143);
            this.TxtSuchen.Name = "TxtSuchen";
            this.TxtSuchen.Size = new System.Drawing.Size(50, 20);
            this.TxtSuchen.TabIndex = 85;
            // 
            // LblErsetzen
            // 
            this.LblErsetzen.AutoSize = true;
            this.LblErsetzen.Location = new System.Drawing.Point(21, 166);
            this.LblErsetzen.Name = "LblErsetzen";
            this.LblErsetzen.Size = new System.Drawing.Size(37, 13);
            this.LblErsetzen.TabIndex = 84;
            this.LblErsetzen.Text = "durch:";
            // 
            // LblSuchen
            // 
            this.LblSuchen.AutoSize = true;
            this.LblSuchen.Location = new System.Drawing.Point(21, 127);
            this.LblSuchen.Name = "LblSuchen";
            this.LblSuchen.Size = new System.Drawing.Size(45, 13);
            this.LblSuchen.TabIndex = 83;
            this.LblSuchen.Text = "Ersetze:";
            // 
            // LblEingabe
            // 
            this.LblEingabe.AutoSize = true;
            this.LblEingabe.Location = new System.Drawing.Point(21, 20);
            this.LblEingabe.Name = "LblEingabe";
            this.LblEingabe.Size = new System.Drawing.Size(49, 13);
            this.LblEingabe.TabIndex = 82;
            this.LblEingabe.Text = "Eingabe:";
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(21, 72);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige.TabIndex = 81;
            this.LblAnzeige.Text = "(leer)";
            // 
            // CmdErsetzen
            // 
            this.CmdErsetzen.Location = new System.Drawing.Point(21, 208);
            this.CmdErsetzen.Name = "CmdErsetzen";
            this.CmdErsetzen.Size = new System.Drawing.Size(75, 23);
            this.CmdErsetzen.TabIndex = 80;
            this.CmdErsetzen.Text = "Ersetzen";
            this.CmdErsetzen.UseVisualStyleBackColor = true;
            this.CmdErsetzen.Click += new System.EventHandler(this.CmdErsetzen_Click);
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(21, 36);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(150, 20);
            this.TxtEingabe.TabIndex = 79;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TxtErsetzen);
            this.Controls.Add(this.TxtSuchen);
            this.Controls.Add(this.LblErsetzen);
            this.Controls.Add(this.LblSuchen);
            this.Controls.Add(this.LblEingabe);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdErsetzen);
            this.Controls.Add(this.TxtEingabe);
            this.Name = "Form1";
            this.Text = "Strings, Ersetzen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TxtErsetzen;
        internal System.Windows.Forms.TextBox TxtSuchen;
        internal System.Windows.Forms.Label LblErsetzen;
        internal System.Windows.Forms.Label LblSuchen;
        internal System.Windows.Forms.Label LblEingabe;
        internal System.Windows.Forms.Label LblAnzeige;
        internal System.Windows.Forms.Button CmdErsetzen;
        internal System.Windows.Forms.TextBox TxtEingabe;
    }
}

