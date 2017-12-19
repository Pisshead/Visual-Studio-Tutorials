namespace ReferenzenVergleicheTypen
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
            this.CmdKlasseVergleichen = new System.Windows.Forms.Button();
            this.CmdKlasseErmitteln = new System.Windows.Forms.Button();
            this.CmdObjekteVergleichen = new System.Windows.Forms.Button();
            this.CmdReferenzenVergleichen = new System.Windows.Forms.Button();
            this.CmdReferenzZuweisen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdKlasseVergleichen
            // 
            this.CmdKlasseVergleichen.Location = new System.Drawing.Point(12, 129);
            this.CmdKlasseVergleichen.Name = "CmdKlasseVergleichen";
            this.CmdKlasseVergleichen.Size = new System.Drawing.Size(135, 23);
            this.CmdKlasseVergleichen.TabIndex = 31;
            this.CmdKlasseVergleichen.Text = "Klasse vergleichen";
            this.CmdKlasseVergleichen.UseVisualStyleBackColor = true;
            this.CmdKlasseVergleichen.Click += new System.EventHandler(this.CmdKlasseVergleichen_Click);
            // 
            // CmdKlasseErmitteln
            // 
            this.CmdKlasseErmitteln.Location = new System.Drawing.Point(12, 99);
            this.CmdKlasseErmitteln.Name = "CmdKlasseErmitteln";
            this.CmdKlasseErmitteln.Size = new System.Drawing.Size(135, 23);
            this.CmdKlasseErmitteln.TabIndex = 30;
            this.CmdKlasseErmitteln.Text = "Klasse ermitteln";
            this.CmdKlasseErmitteln.UseVisualStyleBackColor = true;
            this.CmdKlasseErmitteln.Click += new System.EventHandler(this.CmdKlasseErmitteln_Click);
            // 
            // CmdObjekteVergleichen
            // 
            this.CmdObjekteVergleichen.Location = new System.Drawing.Point(12, 70);
            this.CmdObjekteVergleichen.Name = "CmdObjekteVergleichen";
            this.CmdObjekteVergleichen.Size = new System.Drawing.Size(135, 23);
            this.CmdObjekteVergleichen.TabIndex = 29;
            this.CmdObjekteVergleichen.Text = "Objekte vergleichen";
            this.CmdObjekteVergleichen.UseVisualStyleBackColor = true;
            this.CmdObjekteVergleichen.Click += new System.EventHandler(this.CmdObjekteVergleichen_Click);
            // 
            // CmdReferenzenVergleichen
            // 
            this.CmdReferenzenVergleichen.Location = new System.Drawing.Point(12, 41);
            this.CmdReferenzenVergleichen.Name = "CmdReferenzenVergleichen";
            this.CmdReferenzenVergleichen.Size = new System.Drawing.Size(135, 23);
            this.CmdReferenzenVergleichen.TabIndex = 28;
            this.CmdReferenzenVergleichen.Text = "Referenzen vergleichen";
            this.CmdReferenzenVergleichen.UseVisualStyleBackColor = true;
            this.CmdReferenzenVergleichen.Click += new System.EventHandler(this.CmdReferenzenVergleichen_Click);
            // 
            // CmdReferenzZuweisen
            // 
            this.CmdReferenzZuweisen.Location = new System.Drawing.Point(12, 12);
            this.CmdReferenzZuweisen.Name = "CmdReferenzZuweisen";
            this.CmdReferenzZuweisen.Size = new System.Drawing.Size(135, 23);
            this.CmdReferenzZuweisen.TabIndex = 27;
            this.CmdReferenzZuweisen.Text = "Referenz zuweisen";
            this.CmdReferenzZuweisen.UseVisualStyleBackColor = true;
            this.CmdReferenzZuweisen.Click += new System.EventHandler(this.CmdReferenzZuweisen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 261);
            this.Controls.Add(this.CmdKlasseVergleichen);
            this.Controls.Add(this.CmdKlasseErmitteln);
            this.Controls.Add(this.CmdObjekteVergleichen);
            this.Controls.Add(this.CmdReferenzenVergleichen);
            this.Controls.Add(this.CmdReferenzZuweisen);
            this.Name = "Form1";
            this.Text = "Referenzen, Vergleiche, Typen";
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button CmdKlasseVergleichen;
        internal System.Windows.Forms.Button CmdKlasseErmitteln;
        internal System.Windows.Forms.Button CmdObjekteVergleichen;
        internal System.Windows.Forms.Button CmdReferenzenVergleichen;
        internal System.Windows.Forms.Button CmdReferenzZuweisen;
    }
}

