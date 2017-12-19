namespace IfElse
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
            this.LblAnzeige = new System.Windows.Forms.Label();
            this.LblX = new System.Windows.Forms.Label();
            this.LblY = new System.Windows.Forms.Label();
            this.CmdAnzeige1 = new System.Windows.Forms.Button();
            this.CmdAnzeige2 = new System.Windows.Forms.Button();
            this.CmdAnzeige3 = new System.Windows.Forms.Button();
            this.CmdAnzeige4 = new System.Windows.Forms.Button();
            this.CmdAnzeige5 = new System.Windows.Forms.Button();
            this.CmdAnzeige6 = new System.Windows.Forms.Button();
            this.CmdAnzeige7 = new System.Windows.Forms.Button();
            this.NumX = new System.Windows.Forms.NumericUpDown();
            this.NumY = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumY)).BeginInit();
            this.SuspendLayout();
            // 
            // LblAnzeige
            // 
            this.LblAnzeige.AutoSize = true;
            this.LblAnzeige.Location = new System.Drawing.Point(23, 19);
            this.LblAnzeige.Name = "LblAnzeige";
            this.LblAnzeige.Size = new System.Drawing.Size(30, 13);
            this.LblAnzeige.TabIndex = 0;
            this.LblAnzeige.Text = "(leer)";
            // 
            // LblX
            // 
            this.LblX.AutoSize = true;
            this.LblX.Location = new System.Drawing.Point(142, 57);
            this.LblX.Name = "LblX";
            this.LblX.Size = new System.Drawing.Size(15, 13);
            this.LblX.TabIndex = 1;
            this.LblX.Text = "x:";
            // 
            // LblY
            // 
            this.LblY.AutoSize = true;
            this.LblY.Location = new System.Drawing.Point(142, 83);
            this.LblY.Name = "LblY";
            this.LblY.Size = new System.Drawing.Size(15, 13);
            this.LblY.TabIndex = 2;
            this.LblY.Text = "y:";
            // 
            // CmdAnzeige1
            // 
            this.CmdAnzeige1.Location = new System.Drawing.Point(12, 52);
            this.CmdAnzeige1.Name = "CmdAnzeige1";
            this.CmdAnzeige1.Size = new System.Drawing.Size(100, 23);
            this.CmdAnzeige1.TabIndex = 3;
            this.CmdAnzeige1.Text = "if";
            this.CmdAnzeige1.UseVisualStyleBackColor = true;
            this.CmdAnzeige1.Click += new System.EventHandler(this.CmdAnzeige1_Click);
            // 
            // CmdAnzeige2
            // 
            this.CmdAnzeige2.Location = new System.Drawing.Point(11, 81);
            this.CmdAnzeige2.Name = "CmdAnzeige2";
            this.CmdAnzeige2.Size = new System.Drawing.Size(100, 23);
            this.CmdAnzeige2.TabIndex = 4;
            this.CmdAnzeige2.Text = "if else";
            this.CmdAnzeige2.UseVisualStyleBackColor = true;
            this.CmdAnzeige2.Click += new System.EventHandler(this.CmdAnzeige2_Click);
            // 
            // CmdAnzeige3
            // 
            this.CmdAnzeige3.Location = new System.Drawing.Point(11, 110);
            this.CmdAnzeige3.Name = "CmdAnzeige3";
            this.CmdAnzeige3.Size = new System.Drawing.Size(100, 23);
            this.CmdAnzeige3.TabIndex = 5;
            this.CmdAnzeige3.Text = "Ternärer Operator";
            this.CmdAnzeige3.UseVisualStyleBackColor = true;
            this.CmdAnzeige3.Click += new System.EventHandler(this.CmdAnzeige3_Click);
            // 
            // CmdAnzeige4
            // 
            this.CmdAnzeige4.Location = new System.Drawing.Point(12, 139);
            this.CmdAnzeige4.Name = "CmdAnzeige4";
            this.CmdAnzeige4.Size = new System.Drawing.Size(100, 23);
            this.CmdAnzeige4.TabIndex = 6;
            this.CmdAnzeige4.Text = "if else if";
            this.CmdAnzeige4.UseVisualStyleBackColor = true;
            this.CmdAnzeige4.Click += new System.EventHandler(this.CmdAnzeige4_Click);
            // 
            // CmdAnzeige5
            // 
            this.CmdAnzeige5.Location = new System.Drawing.Point(11, 168);
            this.CmdAnzeige5.Name = "CmdAnzeige5";
            this.CmdAnzeige5.Size = new System.Drawing.Size(100, 23);
            this.CmdAnzeige5.TabIndex = 7;
            this.CmdAnzeige5.Text = "logisches Und";
            this.CmdAnzeige5.UseVisualStyleBackColor = true;
            this.CmdAnzeige5.Click += new System.EventHandler(this.CmdAnzeige5_Click);
            // 
            // CmdAnzeige6
            // 
            this.CmdAnzeige6.Location = new System.Drawing.Point(11, 197);
            this.CmdAnzeige6.Name = "CmdAnzeige6";
            this.CmdAnzeige6.Size = new System.Drawing.Size(100, 23);
            this.CmdAnzeige6.TabIndex = 8;
            this.CmdAnzeige6.Text = "logisches Oder";
            this.CmdAnzeige6.UseVisualStyleBackColor = true;
            this.CmdAnzeige6.Click += new System.EventHandler(this.CmdAnzeige6_Click);
            // 
            // CmdAnzeige7
            // 
            this.CmdAnzeige7.Location = new System.Drawing.Point(11, 226);
            this.CmdAnzeige7.Name = "CmdAnzeige7";
            this.CmdAnzeige7.Size = new System.Drawing.Size(100, 23);
            this.CmdAnzeige7.TabIndex = 9;
            this.CmdAnzeige7.Text = "log. Exklusiv Oder";
            this.CmdAnzeige7.UseVisualStyleBackColor = true;
            this.CmdAnzeige7.Click += new System.EventHandler(this.CmdAnzeige7_Click);
            // 
            // NumX
            // 
            this.NumX.Location = new System.Drawing.Point(192, 55);
            this.NumX.Name = "NumX";
            this.NumX.Size = new System.Drawing.Size(80, 20);
            this.NumX.TabIndex = 10;
            // 
            // NumY
            // 
            this.NumY.Location = new System.Drawing.Point(192, 81);
            this.NumY.Name = "NumY";
            this.NumY.Size = new System.Drawing.Size(80, 20);
            this.NumY.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.NumY);
            this.Controls.Add(this.NumX);
            this.Controls.Add(this.CmdAnzeige7);
            this.Controls.Add(this.CmdAnzeige6);
            this.Controls.Add(this.CmdAnzeige5);
            this.Controls.Add(this.CmdAnzeige4);
            this.Controls.Add(this.CmdAnzeige3);
            this.Controls.Add(this.CmdAnzeige2);
            this.Controls.Add(this.CmdAnzeige1);
            this.Controls.Add(this.LblY);
            this.Controls.Add(this.LblX);
            this.Controls.Add(this.LblAnzeige);
            this.Name = "Form1";
            this.Text = "if else";
            ((System.ComponentModel.ISupportInitialize)(this.NumX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAnzeige;
        private System.Windows.Forms.Label LblX;
        private System.Windows.Forms.Label LblY;
        private System.Windows.Forms.Button CmdAnzeige1;
        private System.Windows.Forms.Button CmdAnzeige2;
        private System.Windows.Forms.Button CmdAnzeige3;
        private System.Windows.Forms.Button CmdAnzeige4;
        private System.Windows.Forms.Button CmdAnzeige5;
        private System.Windows.Forms.Button CmdAnzeige6;
        private System.Windows.Forms.Button CmdAnzeige7;
        private System.Windows.Forms.NumericUpDown NumX;
        private System.Windows.Forms.NumericUpDown NumY;
    }
}

