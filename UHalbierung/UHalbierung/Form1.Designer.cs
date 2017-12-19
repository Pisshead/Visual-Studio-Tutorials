namespace UHalbierung
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdHalbieren = new System.Windows.Forms.Button();
            this.LblHalbieren = new System.Windows.Forms.Label();
            this.TxtHalbieren = new System.Windows.Forms.TextBox();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdHalbieren
            // 
            this.CmdHalbieren.Location = new System.Drawing.Point(172, 70);
            this.CmdHalbieren.Name = "CmdHalbieren";
            this.CmdHalbieren.Size = new System.Drawing.Size(100, 23);
            this.CmdHalbieren.TabIndex = 0;
            this.CmdHalbieren.Text = "Halbieren";
            this.CmdHalbieren.UseVisualStyleBackColor = true;
            this.CmdHalbieren.Click += new System.EventHandler(this.CmdHalbieren_Click);
            // 
            // LblHalbieren
            // 
            this.LblHalbieren.AutoSize = true;
            this.LblHalbieren.Location = new System.Drawing.Point(13, 13);
            this.LblHalbieren.Name = "LblHalbieren";
            this.LblHalbieren.Size = new System.Drawing.Size(55, 13);
            this.LblHalbieren.TabIndex = 1;
            this.LblHalbieren.Text = "Resultat...";
            // 
            // TxtHalbieren
            // 
            this.TxtHalbieren.Location = new System.Drawing.Point(172, 13);
            this.TxtHalbieren.Name = "TxtHalbieren";
            this.TxtHalbieren.Size = new System.Drawing.Size(100, 20);
            this.TxtHalbieren.TabIndex = 2;
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(197, 226);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 3;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.TxtHalbieren);
            this.Controls.Add(this.LblHalbieren);
            this.Controls.Add(this.CmdHalbieren);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdHalbieren;
        private System.Windows.Forms.Label LblHalbieren;
        private System.Windows.Forms.TextBox TxtHalbieren;
        private System.Windows.Forms.Button CmdEnde;
    }
}

