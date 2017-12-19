using System;
using System.Windows.Forms;

namespace UVergleichsoperatoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdVergleich1_Click(object sender, EventArgs e)
        {
            bool p;
            p = 12 - 3 >= 4 * 2.5;
            LblAnzeige.Text = "Ergebnis: " + p;
        }

        private void CmdVergleich2_Click(object sender, EventArgs e)
        {
            bool p;
            p = "Maier" != "Mayer";
            LblAnzeige.Text = "Ergebnis: " + p;
        }
    }
}
