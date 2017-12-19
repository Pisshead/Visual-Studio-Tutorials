using System;
using System.Windows.Forms;

namespace UMethoden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdMittelwert1_Click(object sender, EventArgs e)
        {
            double[] a = { 3, 9.3, -7.2 };
            LblAnzeige1.Text = "Ergebnis: " + Mittelwert(a);
        }

        private void CmdMittelwert2_Click(object sender, EventArgs e)
        {
            double[] b = { -5, 6.2, 8.5, -5, 9 };
            LblAnzeige2.Text = "Ergebnis: " + Mittelwert(b);
        }

        private double Mittelwert(double[] x)
        {
            double summe = 0, wert;
            if (x.Length == 0)
                return 0;
            foreach (int z in x)
                summe += z;
            wert = summe / x.Length;
            return wert;
        }

        private void CmdFelder_Click(object sender, EventArgs e)
        {
            double[] a = { 5.1, 6.1, 7.1 };
            double[] b = { 12.8, 13.8, 14.8, 15.8, 16.8 };
            double[] c;

            Vereinigen(a, b, out c);
            LblAnzeige1.Text = "";
            foreach (double z in c)
                LblAnzeige1.Text += z + " ";

            Vereinigen(b, a, out c);
            LblAnzeige2.Text = "";
            foreach (double z in c)
                LblAnzeige2.Text += z + " ";
        }

        private void Vereinigen(double[] x, double[] y, out double[] z)
        {
            z = new double[x.Length + y.Length];

            for (int i = 0; i < x.Length; i++)
                z[i] = x[i];
            for (int i = 0; i < y.Length; i++)
                z[i + x.Length] = y[i];
        }
    }
}
