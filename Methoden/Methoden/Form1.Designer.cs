namespace Methoden
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
            this.CmdMaximum = new System.Windows.Forms.Button();
            this.LblMaximum = new System.Windows.Forms.Label();
            this.CmdMaximum2 = new System.Windows.Forms.Button();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdMaximum
            // 
            this.CmdMaximum.Location = new System.Drawing.Point(197, 13);
            this.CmdMaximum.Name = "CmdMaximum";
            this.CmdMaximum.Size = new System.Drawing.Size(75, 51);
            this.CmdMaximum.TabIndex = 0;
            this.CmdMaximum.Text = "Maximum von a und b anzeigen";
            this.CmdMaximum.UseVisualStyleBackColor = true;
            this.CmdMaximum.Click += new System.EventHandler(this.CmdMaximum_Click);
            // 
            // LblMaximum
            // 
            this.LblMaximum.AutoSize = true;
            this.LblMaximum.Location = new System.Drawing.Point(13, 13);
            this.LblMaximum.Name = "LblMaximum";
            this.LblMaximum.Size = new System.Drawing.Size(0, 13);
            this.LblMaximum.TabIndex = 1;
            // 
            // CmdMaximum2
            // 
            this.CmdMaximum2.Location = new System.Drawing.Point(197, 70);
            this.CmdMaximum2.Name = "CmdMaximum2";
            this.CmdMaximum2.Size = new System.Drawing.Size(75, 51);
            this.CmdMaximum2.TabIndex = 2;
            this.CmdMaximum2.Text = "Maximum von c und d anzeigen";
            this.CmdMaximum2.UseVisualStyleBackColor = true;
            this.CmdMaximum2.Click += new System.EventHandler(this.CmdMaximum2_Click);
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
            this.Controls.Add(this.CmdMaximum2);
            this.Controls.Add(this.LblMaximum);
            this.Controls.Add(this.CmdMaximum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdMaximum;
        private System.Windows.Forms.Label LblMaximum;
        private System.Windows.Forms.Button CmdMaximum2;
        private System.Windows.Forms.Button CmdEnde;
    }
}

