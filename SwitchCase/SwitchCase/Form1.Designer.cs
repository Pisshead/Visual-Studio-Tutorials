namespace SwitchCase
{
    partial class FrmSwitchCase
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
            this.CmdAuswerten = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.NumX = new System.Windows.Forms.NumericUpDown();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.CmdAnzeige = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumX)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdAuswerten
            // 
            this.CmdAuswerten.Location = new System.Drawing.Point(197, 45);
            this.CmdAuswerten.Name = "CmdAuswerten";
            this.CmdAuswerten.Size = new System.Drawing.Size(75, 23);
            this.CmdAuswerten.TabIndex = 0;
            this.CmdAuswerten.Text = "Auswerten";
            this.CmdAuswerten.UseVisualStyleBackColor = true;
            this.CmdAuswerten.Click += new System.EventHandler(this.CmdAuswerten_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(125, 124);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 1;
            // 
            // NumX
            // 
            this.NumX.Location = new System.Drawing.Point(12, 45);
            this.NumX.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NumX.Name = "NumX";
            this.NumX.Size = new System.Drawing.Size(120, 20);
            this.NumX.TabIndex = 2;
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
            // CmdAnzeige
            // 
            this.CmdAnzeige.Location = new System.Drawing.Point(197, 83);
            this.CmdAnzeige.Name = "CmdAnzeige";
            this.CmdAnzeige.Size = new System.Drawing.Size(75, 23);
            this.CmdAnzeige.TabIndex = 4;
            this.CmdAnzeige.Text = "Anzeigen";
            this.CmdAnzeige.UseVisualStyleBackColor = true;
            this.CmdAnzeige.Click += new System.EventHandler(this.CmdAnzeige_Click);
            // 
            // FrmSwitchCase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdAnzeige);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.NumX);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdAuswerten);
            this.Name = "FrmSwitchCase";
            this.Text = "Switch Case";
            ((System.ComponentModel.ISupportInitialize)(this.NumX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdAuswerten;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.NumericUpDown NumX;
        private System.Windows.Forms.Button CmdEnde;
        private System.Windows.Forms.Button CmdAnzeige;
    }
}

