namespace KlasseObjekt
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
            this.CmdAusgabe = new System.Windows.Forms.Button();
            this.LblV1 = new System.Windows.Forms.Label();
            this.LblV2 = new System.Windows.Forms.Label();
            this.LblAnzeigeV1 = new System.Windows.Forms.Label();
            this.LblAnzeigeV2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdAusgabe
            // 
            this.CmdAusgabe.Location = new System.Drawing.Point(287, 24);
            this.CmdAusgabe.Name = "CmdAusgabe";
            this.CmdAusgabe.Size = new System.Drawing.Size(103, 28);
            this.CmdAusgabe.TabIndex = 0;
            this.CmdAusgabe.Text = "Anzeigen";
            this.CmdAusgabe.UseVisualStyleBackColor = true;
            this.CmdAusgabe.Click += new System.EventHandler(this.CmdAusgabe_Click);
            // 
            // LblV1
            // 
            this.LblV1.AutoSize = true;
            this.LblV1.Location = new System.Drawing.Point(27, 24);
            this.LblV1.Name = "LblV1";
            this.LblV1.Size = new System.Drawing.Size(97, 13);
            this.LblV1.TabIndex = 1;
            this.LblV1.Text = "Geschwindigkeit 1:";
            // 
            // LblV2
            // 
            this.LblV2.AutoSize = true;
            this.LblV2.Location = new System.Drawing.Point(27, 58);
            this.LblV2.Name = "LblV2";
            this.LblV2.Size = new System.Drawing.Size(97, 13);
            this.LblV2.TabIndex = 2;
            this.LblV2.Text = "Geschwindigkeit 2:";
            // 
            // LblAnzeigeV1
            // 
            this.LblAnzeigeV1.AutoSize = true;
            this.LblAnzeigeV1.Location = new System.Drawing.Point(146, 23);
            this.LblAnzeigeV1.Name = "LblAnzeigeV1";
            this.LblAnzeigeV1.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeigeV1.TabIndex = 3;
            // 
            // LblAnzeigeV2
            // 
            this.LblAnzeigeV2.AutoSize = true;
            this.LblAnzeigeV2.Location = new System.Drawing.Point(147, 58);
            this.LblAnzeigeV2.Name = "LblAnzeigeV2";
            this.LblAnzeigeV2.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeigeV2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 179);
            this.Controls.Add(this.LblAnzeigeV2);
            this.Controls.Add(this.LblAnzeigeV1);
            this.Controls.Add(this.LblV2);
            this.Controls.Add(this.LblV1);
            this.Controls.Add(this.CmdAusgabe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdAusgabe;
        private System.Windows.Forms.Label LblV1;
        private System.Windows.Forms.Label LblV2;
        private System.Windows.Forms.Label LblAnzeigeV1;
        private System.Windows.Forms.Label LblAnzeigeV2;
    }
}

