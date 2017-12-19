namespace ListenfeldEigenschaften
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
            this.CmdAnzeige = new System.Windows.Forms.Button();
            this.LstSpeisen = new System.Windows.Forms.ListBox();
            this.LblAnzeige1 = new System.Windows.Forms.Label();
            this.LblAnzeige2 = new System.Windows.Forms.Label();
            this.LblAnzeige3 = new System.Windows.Forms.Label();
            this.LblAnzeige4 = new System.Windows.Forms.Label();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.CmdForEach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdAnzeige
            // 
            this.CmdAnzeige.Location = new System.Drawing.Point(259, 12);
            this.CmdAnzeige.Name = "CmdAnzeige";
            this.CmdAnzeige.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeige.TabIndex = 0;
            this.CmdAnzeige.Text = "Anzeige";
            this.CmdAnzeige.UseVisualStyleBackColor = true;
            this.CmdAnzeige.Click += new System.EventHandler(this.CmdAnzeige_Click);
            // 
            // LstSpeisen
            // 
            this.LstSpeisen.FormattingEnabled = true;
            this.LstSpeisen.Location = new System.Drawing.Point(13, 13);
            this.LstSpeisen.Name = "LstSpeisen";
            this.LstSpeisen.Size = new System.Drawing.Size(120, 95);
            this.LstSpeisen.TabIndex = 1;
            this.LstSpeisen.SelectedIndexChanged += new System.EventHandler(this.LstSpeisen_SelectedIndexChanged);
            // 
            // LblAnzeige1
            // 
            this.LblAnzeige1.AutoSize = true;
            this.LblAnzeige1.Location = new System.Drawing.Point(13, 115);
            this.LblAnzeige1.Name = "LblAnzeige1";
            this.LblAnzeige1.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige1.TabIndex = 2;
            // 
            // LblAnzeige2
            // 
            this.LblAnzeige2.AutoSize = true;
            this.LblAnzeige2.Location = new System.Drawing.Point(13, 150);
            this.LblAnzeige2.Name = "LblAnzeige2";
            this.LblAnzeige2.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige2.TabIndex = 3;
            // 
            // LblAnzeige3
            // 
            this.LblAnzeige3.AutoSize = true;
            this.LblAnzeige3.Location = new System.Drawing.Point(10, 180);
            this.LblAnzeige3.Name = "LblAnzeige3";
            this.LblAnzeige3.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige3.TabIndex = 4;
            // 
            // LblAnzeige4
            // 
            this.LblAnzeige4.AutoSize = true;
            this.LblAnzeige4.Location = new System.Drawing.Point(10, 215);
            this.LblAnzeige4.Name = "LblAnzeige4";
            this.LblAnzeige4.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige4.TabIndex = 5;
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(259, 291);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 6;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // CmdForEach
            // 
            this.CmdForEach.Location = new System.Drawing.Point(258, 164);
            this.CmdForEach.Name = "CmdForEach";
            this.CmdForEach.Size = new System.Drawing.Size(75, 23);
            this.CmdForEach.TabIndex = 7;
            this.CmdForEach.Text = "foreach";
            this.CmdForEach.UseVisualStyleBackColor = true;
            this.CmdForEach.Click += new System.EventHandler(this.CmdForEach_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 326);
            this.Controls.Add(this.CmdForEach);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.LblAnzeige4);
            this.Controls.Add(this.LblAnzeige3);
            this.Controls.Add(this.LblAnzeige2);
            this.Controls.Add(this.LblAnzeige1);
            this.Controls.Add(this.LstSpeisen);
            this.Controls.Add(this.CmdAnzeige);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdAnzeige;
        private System.Windows.Forms.ListBox LstSpeisen;
        private System.Windows.Forms.Label LblAnzeige1;
        private System.Windows.Forms.Label LblAnzeige2;
        private System.Windows.Forms.Label LblAnzeige3;
        private System.Windows.Forms.Label LblAnzeige4;
        private System.Windows.Forms.Button CmdEnde;
        private System.Windows.Forms.Button CmdForEach;
    }
}

