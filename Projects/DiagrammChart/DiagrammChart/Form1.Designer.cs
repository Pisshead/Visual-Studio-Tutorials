namespace DiagrammChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.CmdSpeichern = new System.Windows.Forms.Button();
            this.CmdDrucken = new System.Windows.Forms.Button();
            this.DChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.DChart)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdSpeichern
            // 
            this.CmdSpeichern.Location = new System.Drawing.Point(398, 47);
            this.CmdSpeichern.Margin = new System.Windows.Forms.Padding(2);
            this.CmdSpeichern.Name = "CmdSpeichern";
            this.CmdSpeichern.Size = new System.Drawing.Size(75, 23);
            this.CmdSpeichern.TabIndex = 8;
            this.CmdSpeichern.Text = "Speichern";
            this.CmdSpeichern.UseVisualStyleBackColor = true;
            this.CmdSpeichern.Click += new System.EventHandler(this.CmdSpeichern_Click);
            // 
            // CmdDrucken
            // 
            this.CmdDrucken.Location = new System.Drawing.Point(398, 11);
            this.CmdDrucken.Margin = new System.Windows.Forms.Padding(2);
            this.CmdDrucken.Name = "CmdDrucken";
            this.CmdDrucken.Size = new System.Drawing.Size(75, 23);
            this.CmdDrucken.TabIndex = 7;
            this.CmdDrucken.Text = "Drucken";
            this.CmdDrucken.UseVisualStyleBackColor = true;
            this.CmdDrucken.Click += new System.EventHandler(this.CmdDrucken_Click);
            // 
            // DChart
            // 
            chartArea3.Name = "ChartArea1";
            this.DChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.DChart.Legends.Add(legend3);
            this.DChart.Location = new System.Drawing.Point(12, 12);
            this.DChart.Name = "DChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.DChart.Series.Add(series3);
            this.DChart.Size = new System.Drawing.Size(352, 238);
            this.DChart.TabIndex = 9;
            this.DChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.DChart);
            this.Controls.Add(this.CmdSpeichern);
            this.Controls.Add(this.CmdDrucken);
            this.Name = "Form1";
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button CmdSpeichern;
        internal System.Windows.Forms.Button CmdDrucken;
        private System.Windows.Forms.DataVisualization.Charting.Chart DChart;
    }
}

