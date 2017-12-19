using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontrollkaestchen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdPruefen_Click(object sender, EventArgs e)
        {


            if (ChkSchalter.Checked)
            {

                LblPruefung.Text = "An";



            }
            else {

                LblPruefung.Text = "Aus";

            }

        }

        private void ChkSchalter_CheckedChanged(object sender, EventArgs e)
        {


            if (ChkSchalter.Checked) {

                LblSchalter.Text = "An";


            }
            else
            {

                LblSchalter.Text = "Aus";

            }
        }

        private void CmdUmschalten_Click(object sender, EventArgs e)
        {


            ChkSchalter.Checked = !ChkSchalter.Checked;


        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
