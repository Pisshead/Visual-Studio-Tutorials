using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textfelder
{
    public partial class FrmTextfelder : Form
    {
        public FrmTextfelder()
        {
            InitializeComponent();
        }

        private void CmdAusgabe_Click(object sender, EventArgs e)
        {

            LblAusgabe.Text = "Sie haben '" + TxtEingabe.Text + "' eingegeben.";

        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
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
