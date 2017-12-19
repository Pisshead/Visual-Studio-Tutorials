using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MehrereEreignisse
{
    public partial class FrmMehrereEreignisse : Form
    {
        public FrmMehrereEreignisse()
        {
            InitializeComponent();
        }

        private void OptChecked_CheckedChanged(object sender, EventArgs e)
        {


            if (OptRot.Checked)
            {

                LblAnzeige.Text = "Rot";

            }
            else if(OptGruen.Checked)
            {

                LblAnzeige.Text = "Grün";

            }
            else if(OptBlau.Checked)
            {

                LblAnzeige.Text = "Blau";
            }

        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
