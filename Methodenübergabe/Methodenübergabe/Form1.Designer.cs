namespace Methodenübergabe
{
    partial class FrmMethodenUebergabe
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
            this.CmdKopie = new System.Windows.Forms.Button();
            this.CmdTauschen = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.CmdEindimensionalesFeld = new System.Windows.Forms.Button();
            this.CmdDreidimensionalesFeld = new System.Windows.Forms.Button();
            this.CmdOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CmdKopie
            // 
            this.CmdKopie.Location = new System.Drawing.Point(168, 13);
            this.CmdKopie.Name = "CmdKopie";
            this.CmdKopie.Size = new System.Drawing.Size(101, 23);
            this.CmdKopie.TabIndex = 0;
            this.CmdKopie.Text = "Kopieren";
            this.CmdKopie.UseVisualStyleBackColor = true;
            this.CmdKopie.Click += new System.EventHandler(this.CmdKopie_Click);
            // 
            // CmdTauschen
            // 
            this.CmdTauschen.Location = new System.Drawing.Point(168, 43);
            this.CmdTauschen.Name = "CmdTauschen";
            this.CmdTauschen.Size = new System.Drawing.Size(101, 23);
            this.CmdTauschen.TabIndex = 1;
            this.CmdTauschen.Text = "Tauschen";
            this.CmdTauschen.UseVisualStyleBackColor = true;
            this.CmdTauschen.Click += new System.EventHandler(this.CmdTauschen_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(13, 13);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 2;
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(197, 226);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 3;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // CmdEindimensionalesFeld
            // 
            this.CmdEindimensionalesFeld.Location = new System.Drawing.Point(168, 73);
            this.CmdEindimensionalesFeld.Name = "CmdEindimensionalesFeld";
            this.CmdEindimensionalesFeld.Size = new System.Drawing.Size(101, 36);
            this.CmdEindimensionalesFeld.TabIndex = 4;
            this.CmdEindimensionalesFeld.Text = "Eindimensionales Feld";
            this.CmdEindimensionalesFeld.UseVisualStyleBackColor = true;
            this.CmdEindimensionalesFeld.Click += new System.EventHandler(this.CmdEindimensionalesFeld_Click);
            // 
            // CmdDreidimensionalesFeld
            // 
            this.CmdDreidimensionalesFeld.Location = new System.Drawing.Point(168, 116);
            this.CmdDreidimensionalesFeld.Name = "CmdDreidimensionalesFeld";
            this.CmdDreidimensionalesFeld.Size = new System.Drawing.Size(101, 38);
            this.CmdDreidimensionalesFeld.TabIndex = 5;
            this.CmdDreidimensionalesFeld.Text = "Dreidimensionales Feld";
            this.CmdDreidimensionalesFeld.UseVisualStyleBackColor = true;
            this.CmdDreidimensionalesFeld.Click += new System.EventHandler(this.CmdDreidimensionalesFeld_Click);
            // 
            // CmdOut
            // 
            this.CmdOut.Location = new System.Drawing.Point(168, 161);
            this.CmdOut.Name = "CmdOut";
            this.CmdOut.Size = new System.Drawing.Size(100, 23);
            this.CmdOut.TabIndex = 6;
            this.CmdOut.Text = "Out";
            this.CmdOut.UseVisualStyleBackColor = true;
            this.CmdOut.Click += new System.EventHandler(this.CmdOut_Click);
            // 
            // FrmMethodenUebergabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdOut);
            this.Controls.Add(this.CmdDreidimensionalesFeld);
            this.Controls.Add(this.CmdEindimensionalesFeld);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdTauschen);
            this.Controls.Add(this.CmdKopie);
            this.Name = "FrmMethodenUebergabe";
            this.Text = "Methodenübergabe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdKopie;
        private System.Windows.Forms.Button CmdTauschen;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdEnde;
        private System.Windows.Forms.Button CmdEindimensionalesFeld;
        private System.Windows.Forms.Button CmdDreidimensionalesFeld;
        private System.Windows.Forms.Button CmdOut;
    }
}

