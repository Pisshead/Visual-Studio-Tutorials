using System;
using System.Windows.Forms;

namespace MethodenUebergabe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdKopie_Click(object sender, EventArgs e)
        {
            int x, y;
            x = 5;
            y = 12;
            LblAnzeige.Text = "Vorher: x: " + x + ", y: " + y;
            TauscheKopie(x, y);
            LblAnzeige.Text += "\nNachher: x: " + x + ", y: " + y;
        }

        private void TauscheKopie(int a, int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
        }

        private void CmdReferenz_Click(object sender, EventArgs e)
        {
            int x, y;
            x = 5;
            y = 12;
            LblAnzeige.Text = "Vorher: x: " + x + ", y: " + y;
            TauscheReferenz(ref x, ref y);
            LblAnzeige.Text += "\nNachher: x: " + x + ", y: " + y;
        }

        private void TauscheReferenz(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
        }

        private void CmdEinDimFeld_Click(object sender, EventArgs e)
        {
            int[] p = { 6, 7, 2 };

            Verdoppeln(p);
            LblAnzeige.Text = "";
            foreach (int z in p)
                LblAnzeige.Text += z + " ";
        }

        private void Verdoppeln(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
                x[i] = x[i] * 2;
        }

        private void CmdDreiDimFeld_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            double[,,] x = new double[2, 5, 3];
            for (int i = 0; i <= x.GetUpperBound(0); i++)
                for (int j = 0; j <= x.GetUpperBound(1); j++)
                    for (int k = 0; k <= x.GetUpperBound(2); k++)
                        x[i, j, k] = r.NextDouble();
            Mittelwert(x);
        }

        private void Mittelwert(double[,,] z)
        {
            double summe = 0;
            for (int i = 0; i <= z.GetUpperBound(0); i++)
                for (int j = 0; j <= z.GetUpperBound(1); j++)
                    for (int k = 0; k <= z.GetUpperBound(2); k++)
                        summe += z[i, j, k];
            LblAnzeige.Text = "Mittelwert: " + summe / z.Length;
        }

        private void CmdOut_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = 12;
            b = 3;
            Addieren(a, b, out c);
            LblAnzeige.Text = "Ergebnis: " + c;
        }

        private void Addieren(int x, int y, out int z)
        {
            z = x + y;
        }
    }
}
