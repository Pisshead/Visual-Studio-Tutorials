using System;
using System.Windows.Forms;

namespace USteuerbetrag
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdBerechnen_Click(object sender, EventArgs e)
        {
            double gehalt, steuersatz, steuerbetrag;
            gehalt = Convert.ToDouble(TxtGehalt.Text);

            if (gehalt <= 12000)
                steuersatz = 12;
            else if (gehalt <= 20000)
                steuersatz = 15;
            else if (gehalt <= 30000)
                steuersatz = 20;
            else
                steuersatz = 25;

            steuerbetrag = gehalt * steuersatz / 100;
            LblSteuerbetrag.Text = "Steuerbetrag: " + steuerbetrag;
        }
    }
}
