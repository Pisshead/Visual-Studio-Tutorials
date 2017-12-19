namespace XmlDatei
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
            this.CmdObjekteAus = new System.Windows.Forms.Button();
            this.CmdObjekteIn = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdLesen = new System.Windows.Forms.Button();
            this.CmdSchreiben = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdObjekteAus
            // 
            this.CmdObjekteAus.Location = new System.Drawing.Point(224, 128);
            this.CmdObjekteAus.Margin = new System.Windows.Forms.Padding(2);
            this.CmdObjekteAus.Name = "CmdObjekteAus";
            this.CmdObjekteAus.Size = new System.Drawing.Size(150, 24);
            this.CmdObjekteAus.TabIndex = 19;
            this.CmdObjekteAus.Text = "Objekte aus XML-Datei";
            this.CmdObjekteAus.UseVisualStyleBackColor = true;
            this.CmdObjekteAus.Click += new System.EventHandler(this.CmdObjekteAus_Click);
            // 
            // CmdObjekteIn
            // 
            this.CmdObjekteIn.Location = new System.Drawing.Point(224, 99);
            this.CmdObjekteIn.Margin = new System.Windows.Forms.Padding(2);
            this.CmdObjekteIn.Name = "CmdObjekteIn";
            this.CmdObjekteIn.Size = new System.Drawing.Size(150, 24);
            this.CmdObjekteIn.TabIndex = 18;
            this.CmdObjekteIn.Text = "Objekte in XML-Datei";
            this.CmdObjekteIn.UseVisualStyleBackColor = true;
            this.CmdObjekteIn.Click += new System.EventHandler(this.CmdObjekteIn_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(11, 9);
            this.LblAnzeige.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige.TabIndex = 17;
            this.LblAnzeige.Text = "(leer)";
            // 
            // CmdLesen
            // 
            this.CmdLesen.Location = new System.Drawing.Point(224, 41);
            this.CmdLesen.Margin = new System.Windows.Forms.Padding(2);
            this.CmdLesen.Name = "CmdLesen";
            this.CmdLesen.Size = new System.Drawing.Size(150, 24);
            this.CmdLesen.TabIndex = 16;
            this.CmdLesen.Text = "XML-Datei lesen";
            this.CmdLesen.UseVisualStyleBackColor = true;
            this.CmdLesen.Click += new System.EventHandler(this.CmdLesen_Click);
            // 
            // CmdSchreiben
            // 
            this.CmdSchreiben.Location = new System.Drawing.Point(224, 12);
            this.CmdSchreiben.Margin = new System.Windows.Forms.Padding(2);
            this.CmdSchreiben.Name = "CmdSchreiben";
            this.CmdSchreiben.Size = new System.Drawing.Size(150, 24);
            this.CmdSchreiben.TabIndex = 15;
            this.CmdSchreiben.Text = "XML-Datei schreiben";
            this.CmdSchreiben.UseVisualStyleBackColor = true;
            this.CmdSchreiben.Click += new System.EventHandler(this.CmdSchreiben_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 291);
            this.Controls.Add(this.CmdObjekteAus);
            this.Controls.Add(this.CmdObjekteIn);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdLesen);
            this.Controls.Add(this.CmdSchreiben);
            this.Name = "Form1";
            this.Text = "XML-Dateien";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button CmdObjekteAus;
        internal System.Windows.Forms.Button CmdObjekteIn;
        internal System.Windows.Forms.Label LblAnzeige;
        internal System.Windows.Forms.Button CmdLesen;
        internal System.Windows.Forms.Button CmdSchreiben;
    }
}

