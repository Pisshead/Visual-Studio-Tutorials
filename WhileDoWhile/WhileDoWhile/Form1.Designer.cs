namespace WhileDoWhile
{
    partial class FrmWhileDoWhile
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
            this.CmdWhile = new System.Windows.Forms.Button();
            this.CmdDoWhile = new System.Windows.Forms.Button();
            this.LblWhileDoWhile = new System.Windows.Forms.Label();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdWhile
            // 
            this.CmdWhile.Location = new System.Drawing.Point(197, 78);
            this.CmdWhile.Name = "CmdWhile";
            this.CmdWhile.Size = new System.Drawing.Size(75, 23);
            this.CmdWhile.TabIndex = 0;
            this.CmdWhile.Text = "While";
            this.CmdWhile.UseVisualStyleBackColor = true;
            this.CmdWhile.Click += new System.EventHandler(this.CmdWhile_Click);
            // 
            // CmdDoWhile
            // 
            this.CmdDoWhile.Location = new System.Drawing.Point(197, 144);
            this.CmdDoWhile.Name = "CmdDoWhile";
            this.CmdDoWhile.Size = new System.Drawing.Size(75, 23);
            this.CmdDoWhile.TabIndex = 1;
            this.CmdDoWhile.Text = "Do... While";
            this.CmdDoWhile.UseVisualStyleBackColor = true;
            this.CmdDoWhile.Click += new System.EventHandler(this.CmdDoWhile_Click);
            // 
            // LblWhileDoWhile
            // 
            this.LblWhileDoWhile.AutoSize = true;
            this.LblWhileDoWhile.Location = new System.Drawing.Point(13, 13);
            this.LblWhileDoWhile.Name = "LblWhileDoWhile";
            this.LblWhileDoWhile.Size = new System.Drawing.Size(0, 13);
            this.LblWhileDoWhile.TabIndex = 2;
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
            // FrmWhileDoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.LblWhileDoWhile);
            this.Controls.Add(this.CmdDoWhile);
            this.Controls.Add(this.CmdWhile);
            this.Name = "FrmWhileDoWhile";
            this.Text = "While/Do... while";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdWhile;
        private System.Windows.Forms.Button CmdDoWhile;
        private System.Windows.Forms.Label LblWhileDoWhile;
        private System.Windows.Forms.Button CmdEnde;
    }
}

