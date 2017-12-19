namespace Konstanten
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
            this.CmdKonstanten = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdEnumeration1 = new System.Windows.Forms.Button();
            this.CmdEnumeration2 = new System.Windows.Forms.Button();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdKonstanten
            // 
            this.CmdKonstanten.Location = new System.Drawing.Point(13, 13);
            this.CmdKonstanten.Name = "CmdKonstanten";
            this.CmdKonstanten.Size = new System.Drawing.Size(81, 23);
            this.CmdKonstanten.TabIndex = 0;
            this.CmdKonstanten.Text = "Anzeigen";
            this.CmdKonstanten.UseVisualStyleBackColor = true;
            this.CmdKonstanten.Click += new System.EventHandler(this.CmdKonstanten_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(94, 18);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 16);
            this.LblAnzeige.TabIndex = 1;
            this.LblAnzeige.UseCompatibleTextRendering = true;
            // 
            // CmdEnumeration1
            // 
            this.CmdEnumeration1.Location = new System.Drawing.Point(13, 43);
            this.CmdEnumeration1.Name = "CmdEnumeration1";
            this.CmdEnumeration1.Size = new System.Drawing.Size(81, 23);
            this.CmdEnumeration1.TabIndex = 2;
            this.CmdEnumeration1.Text = "Enumeration1";
            this.CmdEnumeration1.UseVisualStyleBackColor = true;
            this.CmdEnumeration1.Click += new System.EventHandler(this.CmdEnumeration1_Click);
            // 
            // CmdEnumeration2
            // 
            this.CmdEnumeration2.Location = new System.Drawing.Point(13, 73);
            this.CmdEnumeration2.Name = "CmdEnumeration2";
            this.CmdEnumeration2.Size = new System.Drawing.Size(81, 23);
            this.CmdEnumeration2.TabIndex = 3;
            this.CmdEnumeration2.Text = "Enumeration2";
            this.CmdEnumeration2.UseVisualStyleBackColor = true;
            this.CmdEnumeration2.Click += new System.EventHandler(this.CmdEnumeration2_Click);
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(197, 226);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 4;
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
            this.Controls.Add(this.CmdEnumeration2);
            this.Controls.Add(this.CmdEnumeration1);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdKonstanten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdKonstanten;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdEnumeration1;
        private System.Windows.Forms.Button CmdEnumeration2;
        private System.Windows.Forms.Button CmdEnde;
    }
}

