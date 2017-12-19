namespace ZahlenAufAb
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
            this.NumEingabe = new System.Windows.Forms.NumericUpDown();
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.CmdEnde = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumEingabe)).BeginInit();
            this.SuspendLayout();
            // 
            // NumEingabe
            // 
            this.NumEingabe.DecimalPlaces = 1;
            this.NumEingabe.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumEingabe.Location = new System.Drawing.Point(12, 12);
            this.NumEingabe.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            65536});
            this.NumEingabe.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            -2147418112});
            this.NumEingabe.Name = "NumEingabe";
            this.NumEingabe.Size = new System.Drawing.Size(120, 20);
            this.NumEingabe.TabIndex = 0;
            this.NumEingabe.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumEingabe.ValueChanged += new System.EventHandler(this.NumEingabe_ValueChanged);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(148, 12);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 1;
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(197, 226);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 2;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.NumEingabe);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumEingabe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumEingabe;
        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Button CmdEnde;
    }
}

