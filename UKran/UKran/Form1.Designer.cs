namespace UKran
{
    partial class FrmKran
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
            this.pFundament = new System.Windows.Forms.Panel();
            this.pSenkrecht = new System.Windows.Forms.Panel();
            this.pWaagrecht = new System.Windows.Forms.Panel();
            this.pHaken = new System.Windows.Forms.Panel();
            this.CmdKranNachLinks = new System.Windows.Forms.Button();
            this.CmdHakenNachUnten = new System.Windows.Forms.Button();
            this.CmdHakenNachOben = new System.Windows.Forms.Button();
            this.CmdAuslegerNachRechts = new System.Windows.Forms.Button();
            this.CmdAusleger = new System.Windows.Forms.Button();
            this.CmdKranNachRechts = new System.Windows.Forms.Button();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.TimHakenAnheben = new System.Windows.Forms.Timer(this.components);
            this.CmdStop = new System.Windows.Forms.Button();
            this.TimHakenAbsenken = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.TimKranNachLinks = new System.Windows.Forms.Timer(this.components);
            this.TimKranNachRechts = new System.Windows.Forms.Timer(this.components);
            this.TimAuslegerNachRechts = new System.Windows.Forms.Timer(this.components);
            this.TimAuslegerNachLinks = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pFundament
            // 
            this.pFundament.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pFundament.Location = new System.Drawing.Point(335, 585);
            this.pFundament.Name = "pFundament";
            this.pFundament.Size = new System.Drawing.Size(200, 50);
            this.pFundament.TabIndex = 0;
            // 
            // pSenkrecht
            // 
            this.pSenkrecht.BackColor = System.Drawing.Color.Yellow;
            this.pSenkrecht.Location = new System.Drawing.Point(418, 268);
            this.pSenkrecht.Name = "pSenkrecht";
            this.pSenkrecht.Size = new System.Drawing.Size(38, 311);
            this.pSenkrecht.TabIndex = 1;
            // 
            // pWaagrecht
            // 
            this.pWaagrecht.BackColor = System.Drawing.Color.Yellow;
            this.pWaagrecht.Location = new System.Drawing.Point(258, 287);
            this.pWaagrecht.Name = "pWaagrecht";
            this.pWaagrecht.Size = new System.Drawing.Size(281, 36);
            this.pWaagrecht.TabIndex = 2;
            // 
            // pHaken
            // 
            this.pHaken.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pHaken.Location = new System.Drawing.Point(273, 329);
            this.pHaken.Name = "pHaken";
            this.pHaken.Size = new System.Drawing.Size(12, 177);
            this.pHaken.TabIndex = 3;
            // 
            // CmdKranNachLinks
            // 
            this.CmdKranNachLinks.Location = new System.Drawing.Point(12, 12);
            this.CmdKranNachLinks.Name = "CmdKranNachLinks";
            this.CmdKranNachLinks.Size = new System.Drawing.Size(211, 23);
            this.CmdKranNachLinks.TabIndex = 4;
            this.CmdKranNachLinks.Text = "Kran nach links bewegen";
            this.CmdKranNachLinks.UseVisualStyleBackColor = true;
            this.CmdKranNachLinks.Click += new System.EventHandler(this.CmdKranNachLinks_Click);
            // 
            // CmdHakenNachUnten
            // 
            this.CmdHakenNachUnten.Location = new System.Drawing.Point(12, 157);
            this.CmdHakenNachUnten.Name = "CmdHakenNachUnten";
            this.CmdHakenNachUnten.Size = new System.Drawing.Size(211, 23);
            this.CmdHakenNachUnten.TabIndex = 6;
            this.CmdHakenNachUnten.Text = "Haken absenken";
            this.CmdHakenNachUnten.UseVisualStyleBackColor = true;
            this.CmdHakenNachUnten.Click += new System.EventHandler(this.CmdHakenNachUnten_Click);
            // 
            // CmdHakenNachOben
            // 
            this.CmdHakenNachOben.Location = new System.Drawing.Point(12, 128);
            this.CmdHakenNachOben.Name = "CmdHakenNachOben";
            this.CmdHakenNachOben.Size = new System.Drawing.Size(211, 23);
            this.CmdHakenNachOben.TabIndex = 8;
            this.CmdHakenNachOben.Text = "Haken anheben";
            this.CmdHakenNachOben.UseVisualStyleBackColor = true;
            this.CmdHakenNachOben.Click += new System.EventHandler(this.CmdHakenNachOben_Click);
            // 
            // CmdAuslegerNachRechts
            // 
            this.CmdAuslegerNachRechts.Location = new System.Drawing.Point(12, 99);
            this.CmdAuslegerNachRechts.Name = "CmdAuslegerNachRechts";
            this.CmdAuslegerNachRechts.Size = new System.Drawing.Size(211, 23);
            this.CmdAuslegerNachRechts.TabIndex = 9;
            this.CmdAuslegerNachRechts.Text = "Ausleger nach Rechts bewegen";
            this.CmdAuslegerNachRechts.UseVisualStyleBackColor = true;
            this.CmdAuslegerNachRechts.Click += new System.EventHandler(this.CmdAuslegerNachRechts_Click);
            // 
            // CmdAusleger
            // 
            this.CmdAusleger.Location = new System.Drawing.Point(12, 70);
            this.CmdAusleger.Name = "CmdAusleger";
            this.CmdAusleger.Size = new System.Drawing.Size(211, 23);
            this.CmdAusleger.TabIndex = 10;
            this.CmdAusleger.Text = "Ausleger nach Links bewegen";
            this.CmdAusleger.UseVisualStyleBackColor = true;
            this.CmdAusleger.Click += new System.EventHandler(this.CmdAusleger_Click);
            // 
            // CmdKranNachRechts
            // 
            this.CmdKranNachRechts.Location = new System.Drawing.Point(12, 41);
            this.CmdKranNachRechts.Name = "CmdKranNachRechts";
            this.CmdKranNachRechts.Size = new System.Drawing.Size(211, 23);
            this.CmdKranNachRechts.TabIndex = 11;
            this.CmdKranNachRechts.Text = "Kran nach Rechts bewegen";
            this.CmdKranNachRechts.UseVisualStyleBackColor = true;
            this.CmdKranNachRechts.Click += new System.EventHandler(this.CmdKranNachRechts_Click);
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(767, 611);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 12;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // TimHakenAnheben
            // 
            this.TimHakenAnheben.Tick += new System.EventHandler(this.TimStart_Tick);
            // 
            // CmdStop
            // 
            this.CmdStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdStop.Location = new System.Drawing.Point(323, 12);
            this.CmdStop.Name = "CmdStop";
            this.CmdStop.Size = new System.Drawing.Size(357, 168);
            this.CmdStop.TabIndex = 13;
            this.CmdStop.Text = "Stop!";
            this.CmdStop.UseVisualStyleBackColor = true;
            this.CmdStop.Click += new System.EventHandler(this.CmdStop_Click);
            // 
            // TimHakenAbsenken
            // 
            this.TimHakenAbsenken.Tick += new System.EventHandler(this.TimHakenAbsenken_Tick);
            // 
            // TimKranNachLinks
            // 
            this.TimKranNachLinks.Tick += new System.EventHandler(this.TimKranNachLinks_Tick);
            // 
            // TimKranNachRechts
            // 
            this.TimKranNachRechts.Tick += new System.EventHandler(this.TimKranNachRechts_Tick);
            // 
            // TimAuslegerNachRechts
            // 
            this.TimAuslegerNachRechts.Tick += new System.EventHandler(this.TimAuslegerNachRechts_Tick);
            // 
            // TimAuslegerNachLinks
            // 
            this.TimAuslegerNachLinks.Tick += new System.EventHandler(this.TimAuslegerNachLinks_Tick);
            // 
            // FrmKran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 647);
            this.Controls.Add(this.CmdStop);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.CmdKranNachRechts);
            this.Controls.Add(this.CmdAusleger);
            this.Controls.Add(this.CmdAuslegerNachRechts);
            this.Controls.Add(this.CmdHakenNachOben);
            this.Controls.Add(this.CmdHakenNachUnten);
            this.Controls.Add(this.CmdKranNachLinks);
            this.Controls.Add(this.pHaken);
            this.Controls.Add(this.pSenkrecht);
            this.Controls.Add(this.pFundament);
            this.Controls.Add(this.pWaagrecht);
            this.Name = "FrmKran";
            this.Text = "Kran";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pFundament;
        private System.Windows.Forms.Panel pSenkrecht;
        private System.Windows.Forms.Panel pWaagrecht;
        private System.Windows.Forms.Panel pHaken;
        private System.Windows.Forms.Button CmdKranNachLinks;
        private System.Windows.Forms.Button CmdHakenNachUnten;
        private System.Windows.Forms.Button CmdHakenNachOben;
        private System.Windows.Forms.Button CmdAuslegerNachRechts;
        private System.Windows.Forms.Button CmdAusleger;
        private System.Windows.Forms.Button CmdKranNachRechts;
        private System.Windows.Forms.Button CmdEnde;
        private System.Windows.Forms.Timer TimHakenAnheben;
        private System.Windows.Forms.Button CmdStop;
        private System.Windows.Forms.Timer TimHakenAbsenken;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer TimKranNachLinks;
        private System.Windows.Forms.Timer TimKranNachRechts;
        private System.Windows.Forms.Timer TimAuslegerNachRechts;
        private System.Windows.Forms.Timer TimAuslegerNachLinks;
    }
}

