using System;
using System.Windows.Forms;

namespace Textfelder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAusgabe_Click(object sender, EventArgs e)
        {
            LblAusgabe.Text = "Sie haben '" + TxtEingabe.Text +
                "' eingegeben";
        }

        private void CmdRechnen_Click(object sender, EventArgs e)
        {
            double wert;
            wert = Convert.ToDouble(TxtEingabe.Text);
            wert = wert * 2;
            LblAusgabe.Text = "Ergebnis: " + wert;
        }
    }
}
