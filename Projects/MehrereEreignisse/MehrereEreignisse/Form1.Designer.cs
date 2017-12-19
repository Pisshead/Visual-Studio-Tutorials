namespace MehrereEreignisse
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
            this.OptFarbeRot = new System.Windows.Forms.RadioButton();
            this.OptFarbeGruen = new System.Windows.Forms.RadioButton();
            this.OptFarbeBlau = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(12, 14);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige.TabIndex = 0;
            this.LblAnzeige.Text = "(leer)";
            // 
            // OptFarbeRot
            // 
            this.OptFarbeRot.AutoSize = true;
            this.OptFarbeRot.Location = new System.Drawing.Point(230, 14);
            this.OptFarbeRot.Name = "OptFarbeRot";
            this.OptFarbeRot.Size = new System.Drawing.Size(42, 17);
            this.OptFarbeRot.TabIndex = 1;
            this.OptFarbeRot.Text = "Rot";
            this.OptFarbeRot.UseVisualStyleBackColor = true;
            this.OptFarbeRot.CheckedChanged += new System.EventHandler(this.OptFarbe_CheckedChanged);
            // 
            // OptFarbeGruen
            // 
            this.OptFarbeGruen.AutoSize = true;
            this.OptFarbeGruen.Checked = true;
            this.OptFarbeGruen.Location = new System.Drawing.Point(230, 37);
            this.OptFarbeGruen.Name = "OptFarbeGruen";
            this.OptFarbeGruen.Size = new System.Drawing.Size(48, 17);
            this.OptFarbeGruen.TabIndex = 2;
            this.OptFarbeGruen.TabStop = true;
            this.OptFarbeGruen.Text = "Grün";
            this.OptFarbeGruen.UseVisualStyleBackColor = true;
            this.OptFarbeGruen.CheckedChanged += new System.EventHandler(this.OptFarbe_CheckedChanged);
            // 
            // OptFarbeBlau
            // 
            this.OptFarbeBlau.AutoSize = true;
            this.OptFarbeBlau.Location = new System.Drawing.Point(230, 60);
            this.OptFarbeBlau.Name = "OptFarbeBlau";
            this.OptFarbeBlau.Size = new System.Drawing.Size(46, 17);
            this.OptFarbeBlau.TabIndex = 3;
            this.OptFarbeBlau.Text = "Blau";
            this.OptFarbeBlau.UseVisualStyleBackColor = true;
            this.OptFarbeBlau.CheckedChanged += new System.EventHandler(this.OptFarbe_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.OptFarbeBlau);
            this.Controls.Add(this.OptFarbeGruen);
            this.Controls.Add(this.OptFarbeRot);
            this.Controls.Add(this.LblAnzeige);
            this.Name = "Form1";
            this.Text = "Mehrere Ereignisse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.RadioButton OptFarbeRot;
        private System.Windows.Forms.RadioButton OptFarbeGruen;
        private System.Windows.Forms.RadioButton OptFarbeBlau;
    }
}

