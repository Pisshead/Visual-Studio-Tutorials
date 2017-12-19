using System;
using System.Windows.Forms;

namespace Vergleichsoperatoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdVergleich1_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Ergebnis: " + (5 > 3);
        }

        private void CmdVergleich2_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Ergebnis: " + (3 == 3.2);
        }

        private void CmdVergleich3_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Ergebnis: " + (5 + 3 * 2 >= 12);
        }

        private void CmdVergleich4_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "Ergebnis: " + ("Maier" == "Mayer");
        }
    }
}
