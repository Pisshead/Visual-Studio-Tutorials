using System;
using System.Windows.Forms;

namespace UGueltigkeitsbereich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double x = 0.0;

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            double y = 0.0;
            y = y + 0.1;
            x = x + 0.1;
            LblAnzeige.Text = "x: " + x + "\n" + "y: " + y;
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            double z = 0.0;
            z = z + 0.1;
            x = x + 0.1;
            LblAnzeige.Text = "x: " + x + "\n" + "z: " + z;
        }
    }
}
