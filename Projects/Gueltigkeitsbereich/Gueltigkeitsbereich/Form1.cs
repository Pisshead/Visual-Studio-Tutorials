using System;
using System.Windows.Forms;

namespace Gueltigkeitsbereich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Mx = 0;

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int x = 0;
            Mx = Mx + 1;
            x = x + 1;
            LblAnzeige.Text = "x: " + x + "  Mx: " + Mx;
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            int Mx = 0;
            Mx = Mx + 1;
            LblAnzeige.Text = "Mx: " + Mx;
        }
    }
}
