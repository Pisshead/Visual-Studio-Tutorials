namespace UForSchleife
{
    partial class FrmUForSchleife
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
            this.CmdFor = new System.Windows.Forms.Button();
            this.LblFor = new System.Windows.Forms.Label();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdFor
            // 
            this.CmdFor.Location = new System.Drawing.Point(197, 13);
            this.CmdFor.Name = "CmdFor";
            this.CmdFor.Size = new System.Drawing.Size(75, 23);
            this.CmdFor.TabIndex = 0;
            this.CmdFor.Text = "For";
            this.CmdFor.UseVisualStyleBackColor = true;
            this.CmdFor.Click += new System.EventHandler(this.CmdFor_Click);
            // 
            // LblFor
            // 
            this.LblFor.AutoSize = true;
            this.LblFor.Location = new System.Drawing.Point(13, 13);
            this.LblFor.Name = "LblFor";
            this.LblFor.Size = new System.Drawing.Size(112, 13);
            this.LblFor.TabIndex = 1;
            this.LblFor.Text = "Reihe der For-Schleife";
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(196, 226);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 2;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // FrmUForSchleife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.LblFor);
            this.Controls.Add(this.CmdFor);
            this.Name = "FrmUForSchleife";
            this.Text = "Übung For-Schleife";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdFor;
        private System.Windows.Forms.Label LblFor;
        private System.Windows.Forms.Button CmdEnde;
    }
}

