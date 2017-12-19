namespace LogischeOperatoren
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
            this.CmdNicht = new System.Windows.Forms.Button();
            this.CmdUnd = new System.Windows.Forms.Button();
            this.CmdOder = new System.Windows.Forms.Button();
            this.CmdExklusivOder = new System.Windows.Forms.Button();
            this.CmdUndMitAbbruch = new System.Windows.Forms.Button();
            this.CmdBitweiseUnd = new System.Windows.Forms.Button();
            this.CmdOderMitAbbruch = new System.Windows.Forms.Button();
            this.CmdBitweiseOder = new System.Windows.Forms.Button();
            this.LblWert = new System.Windows.Forms.Label();
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
            // CmdNicht
            // 
            this.CmdNicht.Location = new System.Drawing.Point(152, 12);
            this.CmdNicht.Name = "CmdNicht";
            this.CmdNicht.Size = new System.Drawing.Size(120, 23);
            this.CmdNicht.TabIndex = 1;
            this.CmdNicht.Text = "Nicht";
            this.CmdNicht.UseVisualStyleBackColor = true;
            this.CmdNicht.Click += new System.EventHandler(this.CmdNicht_Click);
            // 
            // CmdUnd
            // 
            this.CmdUnd.Location = new System.Drawing.Point(152, 41);
            this.CmdUnd.Name = "CmdUnd";
            this.CmdUnd.Size = new System.Drawing.Size(120, 23);
            this.CmdUnd.TabIndex = 2;
            this.CmdUnd.Text = "Und";
            this.CmdUnd.UseVisualStyleBackColor = true;
            this.CmdUnd.Click += new System.EventHandler(this.CmdUnd_Click);
            // 
            // CmdOder
            // 
            this.CmdOder.Location = new System.Drawing.Point(152, 70);
            this.CmdOder.Name = "CmdOder";
            this.CmdOder.Size = new System.Drawing.Size(120, 23);
            this.CmdOder.TabIndex = 3;
            this.CmdOder.Text = "Oder";
            this.CmdOder.UseVisualStyleBackColor = true;
            this.CmdOder.Click += new System.EventHandler(this.CmdOder_Click);
            // 
            // CmdExklusivOder
            // 
            this.CmdExklusivOder.Location = new System.Drawing.Point(152, 99);
            this.CmdExklusivOder.Name = "CmdExklusivOder";
            this.CmdExklusivOder.Size = new System.Drawing.Size(120, 23);
            this.CmdExklusivOder.TabIndex = 4;
            this.CmdExklusivOder.Text = "Exklusiv Oder";
            this.CmdExklusivOder.UseVisualStyleBackColor = true;
            this.CmdExklusivOder.Click += new System.EventHandler(this.CmdExklusivOder_Click);
            // 
            // CmdUndMitAbbruch
            // 
            this.CmdUndMitAbbruch.Location = new System.Drawing.Point(152, 128);
            this.CmdUndMitAbbruch.Name = "CmdUndMitAbbruch";
            this.CmdUndMitAbbruch.Size = new System.Drawing.Size(120, 23);
            this.CmdUndMitAbbruch.TabIndex = 5;
            this.CmdUndMitAbbruch.Text = "Und mit Abbruch";
            this.CmdUndMitAbbruch.UseVisualStyleBackColor = true;
            this.CmdUndMitAbbruch.Click += new System.EventHandler(this.CmdUndMitAbbruch_Click);
            // 
            // CmdBitweiseUnd
            // 
            this.CmdBitweiseUnd.Location = new System.Drawing.Point(152, 157);
            this.CmdBitweiseUnd.Name = "CmdBitweiseUnd";
            this.CmdBitweiseUnd.Size = new System.Drawing.Size(120, 23);
            this.CmdBitweiseUnd.TabIndex = 6;
            this.CmdBitweiseUnd.Text = "Bitweise Und";
            this.CmdBitweiseUnd.UseVisualStyleBackColor = true;
            this.CmdBitweiseUnd.Click += new System.EventHandler(this.CmdBitweiseUnd_Click);
            // 
            // CmdOderMitAbbruch
            // 
            this.CmdOderMitAbbruch.Location = new System.Drawing.Point(152, 186);
            this.CmdOderMitAbbruch.Name = "CmdOderMitAbbruch";
            this.CmdOderMitAbbruch.Size = new System.Drawing.Size(120, 23);
            this.CmdOderMitAbbruch.TabIndex = 7;
            this.CmdOderMitAbbruch.Text = "Oder mit Abbruch";
            this.CmdOderMitAbbruch.UseVisualStyleBackColor = true;
            this.CmdOderMitAbbruch.Click += new System.EventHandler(this.CmdOderMitAbbruch_Click);
            // 
            // CmdBitweiseOder
            // 
            this.CmdBitweiseOder.Location = new System.Drawing.Point(152, 215);
            this.CmdBitweiseOder.Name = "CmdBitweiseOder";
            this.CmdBitweiseOder.Size = new System.Drawing.Size(120, 23);
            this.CmdBitweiseOder.TabIndex = 8;
            this.CmdBitweiseOder.Text = "Bitweise Oder";
            this.CmdBitweiseOder.UseVisualStyleBackColor = true;
            this.CmdBitweiseOder.Click += new System.EventHandler(this.CmdBitweiseOder_Click);
            // 
            // LblWert
            // 
            this.LblWert.AutoSize = true;
            this.LblWert.Location = new System.Drawing.Point(12, 46);
            this.LblWert.Name = "LblWert";
            this.LblWert.Size = new System.Drawing.Size(30, 13);
            this.LblWert.TabIndex = 9;
            this.LblWert.Text = "(leer)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LblWert);
            this.Controls.Add(this.CmdBitweiseOder);
            this.Controls.Add(this.CmdOderMitAbbruch);
            this.Controls.Add(this.CmdBitweiseUnd);
            this.Controls.Add(this.CmdUndMitAbbruch);
            this.Controls.Add(this.CmdExklusivOder);
            this.Controls.Add(this.CmdOder);
            this.Controls.Add(this.CmdUnd);
            this.Controls.Add(this.CmdNicht);
            this.Controls.Add(this.LblAnzeige);
            this.Name = "Form1";
            this.Text = "Logische Operatoren";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdNicht;
        private System.Windows.Forms.Button CmdUnd;
        private System.Windows.Forms.Button CmdOder;
        private System.Windows.Forms.Button CmdExklusivOder;
        private System.Windows.Forms.Button CmdUndMitAbbruch;
        private System.Windows.Forms.Button CmdBitweiseUnd;
        private System.Windows.Forms.Button CmdOderMitAbbruch;
        private System.Windows.Forms.Button CmdBitweiseOder;
        private System.Windows.Forms.Label LblWert;
    }
}

