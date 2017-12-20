using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArgumenteOptional
{
    public partial class FrmAddieren : Form
    {
        public FrmAddieren()
        {
            InitializeComponent();
        }

        private void Cmd2Argumente_Click(object sender, EventArgs e)
        {
            double a = 4.5, c = 10.3;
            int b = 7, d = 9;
            LblAnzeige.Text = "Ergebnis: " + Addiere(a, b, c, d);
        }

        private void Cmd3Argumente_Click(object sender, EventArgs e)
        {

            double a = 4.5, c = 10.3;
            int b = 7;
            LblAnzeige.Text = "Ergebnis: " + Addiere(a, b, c);

        }

        private void Cmd4Argumente_Click(object sender, EventArgs e)
        {


            double a = 4.5;
            int b = 7;
            LblAnzeige.Text = "Ergebnis: " + Addiere(a, b);

        }

        private double Addiere(double x, int y, double z = 0, int q = 0)
        {

            return x + y + z + q;

        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
