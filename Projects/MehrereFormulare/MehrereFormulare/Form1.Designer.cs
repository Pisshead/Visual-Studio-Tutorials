namespace MehrereFormulare
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
            this.TxtHaupt = new System.Windows.Forms.TextBox();
            this.ChkHaupt = new System.Windows.Forms.CheckBox();
            this.CmdEndeHaupt = new System.Windows.Forms.Button();
            this.CmdStartUnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtHaupt
            // 
            this.TxtHaupt.Location = new System.Drawing.Point(12, 41);
            this.TxtHaupt.Name = "TxtHaupt";
            this.TxtHaupt.Size = new System.Drawing.Size(100, 20);
            this.TxtHaupt.TabIndex = 11;
            // 
            // ChkHaupt
            // 
            this.ChkHaupt.AutoSize = true;
            this.ChkHaupt.Location = new System.Drawing.Point(12, 67);
            this.ChkHaupt.Name = "ChkHaupt";
            this.ChkHaupt.Size = new System.Drawing.Size(144, 17);
            this.ChkHaupt.TabIndex = 10;
            this.ChkHaupt.Text = "CheckBox Hauptformular";
            this.ChkHaupt.UseVisualStyleBackColor = true;
            // 
            // CmdEndeHaupt
            // 
            this.CmdEndeHaupt.Location = new System.Drawing.Point(12, 90);
            this.CmdEndeHaupt.Name = "CmdEndeHaupt";
            this.CmdEndeHaupt.Size = new System.Drawing.Size(150, 23);
            this.CmdEndeHaupt.TabIndex = 9;
            this.CmdEndeHaupt.Text = "Ende Hauptformular";
            this.CmdEndeHaupt.UseVisualStyleBackColor = true;
            this.CmdEndeHaupt.Click += new System.EventHandler(this.CmdEndeHaupt_Click);
            // 
            // CmdStartUnter
            // 
            this.CmdStartUnter.Location = new System.Drawing.Point(12, 12);
            this.CmdStartUnter.Name = "CmdStartUnter";
            this.CmdStartUnter.Size = new System.Drawing.Size(150, 23);
            this.CmdStartUnter.TabIndex = 8;
            this.CmdStartUnter.Text = "Start Unterformular";
            this.CmdStartUnter.UseVisualStyleBackColor = true;
            this.CmdStartUnter.Click += new System.EventHandler(this.CmdStartUnter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.TxtHaupt);
            this.Controls.Add(this.ChkHaupt);
            this.Controls.Add(this.CmdEndeHaupt);
            this.Controls.Add(this.CmdStartUnter);
            this.Name = "Form1";
            this.Text = "Hauptformular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtHaupt;
        private System.Windows.Forms.CheckBox ChkHaupt;
        private System.Windows.Forms.Button CmdEndeHaupt;
        private System.Windows.Forms.Button CmdStartUnter;
    }
}

