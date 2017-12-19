using System;
using System.Windows.Forms;

namespace DatenfeldVerzweigt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random r = new Random();

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {
            double[][] a = new double[5][];
            int anz = 0;

            a[0] = new double[2];
            a[1] = new double[4];
            a[2] = new double[2];
            a[3] = new double[3];
            a[4] = new double[1];

            LblAnzeige.Text = "";
            for (int i = 0; i < a.Length; i++)
            {
                for (int k = 0; k < a[i].Length; k++)
                {
                    a[i][k] = Math.Round(r.NextDouble(), 3);
                    LblAnzeige.Text += a[i][k] + "  ";
                }
                anz += a[i].Length;
                LblAnzeige.Text += "\n";
            }

            LblAnzeige.Text += "Anzahl: " + anz;
        }
    }
}
