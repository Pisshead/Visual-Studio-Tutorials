namespace Zeitgeber
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
            this.components = new System.ComponentModel.Container();
            this.CmdStart = new System.Windows.Forms.Button();
            this.CmdStop = new System.Windows.Forms.Button();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.TimAnzeige = new System.Windows.Forms.Timer(this.components);
            this.CmdReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(33, 82);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(75, 23);
            this.CmdStart.TabIndex = 0;
            this.CmdStart.Text = "Start";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // CmdStop
            // 
            this.CmdStop.Location = new System.Drawing.Point(185, 82);
            this.CmdStop.Name = "CmdStop";
            this.CmdStop.Size = new System.Drawing.Size(75, 23);
            this.CmdStop.TabIndex = 1;
            this.CmdStop.Text = "Stop";
            this.CmdStop.UseVisualStyleBackColor = true;
            this.CmdStop.Click += new System.EventHandler(this.CmdStop_Click);
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(185, 206);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 2;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(30, 21);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 3;
            // 
            // TimAnzeige
            // 
            this.TimAnzeige.Interval = 500;
            this.TimAnzeige.Tick += new System.EventHandler(this.TimAnzeige_Tick);
            // 
            // CmdReset
            // 
            this.CmdReset.Location = new System.Drawing.Point(44, 206);
            this.CmdReset.Name = "CmdReset";
            this.CmdReset.Size = new System.Drawing.Size(75, 23);
            this.CmdReset.TabIndex = 4;
            this.CmdReset.Text = "Reset";
            this.CmdReset.UseVisualStyleBackColor = true;
            this.CmdReset.Click += new System.EventHandler(this.CmdReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdReset);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.CmdStop);
            this.Controls.Add(this.CmdStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.Button CmdStop;
        private System.Windows.Forms.Button CmdEnde;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Timer TimAnzeige;
        private System.Windows.Forms.Button CmdReset;
    }
}

