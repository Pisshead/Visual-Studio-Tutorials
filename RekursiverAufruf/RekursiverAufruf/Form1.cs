using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekursiverAufruf
{
    public partial class FrmRekursiverAufruf : Form
    {
        public FrmRekursiverAufruf()
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

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
