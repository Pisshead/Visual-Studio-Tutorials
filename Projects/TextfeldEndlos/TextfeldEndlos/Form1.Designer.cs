namespace TextfeldEndlos
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
            this.TxtEingabe2 = new System.Windows.Forms.TextBox();
            this.TxtEingabe1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(13, 15);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige.TabIndex = 12;
            this.LblAnzeige.Text = "(leer)";
            // 
            // TxtEingabe2
            // 
            this.TxtEingabe2.Location = new System.Drawing.Point(222, 38);
            this.TxtEingabe2.Name = "TxtEingabe2";
            this.TxtEingabe2.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe2.TabIndex = 11;
            this.TxtEingabe2.TextChanged += new System.EventHandler(this.TxtEingabe2_TextChanged);
            // 
            // TxtEingabe1
            // 
            this.TxtEingabe1.Location = new System.Drawing.Point(222, 12);
            this.TxtEingabe1.Name = "TxtEingabe1";
            this.TxtEingabe1.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe1.TabIndex = 10;
            this.TxtEingabe1.TextChanged += new System.EventHandler(this.TxtEingabe1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.TxtEingabe2);
            this.Controls.Add(this.TxtEingabe1);
            this.Name = "Form1";
            this.Text = "Endlose Ereigniskette";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAnzeige;
        internal System.Windows.Forms.TextBox TxtEingabe2;
        internal System.Windows.Forms.TextBox TxtEingabe1;
    }
}

