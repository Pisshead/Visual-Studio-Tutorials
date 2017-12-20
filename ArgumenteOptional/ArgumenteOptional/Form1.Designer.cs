namespace ArgumenteOptional
{
    partial class FrmAddieren
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
            this.Cmd2Argumente = new System.Windows.Forms.Button();
            this.Cmd3Argumente = new System.Windows.Forms.Button();
            this.Cmd4Argumente = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Cmd2Argumente
            // 
            this.Cmd2Argumente.Location = new System.Drawing.Point(322, 12);
            this.Cmd2Argumente.Name = "Cmd2Argumente";
            this.Cmd2Argumente.Size = new System.Drawing.Size(75, 23);
            this.Cmd2Argumente.TabIndex = 0;
            this.Cmd2Argumente.Text = "2 Argumente";
            this.Cmd2Argumente.UseVisualStyleBackColor = true;
            this.Cmd2Argumente.Click += new System.EventHandler(this.Cmd2Argumente_Click);
            // 
            // Cmd3Argumente
            // 
            this.Cmd3Argumente.Location = new System.Drawing.Point(322, 42);
            this.Cmd3Argumente.Name = "Cmd3Argumente";
            this.Cmd3Argumente.Size = new System.Drawing.Size(75, 23);
            this.Cmd3Argumente.TabIndex = 1;
            this.Cmd3Argumente.Text = "3 Argumente";
            this.Cmd3Argumente.UseVisualStyleBackColor = true;
            this.Cmd3Argumente.Click += new System.EventHandler(this.Cmd3Argumente_Click);
            // 
            // Cmd4Argumente
            // 
            this.Cmd4Argumente.Location = new System.Drawing.Point(322, 72);
            this.Cmd4Argumente.Name = "Cmd4Argumente";
            this.Cmd4Argumente.Size = new System.Drawing.Size(75, 23);
            this.Cmd4Argumente.TabIndex = 2;
            this.Cmd4Argumente.Text = "4 Argumente";
            this.Cmd4Argumente.UseVisualStyleBackColor = true;
            this.Cmd4Argumente.Click += new System.EventHandler(this.Cmd4Argumente_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(13, 21);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 3;
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(322, 226);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 4;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // FrmAddieren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 261);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.Cmd4Argumente);
            this.Controls.Add(this.Cmd3Argumente);
            this.Controls.Add(this.Cmd2Argumente);
            this.Name = "FrmAddieren";
            this.Text = "Addieren mit verschiedener Anzahl Argumenten";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Cmd2Argumente;
        private System.Windows.Forms.Button Cmd3Argumente;
        private System.Windows.Forms.Button Cmd4Argumente;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdEnde;
    }
}

