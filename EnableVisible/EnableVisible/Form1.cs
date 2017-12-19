using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnableVisible
{
    public partial class FrmEnableVisible : Form
    {
        public FrmEnableVisible()
        {
            InitializeComponent();
        }

        private void TxtEingabe_TextChanged(object sender, EventArgs e)
        {

            if (TxtZahl1.Text != "" && TxtZahl2.Text != "")
            {


                CmdRechnen1.Enabled = true;
                CmdRechnen2.Visible = true;

            }
            else
            {

                CmdRechnen2.Visible = false;
                CmdRechnen1.Enabled = false;
            }
        }

        private void CmdRechnen_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TxtZahl1.Text);
            int y = Convert.ToInt32(TxtZahl2.Text);
            int z = x + y;

            try
            {

                LblAusgabe.Text = "Ergebnis: " + z;

            }
            catch
            {
                LblAusgabe.Text = "0";


            }

        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
