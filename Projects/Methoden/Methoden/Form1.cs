using System;
using System.Windows.Forms;

namespace Methoden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeige1_Click(object sender, EventArgs e)
        {
            double a, b;
            a = 4.5;
            b = 7.2;
            ZeigeMaximum(a, b);
        }

        private void CmdAnzeige2_Click(object sender, EventArgs e)
        {
            double c, d;
            c = 23.9;
            d = 5.6;
            ZeigeMaximum(c, d);
        }

        private void ZeigeMaximum(double x, double y)
        {
            if (x > y)
                LblAnzeige.Text = "Maximum: " + x;
            else
                LblAnzeige.Text = "Maximum: " + y;
            return;             // nicht notwendig
        }
    }
}
