using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechenoperatoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {

            double x = 3 * -2.5 + 4 * 2;
            double y = 3 * (-2.5 + 4) * 2;
            LblAnzeigen.Text = "Ergebnis x: " + x + "\n" + "Ergebnis y: " + y;


        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {


            bool x = 12-3 >= 4*2.5;
            bool y = "Maier" != "Mayer";
            LblAnzeigen.Text = "Ergebnis: " + x;
            LblAnzeigen2.Text = "Ergebnis: " + y;

        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {

            int n1 = 1;
            int n2 = 17;
            bool z = n1 > 0 && n2 > 0 || n1 > n2 && n2 != 17;

            LblAnzeigen.Text = "Ergebnis z: " + z;


        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {

            Close();


        }
    }
}
