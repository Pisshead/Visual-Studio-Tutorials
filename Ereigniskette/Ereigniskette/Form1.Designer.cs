namespace Ereigniskette
{
    partial class FrmEreigniskette
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
            this.CmdLoeschen = new System.Windows.Forms.Button();
            this.LblAnzeige1 = new System.Windows.Forms.Label();
            this.LblAnzeige2 = new System.Windows.Forms.Label();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.CmdEreignis3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdEreignis1
            // 
            this.CmdEreignis1.Location = new System.Drawing.Point(197, 12);
            this.CmdEreignis1.Name = "CmdEreignis1";
            this.CmdEreignis1.Size = new System.Drawing.Size(75, 23);
            this.CmdEreignis1.TabIndex = 0;
            this.CmdEreignis1.Text = "Ereignis 1";
            this.CmdEreignis1.UseVisualStyleBackColor = true;
            this.CmdEreignis1.Click += new System.EventHandler(this.CmdEreignis1_Click);
            // 
            // CmdEreignis2
            // 
            this.CmdEreignis2.Location = new System.Drawing.Point(197, 41);
            this.CmdEreignis2.Name = "CmdEreignis2";
            this.CmdEreignis2.Size = new System.Drawing.Size(75, 23);
            this.CmdEreignis2.TabIndex = 1;
            this.CmdEreignis2.Text = "Ereignis 2";
            this.CmdEreignis2.UseVisualStyleBackColor = true;
            this.CmdEreignis2.Click += new System.EventHandler(this.CmdEreignis2_Click);
            // 
            // CmdLoeschen
            // 
            this.CmdLoeschen.Location = new System.Drawing.Point(197, 99);
            this.CmdLoeschen.Name = "CmdLoeschen";
            this.CmdLoeschen.Size = new System.Drawing.Size(75, 23);
            this.CmdLoeschen.TabIndex = 2;
            this.CmdLoeschen.Text = "Löschen";
            this.CmdLoeschen.UseVisualStyleBackColor = true;
            this.CmdLoeschen.Click += new System.EventHandler(this.CmdLoeschen_Click);
            // 
            // LblAnzeige1
            // 
            this.LblAnzeige1.AutoSize = true;
            this.LblAnzeige1.Location = new System.Drawing.Point(12, 17);
            this.LblAnzeige1.Name = "LblAnzeige1";
            this.LblAnzeige1.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige1.TabIndex = 3;
            // 
            // LblAnzeige2
            // 
            this.LblAnzeige2.AutoSize = true;
            this.LblAnzeige2.Location = new System.Drawing.Point(12, 46);
            this.LblAnzeige2.Name = "LblAnzeige2";
            this.LblAnzeige2.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige2.TabIndex = 4;
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(197, 226);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 5;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // CmdEreignis3
            // 
            this.CmdEreignis3.Location = new System.Drawing.Point(197, 70);
            this.CmdEreignis3.Name = "CmdEreignis3";
            this.CmdEreignis3.Size = new System.Drawing.Size(75, 23);
            this.CmdEreignis3.TabIndex = 6;
            this.CmdEreignis3.Text = "Ereignis 1+2";
            this.CmdEreignis3.UseVisualStyleBackColor = true;
            this.CmdEreignis3.Click += new System.EventHandler(this.CmdEreignis3_Click);
            // 
            // FrmEreigniskette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdEreignis3);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.LblAnzeige2);
            this.Controls.Add(this.LblAnzeige1);
            this.Controls.Add(this.CmdLoeschen);
            this.Controls.Add(this.CmdEreignis2);
            this.Controls.Add(this.CmdEreignis1);
            this.Name = "FrmEreigniskette";
            this.Text = "Ereigniskette";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdEreignis1;
        private System.Windows.Forms.Button CmdEreignis2;
        private System.Windows.Forms.Button CmdLoeschen;
        private System.Windows.Forms.Label LblAnzeige1;
        private System.Windows.Forms.Label LblAnzeige2;
        private System.Windows.Forms.Button CmdEnde;
        private System.Windows.Forms.Button CmdEreignis3;
    }
}

