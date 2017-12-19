namespace ButtonEndlos
{
    partial class FrmButtonEndlos
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
            this.CmdEreignis1 = new System.Windows.Forms.Button();
            this.CmdEreignis2 = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdEreignis1
            // 
            this.CmdEreignis1.Location = new System.Drawing.Point(197, 13);
            this.CmdEreignis1.Name = "CmdEreignis1";
            this.CmdEreignis1.Size = new System.Drawing.Size(75, 23);
            this.CmdEreignis1.TabIndex = 0;
            this.CmdEreignis1.Text = "Ereignis 1";
            this.CmdEreignis1.UseVisualStyleBackColor = true;
            this.CmdEreignis1.Click += new System.EventHandler(this.CmdEreignis1_Click);
            // 
            // CmdEreignis2
            // 
            this.CmdEreignis2.Location = new System.Drawing.Point(197, 43);
            this.CmdEreignis2.Name = "CmdEreignis2";
            this.CmdEreignis2.Size = new System.Drawing.Size(75, 23);
            this.CmdEreignis2.TabIndex = 1;
            this.CmdEreignis2.Text = "Ereignis 2";
            this.CmdEreignis2.UseVisualStyleBackColor = true;
            this.CmdEreignis2.Click += new System.EventHandler(this.CmdEreignis2_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(13, 13);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 2;
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
            // FrmButtonEndlos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdEreignis2);
            this.Controls.Add(this.CmdEreignis1);
            this.Name = "FrmButtonEndlos";
            this.Text = "Button Endlos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdEreignis1;
        private System.Windows.Forms.Button CmdEreignis2;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdEnde;
    }
}

