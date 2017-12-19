namespace UKranOptionen
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
            this.components = new System.ComponentModel.Container();
            this.h = new System.Windows.Forms.Panel();
            this.a = new System.Windows.Forms.Panel();
            this.s = new System.Windows.Forms.Panel();
            this.f = new System.Windows.Forms.Panel();
            this.CmdStart = new System.Windows.Forms.Button();
            this.CmdStop = new System.Windows.Forms.Button();
            this.OptHakenAus = new System.Windows.Forms.RadioButton();
            this.OptHakenEin = new System.Windows.Forms.RadioButton();
            this.OptAuslegerAus = new System.Windows.Forms.RadioButton();
            this.OptAuslegerEin = new System.Windows.Forms.RadioButton();
            this.OptKranRechts = new System.Windows.Forms.RadioButton();
            this.OptKranLinks = new System.Windows.Forms.RadioButton();
            this.OptKranAus = new System.Windows.Forms.RadioButton();
            this.OptKranEin = new System.Windows.Forms.RadioButton();
            this.TimKran = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // h
            // 
            this.h.BackColor = System.Drawing.Color.Gray;
            this.h.Location = new System.Drawing.Point(93, 91);
            this.h.Name = "h";
            this.h.Size = new System.Drawing.Size(10, 20);
            this.h.TabIndex = 22;
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.Gray;
            this.a.Location = new System.Drawing.Point(93, 81);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(50, 10);
            this.a.TabIndex = 20;
            // 
            // s
            // 
            this.s.BackColor = System.Drawing.Color.Gray;
            this.s.Location = new System.Drawing.Point(143, 81);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(10, 100);
            this.s.TabIndex = 21;
            // 
            // f
            // 
            this.f.BackColor = System.Drawing.Color.Gray;
            this.f.Location = new System.Drawing.Point(123, 181);
            this.f.Name = "f";
            this.f.Size = new System.Drawing.Size(50, 10);
            this.f.TabIndex = 19;
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(257, 205);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(100, 23);
            this.CmdStart.TabIndex = 18;
            this.CmdStart.Text = "Start";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // CmdStop
            // 
            this.CmdStop.Location = new System.Drawing.Point(372, 205);
            this.CmdStop.Name = "CmdStop";
            this.CmdStop.Size = new System.Drawing.Size(100, 23);
            this.CmdStop.TabIndex = 17;
            this.CmdStop.Text = "Stop";
            this.CmdStop.UseVisualStyleBackColor = true;
            this.CmdStop.Click += new System.EventHandler(this.CmdStop_Click);
            // 
            // OptHakenAus
            // 
            this.OptHakenAus.AutoSize = true;
            this.OptHakenAus.Checked = true;
            this.OptHakenAus.Location = new System.Drawing.Point(381, 12);
            this.OptHakenAus.Name = "OptHakenAus";
            this.OptHakenAus.Size = new System.Drawing.Size(77, 17);
            this.OptHakenAus.TabIndex = 23;
            this.OptHakenAus.TabStop = true;
            this.OptHakenAus.Text = "Haken aus";
            this.OptHakenAus.UseVisualStyleBackColor = true;
            // 
            // OptHakenEin
            // 
            this.OptHakenEin.AutoSize = true;
            this.OptHakenEin.Location = new System.Drawing.Point(381, 35);
            this.OptHakenEin.Name = "OptHakenEin";
            this.OptHakenEin.Size = new System.Drawing.Size(74, 17);
            this.OptHakenEin.TabIndex = 24;
            this.OptHakenEin.TabStop = true;
            this.OptHakenEin.Text = "Haken ein";
            this.OptHakenEin.UseVisualStyleBackColor = true;
            // 
            // OptAuslegerAus
            // 
            this.OptAuslegerAus.AutoSize = true;
            this.OptAuslegerAus.Location = new System.Drawing.Point(381, 58);
            this.OptAuslegerAus.Name = "OptAuslegerAus";
            this.OptAuslegerAus.Size = new System.Drawing.Size(86, 17);
            this.OptAuslegerAus.TabIndex = 25;
            this.OptAuslegerAus.TabStop = true;
            this.OptAuslegerAus.Text = "Ausleger aus";
            this.OptAuslegerAus.UseVisualStyleBackColor = true;
            // 
            // OptAuslegerEin
            // 
            this.OptAuslegerEin.AutoSize = true;
            this.OptAuslegerEin.Location = new System.Drawing.Point(381, 82);
            this.OptAuslegerEin.Name = "OptAuslegerEin";
            this.OptAuslegerEin.Size = new System.Drawing.Size(83, 17);
            this.OptAuslegerEin.TabIndex = 26;
            this.OptAuslegerEin.TabStop = true;
            this.OptAuslegerEin.Text = "Ausleger ein";
            this.OptAuslegerEin.UseVisualStyleBackColor = true;
            // 
            // OptKranRechts
            // 
            this.OptKranRechts.AutoSize = true;
            this.OptKranRechts.Location = new System.Drawing.Point(381, 105);
            this.OptKranRechts.Name = "OptKranRechts";
            this.OptKranRechts.Size = new System.Drawing.Size(79, 17);
            this.OptKranRechts.TabIndex = 27;
            this.OptKranRechts.TabStop = true;
            this.OptKranRechts.Text = "Kran rechts";
            this.OptKranRechts.UseVisualStyleBackColor = true;
            // 
            // OptKranLinks
            // 
            this.OptKranLinks.AutoSize = true;
            this.OptKranLinks.Location = new System.Drawing.Point(381, 128);
            this.OptKranLinks.Name = "OptKranLinks";
            this.OptKranLinks.Size = new System.Drawing.Size(71, 17);
            this.OptKranLinks.TabIndex = 28;
            this.OptKranLinks.TabStop = true;
            this.OptKranLinks.Text = "Kran links";
            this.OptKranLinks.UseVisualStyleBackColor = true;
            // 
            // OptKranAus
            // 
            this.OptKranAus.AutoSize = true;
            this.OptKranAus.Location = new System.Drawing.Point(381, 151);
            this.OptKranAus.Name = "OptKranAus";
            this.OptKranAus.Size = new System.Drawing.Size(67, 17);
            this.OptKranAus.TabIndex = 29;
            this.OptKranAus.TabStop = true;
            this.OptKranAus.Text = "Kran aus";
            this.OptKranAus.UseVisualStyleBackColor = true;
            // 
            // OptKranEin
            // 
            this.OptKranEin.AutoSize = true;
            this.OptKranEin.Location = new System.Drawing.Point(381, 174);
            this.OptKranEin.Name = "OptKranEin";
            this.OptKranEin.Size = new System.Drawing.Size(64, 17);
            this.OptKranEin.TabIndex = 30;
            this.OptKranEin.TabStop = true;
            this.OptKranEin.Text = "Kran ein";
            this.OptKranEin.UseVisualStyleBackColor = true;
            // 
            // TimKran
            // 
            this.TimKran.Interval = 500;
            this.TimKran.Tick += new System.EventHandler(this.TimKran_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.OptKranEin);
            this.Controls.Add(this.OptKranAus);
            this.Controls.Add(this.OptKranLinks);
            this.Controls.Add(this.OptKranRechts);
            this.Controls.Add(this.OptAuslegerEin);
            this.Controls.Add(this.OptAuslegerAus);
            this.Controls.Add(this.OptHakenEin);
            this.Controls.Add(this.OptHakenAus);
            this.Controls.Add(this.h);
            this.Controls.Add(this.a);
            this.Controls.Add(this.s);
            this.Controls.Add(this.f);
            this.Controls.Add(this.CmdStart);
            this.Controls.Add(this.CmdStop);
            this.Name = "Form1";
            this.Text = "Bewegung per Timer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel h;
        private System.Windows.Forms.Panel a;
        private System.Windows.Forms.Panel s;
        private System.Windows.Forms.Panel f;
        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.Button CmdStop;
        private System.Windows.Forms.RadioButton OptHakenAus;
        private System.Windows.Forms.RadioButton OptHakenEin;
        private System.Windows.Forms.RadioButton OptAuslegerAus;
        private System.Windows.Forms.RadioButton OptAuslegerEin;
        private System.Windows.Forms.RadioButton OptKranRechts;
        private System.Windows.Forms.RadioButton OptKranLinks;
        private System.Windows.Forms.RadioButton OptKranAus;
        private System.Windows.Forms.RadioButton OptKranEin;
        private System.Windows.Forms.Timer TimKran;
    }
}

