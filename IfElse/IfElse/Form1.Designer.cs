namespace IfElse
{
    partial class FrmIfElse
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
            this.CmdIf = new System.Windows.Forms.Button();
            this.CmdElse = new System.Windows.Forms.Button();
            this.LblX = new System.Windows.Forms.Label();
            this.LblY = new System.Windows.Forms.Label();
            this.NumX = new System.Windows.Forms.NumericUpDown();
            this.NumY = new System.Windows.Forms.NumericUpDown();
            this.CmdEnde = new System.Windows.Forms.Button();
            this.LblAnzeige = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumY)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdIf
            // 
            this.CmdIf.Location = new System.Drawing.Point(13, 76);
            this.CmdIf.Name = "CmdIf";
            this.CmdIf.Size = new System.Drawing.Size(75, 23);
            this.CmdIf.TabIndex = 0;
            this.CmdIf.Text = "If";
            this.CmdIf.UseVisualStyleBackColor = true;
            this.CmdIf.Click += new System.EventHandler(this.CmdIf_Click);
            // 
            // CmdElse
            // 
            this.CmdElse.Location = new System.Drawing.Point(13, 121);
            this.CmdElse.Name = "CmdElse";
            this.CmdElse.Size = new System.Drawing.Size(75, 23);
            this.CmdElse.TabIndex = 1;
            this.CmdElse.Text = "Else";
            this.CmdElse.UseVisualStyleBackColor = true;
            // 
            // LblX
            // 
            this.LblX.AutoSize = true;
            this.LblX.Location = new System.Drawing.Point(131, 81);
            this.LblX.Name = "LblX";
            this.LblX.Size = new System.Drawing.Size(15, 13);
            this.LblX.TabIndex = 2;
            this.LblX.Text = "x:";
            // 
            // LblY
            // 
            this.LblY.AutoSize = true;
            this.LblY.Location = new System.Drawing.Point(131, 126);
            this.LblY.Name = "LblY";
            this.LblY.Size = new System.Drawing.Size(15, 13);
            this.LblY.TabIndex = 3;
            this.LblY.Text = "y:";
            // 
            // NumX
            // 
            this.NumX.Location = new System.Drawing.Point(175, 79);
            this.NumX.Name = "NumX";
            this.NumX.Size = new System.Drawing.Size(120, 20);
            this.NumX.TabIndex = 4;
            // 
            // NumY
            // 
            this.NumY.Location = new System.Drawing.Point(175, 124);
            this.NumY.Name = "NumY";
            this.NumY.Size = new System.Drawing.Size(120, 20);
            this.NumY.TabIndex = 5;
            // 
            // CmdEnde
            // 
            this.CmdEnde.Location = new System.Drawing.Point(13, 166);
            this.CmdEnde.Name = "CmdEnde";
            this.CmdEnde.Size = new System.Drawing.Size(75, 23);
            this.CmdEnde.TabIndex = 6;
            this.CmdEnde.Text = "Ende";
            this.CmdEnde.UseVisualStyleBackColor = true;
            this.CmdEnde.Click += new System.EventHandler(this.CmdEnde_Click);
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(175, 166);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(0, 13);
            this.LblAnzeige.TabIndex = 7;
            // 
            // FrmIfElse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 218);
            this.Controls.Add(this.LblAnzeige);
            this.Controls.Add(this.CmdEnde);
            this.Controls.Add(this.NumY);
            this.Controls.Add(this.NumX);
            this.Controls.Add(this.LblY);
            this.Controls.Add(this.LblX);
            this.Controls.Add(this.CmdElse);
            this.Controls.Add(this.CmdIf);
            this.Name = "FrmIfElse";
            this.Text = "If Then Else";
            ((System.ComponentModel.ISupportInitialize)(this.NumX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdIf;
        private System.Windows.Forms.Button CmdElse;
        private System.Windows.Forms.Label LblX;
        private System.Windows.Forms.Label LblY;
        private System.Windows.Forms.NumericUpDown NumX;
        private System.Windows.Forms.NumericUpDown NumY;
        private System.Windows.Forms.Button CmdEnde;
        private System.Windows.Forms.Label LblAnzeige;
    }
}

