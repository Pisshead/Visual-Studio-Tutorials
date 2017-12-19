namespace Mathematik
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdBackSpace = new System.Windows.Forms.Button();
            this.CmdKomma = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.Cmd0 = new System.Windows.Forms.Button();
            this.Cmd9 = new System.Windows.Forms.Button();
            this.Cmd8 = new System.Windows.Forms.Button();
            this.Cmd7 = new System.Windows.Forms.Button();
            this.Cmd6 = new System.Windows.Forms.Button();
            this.Cmd5 = new System.Windows.Forms.Button();
            this.Cmd4 = new System.Windows.Forms.Button();
            this.Cmd3 = new System.Windows.Forms.Button();
            this.Cmd2 = new System.Windows.Forms.Button();
            this.Cmd1 = new System.Windows.Forms.Button();
            this.CmdTruncate = new System.Windows.Forms.Button();
            this.CmdKehrwert = new System.Windows.Forms.Button();
            this.CmdPlusMinus = new System.Windows.Forms.Button();
            this.CmdRound = new System.Windows.Forms.Button();
            this.CmdFloor = new System.Windows.Forms.Button();
            this.CmdWurzel = new System.Windows.Forms.Button();
            this.CmdCeiling = new System.Windows.Forms.Button();
            this.CmdPi = new System.Windows.Forms.Button();
            this.CmdE = new System.Windows.Forms.Button();
            this.CmdLog = new System.Windows.Forms.Button();
            this.CmdLn = new System.Windows.Forms.Button();
            this.ChkInv = new System.Windows.Forms.CheckBox();
            this.CmdTangens = new System.Windows.Forms.Button();
            this.CmdCosinus = new System.Windows.Forms.Button();
            this.CmdSinus = new System.Windows.Forms.Button();
            this.T = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CmdBackSpace
            // 
            this.CmdBackSpace.Location = new System.Drawing.Point(212, 40);
            this.CmdBackSpace.Name = "CmdBackSpace";
            this.CmdBackSpace.Size = new System.Drawing.Size(30, 23);
            this.CmdBackSpace.TabIndex = 132;
            this.CmdBackSpace.Text = "BS";
            this.CmdBackSpace.UseVisualStyleBackColor = true;
            this.CmdBackSpace.Click += new System.EventHandler(this.CmdBackSpace_Click);
            // 
            // CmdKomma
            // 
            this.CmdKomma.Location = new System.Drawing.Point(165, 156);
            this.CmdKomma.Name = "CmdKomma";
            this.CmdKomma.Size = new System.Drawing.Size(23, 23);
            this.CmdKomma.TabIndex = 131;
            this.CmdKomma.Text = ",";
            this.CmdKomma.UseVisualStyleBackColor = true;
            this.CmdKomma.Click += new System.EventHandler(this.CmdKomma_Click);
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(249, 40);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(23, 23);
            this.CmdClear.TabIndex = 130;
            this.CmdClear.Text = "C";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // Cmd0
            // 
            this.Cmd0.Location = new System.Drawing.Point(136, 156);
            this.Cmd0.Name = "Cmd0";
            this.Cmd0.Size = new System.Drawing.Size(23, 23);
            this.Cmd0.TabIndex = 129;
            this.Cmd0.Text = "0";
            this.Cmd0.UseVisualStyleBackColor = true;
            this.Cmd0.Click += new System.EventHandler(this.CmdZiffer_Click);
            // 
            // Cmd9
            // 
            this.Cmd9.Location = new System.Drawing.Point(165, 69);
            this.Cmd9.Name = "Cmd9";
            this.Cmd9.Size = new System.Drawing.Size(23, 23);
            this.Cmd9.TabIndex = 128;
            this.Cmd9.Text = "9";
            this.Cmd9.UseVisualStyleBackColor = true;
            this.Cmd9.Click += new System.EventHandler(this.CmdZiffer_Click);
            // 
            // Cmd8
            // 
            this.Cmd8.Location = new System.Drawing.Point(136, 69);
            this.Cmd8.Name = "Cmd8";
            this.Cmd8.Size = new System.Drawing.Size(23, 23);
            this.Cmd8.TabIndex = 127;
            this.Cmd8.Text = "8";
            this.Cmd8.UseVisualStyleBackColor = true;
            this.Cmd8.Click += new System.EventHandler(this.CmdZiffer_Click);
            // 
            // Cmd7
            // 
            this.Cmd7.Location = new System.Drawing.Point(107, 69);
            this.Cmd7.Name = "Cmd7";
            this.Cmd7.Size = new System.Drawing.Size(23, 23);
            this.Cmd7.TabIndex = 126;
            this.Cmd7.Text = "7";
            this.Cmd7.UseVisualStyleBackColor = true;
            this.Cmd7.Click += new System.EventHandler(this.CmdZiffer_Click);
            // 
            // Cmd6
            // 
            this.Cmd6.Location = new System.Drawing.Point(165, 98);
            this.Cmd6.Name = "Cmd6";
            this.Cmd6.Size = new System.Drawing.Size(23, 23);
            this.Cmd6.TabIndex = 125;
            this.Cmd6.Text = "6";
            this.Cmd6.UseVisualStyleBackColor = true;
            this.Cmd6.Click += new System.EventHandler(this.CmdZiffer_Click);
            // 
            // Cmd5
            // 
            this.Cmd5.Location = new System.Drawing.Point(136, 98);
            this.Cmd5.Name = "Cmd5";
            this.Cmd5.Size = new System.Drawing.Size(23, 23);
            this.Cmd5.TabIndex = 124;
            this.Cmd5.Text = "5";
            this.Cmd5.UseVisualStyleBackColor = true;
            this.Cmd5.Click += new System.EventHandler(this.CmdZiffer_Click);
            // 
            // Cmd4
            // 
            this.Cmd4.Location = new System.Drawing.Point(107, 98);
            this.Cmd4.Name = "Cmd4";
            this.Cmd4.Size = new System.Drawing.Size(23, 23);
            this.Cmd4.TabIndex = 123;
            this.Cmd4.Text = "4";
            this.Cmd4.UseVisualStyleBackColor = true;
            this.Cmd4.Click += new System.EventHandler(this.CmdZiffer_Click);
            // 
            // Cmd3
            // 
            this.Cmd3.Location = new System.Drawing.Point(165, 127);
            this.Cmd3.Name = "Cmd3";
            this.Cmd3.Size = new System.Drawing.Size(23, 23);
            this.Cmd3.TabIndex = 122;
            this.Cmd3.Text = "3";
            this.Cmd3.UseVisualStyleBackColor = true;
            this.Cmd3.Click += new System.EventHandler(this.CmdZiffer_Click);
            // 
            // Cmd2
            // 
            this.Cmd2.Location = new System.Drawing.Point(136, 127);
            this.Cmd2.Name = "Cmd2";
            this.Cmd2.Size = new System.Drawing.Size(23, 23);
            this.Cmd2.TabIndex = 121;
            this.Cmd2.Text = "2";
            this.Cmd2.UseVisualStyleBackColor = true;
            this.Cmd2.Click += new System.EventHandler(this.CmdZiffer_Click);
            // 
            // Cmd1
            // 
            this.Cmd1.Location = new System.Drawing.Point(107, 127);
            this.Cmd1.Name = "Cmd1";
            this.Cmd1.Size = new System.Drawing.Size(23, 23);
            this.Cmd1.TabIndex = 120;
            this.Cmd1.Text = "1";
            this.Cmd1.UseVisualStyleBackColor = true;
            this.Cmd1.Click += new System.EventHandler(this.CmdZiffer_Click);
            // 
            // CmdTruncate
            // 
            this.CmdTruncate.Location = new System.Drawing.Point(212, 156);
            this.CmdTruncate.Name = "CmdTruncate";
            this.CmdTruncate.Size = new System.Drawing.Size(60, 23);
            this.CmdTruncate.TabIndex = 119;
            this.CmdTruncate.Text = "Truncate";
            this.CmdTruncate.UseVisualStyleBackColor = true;
            this.CmdTruncate.Click += new System.EventHandler(this.CmdTruncate_Click);
            // 
            // CmdKehrwert
            // 
            this.CmdKehrwert.Location = new System.Drawing.Point(56, 185);
            this.CmdKehrwert.Name = "CmdKehrwert";
            this.CmdKehrwert.Size = new System.Drawing.Size(40, 23);
            this.CmdKehrwert.TabIndex = 118;
            this.CmdKehrwert.Text = "1/x";
            this.CmdKehrwert.UseVisualStyleBackColor = true;
            this.CmdKehrwert.Click += new System.EventHandler(this.CmdKehrwert_Click);
            // 
            // CmdPlusMinus
            // 
            this.CmdPlusMinus.Location = new System.Drawing.Point(10, 185);
            this.CmdPlusMinus.Name = "CmdPlusMinus";
            this.CmdPlusMinus.Size = new System.Drawing.Size(40, 23);
            this.CmdPlusMinus.TabIndex = 117;
            this.CmdPlusMinus.Text = "+/-";
            this.CmdPlusMinus.UseVisualStyleBackColor = true;
            this.CmdPlusMinus.Click += new System.EventHandler(this.CmdPlusMinus_Click);
            // 
            // CmdRound
            // 
            this.CmdRound.Location = new System.Drawing.Point(212, 127);
            this.CmdRound.Name = "CmdRound";
            this.CmdRound.Size = new System.Drawing.Size(60, 23);
            this.CmdRound.TabIndex = 116;
            this.CmdRound.Text = "Round";
            this.CmdRound.UseVisualStyleBackColor = true;
            this.CmdRound.Click += new System.EventHandler(this.CmdRound_Click);
            // 
            // CmdFloor
            // 
            this.CmdFloor.Location = new System.Drawing.Point(212, 98);
            this.CmdFloor.Name = "CmdFloor";
            this.CmdFloor.Size = new System.Drawing.Size(60, 23);
            this.CmdFloor.TabIndex = 115;
            this.CmdFloor.Text = "Floor";
            this.CmdFloor.UseVisualStyleBackColor = true;
            this.CmdFloor.Click += new System.EventHandler(this.CmdFloor_Click);
            // 
            // CmdWurzel
            // 
            this.CmdWurzel.Location = new System.Drawing.Point(51, 69);
            this.CmdWurzel.Name = "CmdWurzel";
            this.CmdWurzel.Size = new System.Drawing.Size(35, 23);
            this.CmdWurzel.TabIndex = 114;
            this.CmdWurzel.Text = "Sqrt";
            this.CmdWurzel.UseVisualStyleBackColor = true;
            this.CmdWurzel.Click += new System.EventHandler(this.CmdWurzel_Click);
            // 
            // CmdCeiling
            // 
            this.CmdCeiling.Location = new System.Drawing.Point(212, 69);
            this.CmdCeiling.Name = "CmdCeiling";
            this.CmdCeiling.Size = new System.Drawing.Size(60, 23);
            this.CmdCeiling.TabIndex = 113;
            this.CmdCeiling.Text = "Ceiling";
            this.CmdCeiling.UseVisualStyleBackColor = true;
            this.CmdCeiling.Click += new System.EventHandler(this.CmdCeiling_Click);
            // 
            // CmdPi
            // 
            this.CmdPi.Location = new System.Drawing.Point(102, 185);
            this.CmdPi.Name = "CmdPi";
            this.CmdPi.Size = new System.Drawing.Size(40, 23);
            this.CmdPi.TabIndex = 112;
            this.CmdPi.Text = "PI";
            this.CmdPi.UseVisualStyleBackColor = true;
            this.CmdPi.Click += new System.EventHandler(this.CmdPi_Click);
            // 
            // CmdE
            // 
            this.CmdE.Location = new System.Drawing.Point(148, 185);
            this.CmdE.Name = "CmdE";
            this.CmdE.Size = new System.Drawing.Size(40, 23);
            this.CmdE.TabIndex = 111;
            this.CmdE.Text = "E";
            this.CmdE.UseVisualStyleBackColor = true;
            this.CmdE.Click += new System.EventHandler(this.CmdE_Click);
            // 
            // CmdLog
            // 
            this.CmdLog.Location = new System.Drawing.Point(51, 127);
            this.CmdLog.Name = "CmdLog";
            this.CmdLog.Size = new System.Drawing.Size(35, 23);
            this.CmdLog.TabIndex = 110;
            this.CmdLog.Text = "log";
            this.CmdLog.UseVisualStyleBackColor = true;
            this.CmdLog.Click += new System.EventHandler(this.CmdLog_Click);
            // 
            // CmdLn
            // 
            this.CmdLn.Location = new System.Drawing.Point(51, 98);
            this.CmdLn.Name = "CmdLn";
            this.CmdLn.Size = new System.Drawing.Size(35, 23);
            this.CmdLn.TabIndex = 109;
            this.CmdLn.Text = "ln";
            this.CmdLn.UseVisualStyleBackColor = true;
            this.CmdLn.Click += new System.EventHandler(this.CmdLn_Click);
            // 
            // ChkInv
            // 
            this.ChkInv.AutoSize = true;
            this.ChkInv.Location = new System.Drawing.Point(11, 44);
            this.ChkInv.Name = "ChkInv";
            this.ChkInv.Size = new System.Drawing.Size(41, 17);
            this.ChkInv.TabIndex = 108;
            this.ChkInv.Text = "Inv";
            this.ChkInv.UseVisualStyleBackColor = true;
            // 
            // CmdTangens
            // 
            this.CmdTangens.Location = new System.Drawing.Point(10, 127);
            this.CmdTangens.Name = "CmdTangens";
            this.CmdTangens.Size = new System.Drawing.Size(35, 23);
            this.CmdTangens.TabIndex = 107;
            this.CmdTangens.Text = "tan";
            this.CmdTangens.UseVisualStyleBackColor = true;
            this.CmdTangens.Click += new System.EventHandler(this.CmdTangens_Click);
            // 
            // CmdCosinus
            // 
            this.CmdCosinus.Location = new System.Drawing.Point(10, 98);
            this.CmdCosinus.Name = "CmdCosinus";
            this.CmdCosinus.Size = new System.Drawing.Size(35, 23);
            this.CmdCosinus.TabIndex = 106;
            this.CmdCosinus.Text = "cos";
            this.CmdCosinus.UseVisualStyleBackColor = true;
            this.CmdCosinus.Click += new System.EventHandler(this.CmdCosinus_Click);
            // 
            // CmdSinus
            // 
            this.CmdSinus.Location = new System.Drawing.Point(10, 69);
            this.CmdSinus.Name = "CmdSinus";
            this.CmdSinus.Size = new System.Drawing.Size(35, 23);
            this.CmdSinus.TabIndex = 105;
            this.CmdSinus.Text = "sin";
            this.CmdSinus.UseVisualStyleBackColor = true;
            this.CmdSinus.Click += new System.EventHandler(this.CmdSinus_Click);
            // 
            // T
            // 
            this.T.BackColor = System.Drawing.SystemColors.Window;
            this.T.ForeColor = System.Drawing.SystemColors.WindowText;
            this.T.Location = new System.Drawing.Point(10, 12);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(262, 20);
            this.T.TabIndex = 104;
            this.T.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.T.TextChanged += new System.EventHandler(this.T_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdBackSpace);
            this.Controls.Add(this.CmdKomma);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.Cmd0);
            this.Controls.Add(this.Cmd9);
            this.Controls.Add(this.Cmd8);
            this.Controls.Add(this.Cmd7);
            this.Controls.Add(this.Cmd6);
            this.Controls.Add(this.Cmd5);
            this.Controls.Add(this.Cmd4);
            this.Controls.Add(this.Cmd3);
            this.Controls.Add(this.Cmd2);
            this.Controls.Add(this.Cmd1);
            this.Controls.Add(this.CmdTruncate);
            this.Controls.Add(this.CmdKehrwert);
            this.Controls.Add(this.CmdPlusMinus);
            this.Controls.Add(this.CmdRound);
            this.Controls.Add(this.CmdFloor);
            this.Controls.Add(this.CmdWurzel);
            this.Controls.Add(this.CmdCeiling);
            this.Controls.Add(this.CmdPi);
            this.Controls.Add(this.CmdE);
            this.Controls.Add(this.CmdLog);
            this.Controls.Add(this.CmdLn);
            this.Controls.Add(this.ChkInv);
            this.Controls.Add(this.CmdTangens);
            this.Controls.Add(this.CmdCosinus);
            this.Controls.Add(this.CmdSinus);
            this.Controls.Add(this.T);
            this.Name = "Form1";
            this.Text = "Mathematik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdBackSpace;
        internal System.Windows.Forms.Button CmdKomma;
        internal System.Windows.Forms.Button CmdClear;
        internal System.Windows.Forms.Button Cmd0;
        internal System.Windows.Forms.Button Cmd9;
        internal System.Windows.Forms.Button Cmd8;
        internal System.Windows.Forms.Button Cmd7;
        internal System.Windows.Forms.Button Cmd6;
        internal System.Windows.Forms.Button Cmd5;
        internal System.Windows.Forms.Button Cmd4;
        internal System.Windows.Forms.Button Cmd3;
        internal System.Windows.Forms.Button Cmd2;
        internal System.Windows.Forms.Button Cmd1;
        internal System.Windows.Forms.Button CmdTruncate;
        internal System.Windows.Forms.Button CmdKehrwert;
        internal System.Windows.Forms.Button CmdPlusMinus;
        internal System.Windows.Forms.Button CmdRound;
        internal System.Windows.Forms.Button CmdFloor;
        internal System.Windows.Forms.Button CmdWurzel;
        internal System.Windows.Forms.Button CmdCeiling;
        internal System.Windows.Forms.Button CmdPi;
        internal System.Windows.Forms.Button CmdE;
        internal System.Windows.Forms.Button CmdLog;
        internal System.Windows.Forms.Button CmdLn;
        internal System.Windows.Forms.CheckBox ChkInv;
        internal System.Windows.Forms.Button CmdTangens;
        internal System.Windows.Forms.Button CmdCosinus;
        internal System.Windows.Forms.Button CmdSinus;
        internal System.Windows.Forms.TextBox T;
    }
}

