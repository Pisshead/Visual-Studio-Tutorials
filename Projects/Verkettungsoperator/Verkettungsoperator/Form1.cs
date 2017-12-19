using System;
using System.Windows.Forms;

namespace Verkettungsoperator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {
            string a, b;
            double d;
            int x;

            b = "Hallo";
            d = 4.6;
            x = -5;
            a = b + " Welt " + d + " " + x + " " + 12;
            LblAnzeige.Text = a;
            // lblAnzeige.Text = x;
        }
    }
}
