using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace DiagrammChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DChart.Series.Clear();

            DChart.Series.Add(new Series("Umsatz Berlin"));
            DChart.Series[0].Points.AddXY(2013, 10);
            DChart.Series[0].Points.AddXY(2015, 30);
            DChart.Series[0].Points.AddXY(2017, 70);
            DChart.Series[0].Color = Color.Black;
            DChart.Series[0].BorderWidth = 3;
            DChart.Series[0].ChartType = SeriesChartType.Line;

            DChart.Series.Add(new Series("Umsatz Hamburg"));
            DChart.Series[1].Points.AddXY(2013, 25);
            DChart.Series[1].Points.AddXY(2015, 20);
            DChart.Series[1].Points.AddXY(2017, 100);
            DChart.Series[1].Color = Color.Gray;
            DChart.Series[1].BorderWidth = 3;
            DChart.Series[1].ChartType = SeriesChartType.Line;

            DChart.Legends[0].Position =
                new ElementPosition(25, 10, 40, 20);
            DChart.Legends[0].BackColor = Color.LightGray;
            DChart.Legends[0].BorderWidth = 1;
            DChart.Legends[0].BorderColor = Color.Black;

            DChart.ChartAreas[0].AxisX.Minimum = 2013;
            DChart.ChartAreas[0].AxisX.Maximum = 2017;
            DChart.ChartAreas[0].AxisX.Title = "Jahr";
            DChart.ChartAreas[0].AxisX.TitleAlignment =
                StringAlignment.Near;
            DChart.ChartAreas[0].AxisX.LabelStyle.Font =
                new Font("Arial", 8);

            DChart.ChartAreas[0].AxisY.Maximum = 120;
            DChart.ChartAreas[0].AxisY.Title = "1.000 Euro";
            DChart.ChartAreas[0].AxisY.TitleAlignment =
                StringAlignment.Far;
            DChart.ChartAreas[0].AxisY.LabelStyle.Font =
                new Font("Arial", 8);

            DChart.BackColor = Color.LightGray;
            DChart.ChartAreas[0].BackColor = Color.LightBlue;
        }

        private void CmdDrucken_Click(object sender, EventArgs e)
        {
            DChart.Printing.PrintPreview();
        }

        private void CmdSpeichern_Click(object sender, EventArgs e)
        {
            string VollerName = "C:\\Temp\\DiagrammChart.png";
            DChart.SaveImage(VollerName, ChartImageFormat.Png);
            MessageBox.Show("Es wurde die Bilddatei " + VollerName +
                " erzeugt");
        }
    }
}
