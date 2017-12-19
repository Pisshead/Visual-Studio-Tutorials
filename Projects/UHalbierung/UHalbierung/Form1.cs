using System;
using System.Windows.Forms;

namespace UHalbierung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            double d = Convert.ToDouble(TxtEingabe.Text);

            LblAnzeige.Text = "";
            while(d >= 0.001)
            {
                d = d / 2;
                LblAnzeige.Text += d + "\n";
            }
        }
    }
}
