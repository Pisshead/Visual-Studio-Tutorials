namespace DatenfeldDynamisch
{
    partial class FrmDatenfeldDynamisch
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
            this.CmdOriginal = new System.Windows.Forms.Button();
            this.CmdFeldNeu = new System.Windows.Forms.Button();
            this.CmdEnd = new System.Windows.Forms.Button();
            this.CmdFeldBestimmteGroesse = new System.Windows.Forms.Button();
            this.NumGroesse = new System.Windows.Forms.NumericUpDown();
            this.LstZahlen = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumGroesse)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdOriginal
            // 
            this.CmdOriginal.Location = new System.Drawing.Point(153, 16);
            this.CmdOriginal.Name = "CmdOriginal";
            this.CmdOriginal.Size = new System.Drawing.Size(117, 23);
            this.CmdOriginal.TabIndex = 0;
            this.CmdOriginal.Text = "Originales Feld";
            this.CmdOriginal.UseVisualStyleBackColor = true;
            this.CmdOriginal.Click += new System.EventHandler(this.CmdOriginal_Click);
            // 
            // CmdFeldNeu
            // 
            this.CmdFeldNeu.Location = new System.Drawing.Point(153, 46);
            this.CmdFeldNeu.Name = "CmdFeldNeu";
            this.CmdFeldNeu.Size = new System.Drawing.Size(117, 23);
            this.CmdFeldNeu.TabIndex = 1;
            this.CmdFeldNeu.Text = "Neues Feld";
            this.CmdFeldNeu.UseVisualStyleBackColor = true;
            this.CmdFeldNeu.Click += new System.EventHandler(this.CmdFeldNeu_Click);
            // 
            // CmdEnd
            // 
            this.CmdEnd.Location = new System.Drawing.Point(197, 226);
            this.CmdEnd.Name = "CmdEnd";
            this.CmdEnd.Size = new System.Drawing.Size(75, 23);
            this.CmdEnd.TabIndex = 2;
            this.CmdEnd.Text = "Ende";
            this.CmdEnd.UseVisualStyleBackColor = true;
            this.CmdEnd.Click += new System.EventHandler(this.CmdEnd_Click);
            // 
            // CmdFeldBestimmteGroesse
            // 
            this.CmdFeldBestimmteGroesse.Location = new System.Drawing.Point(153, 117);
            this.CmdFeldBestimmteGroesse.Name = "CmdFeldBestimmteGroesse";
            this.CmdFeldBestimmteGroesse.Size = new System.Drawing.Size(117, 44);
            this.CmdFeldBestimmteGroesse.TabIndex = 3;
            this.CmdFeldBestimmteGroesse.Text = "Neues Feld mit angegebener Grösse";
            this.CmdFeldBestimmteGroesse.UseVisualStyleBackColor = true;
            this.CmdFeldBestimmteGroesse.Click += new System.EventHandler(this.CmdFeldBestimmteGroesse_Click);
            // 
            // NumGroesse
            // 
            this.NumGroesse.Location = new System.Drawing.Point(153, 94);
            this.NumGroesse.Name = "NumGroesse";
            this.NumGroesse.Size = new System.Drawing.Size(117, 20);
            this.NumGroesse.TabIndex = 4;
            // 
            // LstZahlen
            // 
            this.LstZahlen.FormattingEnabled = true;
            this.LstZahlen.Location = new System.Drawing.Point(13, 13);
            this.LstZahlen.Name = "LstZahlen";
            this.LstZahlen.Size = new System.Drawing.Size(92, 238);
            this.LstZahlen.TabIndex = 5;
            // 
            // FrmDatenfeldDynamisch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 261);
            this.Controls.Add(this.LstZahlen);
            this.Controls.Add(this.NumGroesse);
            this.Controls.Add(this.CmdFeldBestimmteGroesse);
            this.Controls.Add(this.CmdEnd);
            this.Controls.Add(this.CmdFeldNeu);
            this.Controls.Add(this.CmdOriginal);
            this.Name = "FrmDatenfeldDynamisch";
            this.Text = "Dynamisches Datenfeld";
            ((System.ComponentModel.ISupportInitialize)(this.NumGroesse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdOriginal;
        private System.Windows.Forms.Button CmdFeldNeu;
        private System.Windows.Forms.Button CmdEnd;
        private System.Windows.Forms.Button CmdFeldBestimmteGroesse;
        private System.Windows.Forms.NumericUpDown NumGroesse;
        private System.Windows.Forms.ListBox LstZahlen;
    }
}

