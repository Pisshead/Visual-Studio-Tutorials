namespace UPanels
{
    partial class FrmZeitgeber
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
            this.components = new System.ComponentModel.Container();
            this.CmdStart = new System.Windows.Forms.Button();
            this.TimPanels = new System.Windows.Forms.Timer(this.components);
            this.pBlue = new System.Windows.Forms.Panel();
            this.pYellow = new System.Windows.Forms.Panel();
            this.pRed = new System.Windows.Forms.Panel();
            this.pGreen = new System.Windows.Forms.Panel();
            this.CmdStop = new System.Windows.Forms.Button();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(155, 12);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(75, 23);
            this.CmdStart.TabIndex = 0;
            this.CmdStart.Text = "Start";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // TimPanels
            // 
            this.TimPanels.Tick += new System.EventHandler(this.TimPanels_Tick);
            // 
            // pBlue
            // 
            this.pBlue.BackColor = System.Drawing.Color.Blue;
            this.pBlue.Location = new System.Drawing.Point(169, 157);
            this.pBlue.Name = "pBlue";
            this.pBlue.Size = new System.Drawing.Size(20, 20);
            this.pBlue.TabIndex = 1;
            // 
            // pYellow
            // 
            this.pYellow.BackColor = System.Drawing.Color.Yellow;
            this.pYellow.Location = new System.Drawing.Point(195, 157);
            this.pYellow.Name = "pYellow";
            this.pYellow.Size = new System.Drawing.Size(20, 20);
            this.pYellow.TabIndex = 2;
            // 
            // pRed
            // 
            this.pRed.BackColor = System.Drawing.Color.Red;
            this.pRed.Location = new System.Drawing.Point(195, 183);
            this.pRed.Name = "pRed";
            this.pRed.Size = new System.Drawing.Size(20, 20);
            this.pRed.TabIndex = 3;
            // 
            // pGreen
            // 
            this.pGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pGreen.Location = new System.Drawing.Point(169, 183);
            this.pGreen.Name = "pGreen";
            this.pGreen.Size = new System.Drawing.Size(20, 20);
            this.pGreen.TabIndex = 4;
            // 
            // CmdStop
            // 
            this.CmdStop.Location = new System.Drawing.Point(155, 41);
            this.CmdStop.Name = "CmdStop";
            this.CmdStop.Size = new System.Drawing.Size(75, 23);
            this.CmdStop.TabIndex = 5;
            this.CmdStop.Text = "Stop";
            this.CmdStop.UseVisualStyleBackColor = true;
            this.CmdStop.Click += new System.EventHandler(this.CmdStop_Click);
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(154, 326);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 6;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // FrmZeitgeber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.CmdStop);
            this.Controls.Add(this.pGreen);
            this.Controls.Add(this.pRed);
            this.Controls.Add(this.pYellow);
            this.Controls.Add(this.pBlue);
            this.Controls.Add(this.CmdStart);
            this.Name = "FrmZeitgeber";
            this.Text = "Zeitgeber";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.Timer TimPanels;
        private System.Windows.Forms.Panel pBlue;
        private System.Windows.Forms.Panel pYellow;
        private System.Windows.Forms.Panel pRed;
        private System.Windows.Forms.Panel pGreen;
        private System.Windows.Forms.Button CmdStop;
        private System.Windows.Forms.Button CmdEnde;
    }
}

