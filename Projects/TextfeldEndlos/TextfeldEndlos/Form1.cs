using System;
using System.Windows.Forms;

namespace TextfeldEndlos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int x = 0;

        private void TxtEingabe1_TextChanged(object sender, EventArgs e)
        {
            TxtEingabe2_TextChanged(sender, e);
        }

        private void TxtEingabe2_TextChanged(object sender, EventArgs e)
        {
            x++;
            if (x < 1000)
                TxtEingabe1_TextChanged(sender, e);
            else
                LblAnzeige.Text = "" + x;
        }
    }
}
