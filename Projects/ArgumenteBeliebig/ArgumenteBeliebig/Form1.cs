using System;
using System.Windows.Forms;

namespace ArgumenteBeliebig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            double a = 4.5, b = 7.2, c = 10.3, d = 9.2;
            LblAnzeige.Text = "Ergebnis: " + Mittelwert(a, b, c, d);
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double a = 4.5, b = 7.2;
            LblAnzeige.Text = "Ergebnis: " + Mittelwert(a, b);
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Ergebnis: " + Mittelwert();
        }

        private double Mittelwert(params double[] x)
        {
            double summe = 0;
            if (x.Length == 0)
                return 0;
            foreach (double z in x)
                summe += z;
            return summe / x.Length;
        }
    }
}
