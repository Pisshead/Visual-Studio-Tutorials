namespace DatenfeldVerzweigt
{
    partial class FrmDatenfeldVerzweigt
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
            this.BtnAnzeigen = new System.Windows.Forms.Button();
            this.LblDatenfeld = new System.Windows.Forms.Label();
            this.LblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAnzeigen
            // 
            this.BtnAnzeigen.Location = new System.Drawing.Point(197, 13);
            this.BtnAnzeigen.Name = "BtnAnzeigen";
            this.BtnAnzeigen.Size = new System.Drawing.Size(75, 23);
            this.BtnAnzeigen.TabIndex = 0;
            this.BtnAnzeigen.Text = "Anzeigen";
            this.BtnAnzeigen.UseVisualStyleBackColor = true;
            this.BtnAnzeigen.Click += new System.EventHandler(this.BtnAnzeigen_Click);
            // 
            // LblDatenfeld
            // 
            this.LblDatenfeld.AutoSize = true;
            this.LblDatenfeld.Location = new System.Drawing.Point(34, 70);
            this.LblDatenfeld.Name = "LblDatenfeld";
            this.LblDatenfeld.Size = new System.Drawing.Size(0, 13);
            this.LblDatenfeld.TabIndex = 1;
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(37, 133);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(0, 13);
            this.LblInfo.TabIndex = 2;
            // 
            // FrmDatenfeldVerzweigt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LblInfo);
            this.Controls.Add(this.LblDatenfeld);
            this.Controls.Add(this.BtnAnzeigen);
            this.Name = "FrmDatenfeldVerzweigt";
            this.Text = "Verzweigtes Datenfeld";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAnzeigen;
        private System.Windows.Forms.Label LblDatenfeld;
        private System.Windows.Forms.Label LblInfo;
    }
}

