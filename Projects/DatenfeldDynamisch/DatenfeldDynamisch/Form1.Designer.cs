namespace DatenfeldDynamisch
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
            this.NumGroesse = new System.Windows.Forms.NumericUpDown();
            this.CmdNeu2 = new System.Windows.Forms.Button();
            this.CmdOriginal = new System.Windows.Forms.Button();
            this.LstFeld = new System.Windows.Forms.ListBox();
            this.CmdNeu1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumGroesse)).BeginInit();
            this.SuspendLayout();
            // 
            // NumGroesse
            // 
            this.NumGroesse.Location = new System.Drawing.Point(197, 99);
            this.NumGroesse.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumGroesse.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumGroesse.Name = "NumGroesse";
            this.NumGroesse.Size = new System.Drawing.Size(75, 20);
            this.NumGroesse.TabIndex = 31;
            this.NumGroesse.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // CmdNeu2
            // 
            this.CmdNeu2.Location = new System.Drawing.Point(197, 125);
            this.CmdNeu2.Name = "CmdNeu2";
            this.CmdNeu2.Size = new System.Drawing.Size(75, 23);
            this.CmdNeu2.TabIndex = 30;
            this.CmdNeu2.Text = "Feld neu 2";
            this.CmdNeu2.UseVisualStyleBackColor = true;
            this.CmdNeu2.Click += new System.EventHandler(this.CmdNeu2_Click);
            // 
            // CmdOriginal
            // 
            this.CmdOriginal.Location = new System.Drawing.Point(197, 12);
            this.CmdOriginal.Name = "CmdOriginal";
            this.CmdOriginal.Size = new System.Drawing.Size(75, 23);
            this.CmdOriginal.TabIndex = 29;
            this.CmdOriginal.Text = "Feld original";
            this.CmdOriginal.UseVisualStyleBackColor = true;
            this.CmdOriginal.Click += new System.EventHandler(this.CmdOriginal_Click);
            // 
            // LstFeld
            // 
            this.LstFeld.FormattingEnabled = true;
            this.LstFeld.Location = new System.Drawing.Point(12, 12);
            this.LstFeld.Name = "LstFeld";
            this.LstFeld.Size = new System.Drawing.Size(109, 238);
            this.LstFeld.TabIndex = 28;
            // 
            // CmdNeu1
            // 
            this.CmdNeu1.Location = new System.Drawing.Point(197, 41);
            this.CmdNeu1.Name = "CmdNeu1";
            this.CmdNeu1.Size = new System.Drawing.Size(75, 23);
            this.CmdNeu1.TabIndex = 27;
            this.CmdNeu1.Text = "Feld neu 1";
            this.CmdNeu1.UseVisualStyleBackColor = true;
            this.CmdNeu1.Click += new System.EventHandler(this.CmdNeu1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.NumGroesse);
            this.Controls.Add(this.CmdNeu2);
            this.Controls.Add(this.CmdOriginal);
            this.Controls.Add(this.LstFeld);
            this.Controls.Add(this.CmdNeu1);
            this.Name = "Form1";
            this.Text = "Datenfeld, dynamisch";
            ((System.ComponentModel.ISupportInitialize)(this.NumGroesse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumGroesse;
        internal System.Windows.Forms.Button CmdNeu2;
        internal System.Windows.Forms.Button CmdOriginal;
        internal System.Windows.Forms.ListBox LstFeld;
        internal System.Windows.Forms.Button CmdNeu1;
    }
}

