using System;
using System.Windows.Forms;

namespace RekursiverAufruf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdSchleife_Click(object sender, EventArgs e)
        {
            double x = 22;
            LblAnzeige.Text = "x: " + x + "\n";

            while (x > 0.1)
            {
                x = x / 2;
                LblAnzeige.Text += "x: " + x + "\n";
            }
        }

        private void CmdRekursion_Click(object sender, EventArgs e)
        {
            double x = 22;
            LblAnzeige.Text = "x: " + x + "\n";
            Halbieren(ref x);
            LblAnzeige.Text += "x: " + x + "\n";
        }

        private void Halbieren(ref double z)
        {
            z = z / 2;
            if (z > 0.1)
            {
                LblAnzeige.Text += "z: " + z + "\n";
                Halbieren(ref z);
            }
        }
    }
}
