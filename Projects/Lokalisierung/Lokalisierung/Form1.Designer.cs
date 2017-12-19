namespace Lokalisierung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CmdZwei = new System.Windows.Forms.Button();
            this.CmdEins = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdZwei
            // 
            resources.ApplyResources(this.CmdZwei, "CmdZwei");
            this.CmdZwei.Name = "CmdZwei";
            this.CmdZwei.UseVisualStyleBackColor = true;
            this.CmdZwei.Click += new System.EventHandler(this.CmdZwei_Click);
            // 
            // CmdEins
            // 
            resources.ApplyResources(this.CmdEins, "CmdEins");
            this.CmdEins.Name = "CmdEins";
            this.CmdEins.UseVisualStyleBackColor = true;
            this.CmdEins.Click += new System.EventHandler(this.CmdEins_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CmdZwei);
            this.Controls.Add(this.CmdEins);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdZwei;
        private System.Windows.Forms.Button CmdEins;
    }
}

