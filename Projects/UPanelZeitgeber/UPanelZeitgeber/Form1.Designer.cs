namespace UPanelZeitgeber
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
            this.components = new System.ComponentModel.Container();
            this.CmdStart = new System.Windows.Forms.Button();
            this.Pan1 = new System.Windows.Forms.Panel();
            this.Pan2 = new System.Windows.Forms.Panel();
            this.Pan3 = new System.Windows.Forms.Panel();
            this.Pan4 = new System.Windows.Forms.Panel();
            this.TimBewegung = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(101, 12);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(75, 23);
            this.CmdStart.TabIndex = 0;
            this.CmdStart.Text = "Start";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // Pan1
            // 
            this.Pan1.BackColor = System.Drawing.Color.Gray;
            this.Pan1.Location = new System.Drawing.Point(114, 103);
            this.Pan1.Name = "Pan1";
            this.Pan1.Size = new System.Drawing.Size(20, 20);
            this.Pan1.TabIndex = 1;
            // 
            // Pan2
            // 
            this.Pan2.BackColor = System.Drawing.Color.Gray;
            this.Pan2.Location = new System.Drawing.Point(140, 103);
            this.Pan2.Name = "Pan2";
            this.Pan2.Size = new System.Drawing.Size(20, 20);
            this.Pan2.TabIndex = 2;
            // 
            // Pan3
            // 
            this.Pan3.BackColor = System.Drawing.Color.Gray;
            this.Pan3.Location = new System.Drawing.Point(114, 129);
            this.Pan3.Name = "Pan3";
            this.Pan3.Size = new System.Drawing.Size(20, 20);
            this.Pan3.TabIndex = 2;
            // 
            // Pan4
            // 
            this.Pan4.BackColor = System.Drawing.Color.Gray;
            this.Pan4.Location = new System.Drawing.Point(140, 129);
            this.Pan4.Name = "Pan4";
            this.Pan4.Size = new System.Drawing.Size(20, 20);
            this.Pan4.TabIndex = 2;
            // 
            // TimBewegung
            // 
            this.TimBewegung.Interval = 500;
            this.TimBewegung.Tick += new System.EventHandler(this.TimBewegung_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Pan4);
            this.Controls.Add(this.Pan3);
            this.Controls.Add(this.Pan2);
            this.Controls.Add(this.Pan1);
            this.Controls.Add(this.CmdStart);
            this.Name = "Form1";
            this.Text = "Panel, Zeitgeber";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.Panel Pan1;
        private System.Windows.Forms.Panel Pan2;
        private System.Windows.Forms.Panel Pan3;
        private System.Windows.Forms.Panel Pan4;
        private System.Windows.Forms.Timer TimBewegung;
    }
}

