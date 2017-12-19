using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optionen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdPruefen_Click(object sender, EventArgs e)
        {


            if (OptRot.Checked)
            {

                LblPruefung.Text = "Rot";

            }
            else if(OptGruen.Checked)
            {
                LblPruefung.Text = "Grün";


            }
            else
            {

                LblPruefung.Text = "Blau";

            }

        }

        private void OptRot_CheckedChanged(object sender, EventArgs e)
        {

            if (OptRot.Checked) {

                LblTest.Text = "Rot";


            }

        }

        private void OptGruen_CheckedChanged(object sender, EventArgs e)
        {

            if (OptGruen.Checked) {

                LblTest.Text = "Grün";

            }

        }

        private void OptBlau_CheckedChanged(object sender, EventArgs e)
        {

            if (OptBlau.Checked)
            {

                LblTest.Text = "Blau";


            }

        }

        private void CmdRotSchalten_Click(object sender, EventArgs e)
        {

            OptRot.Checked = true;

        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
