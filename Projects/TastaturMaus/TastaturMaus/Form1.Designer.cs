namespace TastaturMaus
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
            this.LblMaus = new System.Windows.Forms.Label();
            this.PanMaus = new System.Windows.Forms.Panel();
            this.LblEingabe = new System.Windows.Forms.Label();
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblMaus
            // 
            this.LblMaus.AutoSize = true;
            this.LblMaus.Location = new System.Drawing.Point(12, 186);
            this.LblMaus.Name = "LblMaus";
            this.LblMaus.Size = new System.Drawing.Size(30, 13);
            this.LblMaus.TabIndex = 7;
            this.LblMaus.Text = "(leer)";
            // 
            // PanMaus
            // 
            this.PanMaus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanMaus.Location = new System.Drawing.Point(15, 73);
            this.PanMaus.Name = "PanMaus";
            this.PanMaus.Size = new System.Drawing.Size(200, 100);
            this.PanMaus.TabIndex = 6;
            this.PanMaus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanMaus_MouseDown);
            // 
            // LblEingabe
            // 
            this.LblEingabe.AutoSize = true;
            this.LblEingabe.Location = new System.Drawing.Point(12, 44);
            this.LblEingabe.Name = "LblEingabe";
            this.LblEingabe.Size = new System.Drawing.Size(30, 13);
            this.LblEingabe.TabIndex = 5;
            this.LblEingabe.Text = "(leer)";
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(12, 12);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(100, 20);
            this.TxtEingabe.TabIndex = 4;
            this.TxtEingabe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEingabe_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.LblMaus);
            this.Controls.Add(this.PanMaus);
            this.Controls.Add(this.LblEingabe);
            this.Controls.Add(this.TxtEingabe);
            this.Name = "Form1";
            this.Text = "Tastatur und Maus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMaus;
        private System.Windows.Forms.Panel PanMaus;
        private System.Windows.Forms.Label LblEingabe;
        private System.Windows.Forms.TextBox TxtEingabe;
    }
}

