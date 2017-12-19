namespace Delegates
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
            this.CmdErzeugen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdErzeugen
            // 
            this.CmdErzeugen.Location = new System.Drawing.Point(11, 11);
            this.CmdErzeugen.Margin = new System.Windows.Forms.Padding(2);
            this.CmdErzeugen.Name = "CmdErzeugen";
            this.CmdErzeugen.Size = new System.Drawing.Size(135, 21);
            this.CmdErzeugen.TabIndex = 3;
            this.CmdErzeugen.Text = "Erzeuge neuen Button";
            this.CmdErzeugen.UseVisualStyleBackColor = true;
            this.CmdErzeugen.Click += new System.EventHandler(this.CmdErzeugen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdErzeugen);
            this.Name = "Form1";
            this.Text = "Delegates";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button CmdErzeugen;
    }
}

