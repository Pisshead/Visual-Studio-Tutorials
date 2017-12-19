using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextfeldKoppeln
{
    public partial class FrmTextfeldKoppeln : Form
    {
        private bool Kopplung;


        public FrmTextfeldKoppeln()
        {
            InitializeComponent();
        }

        private void Warning()
        {
            if(Kopplung == false && ChkTextfelderKoppeln.Checked == false)
            {
                LblWarning.Text = "Die Textfelder sind nicht gekoppelt.";

            }
            else
            {
                LblWarning.Text = "";
                
            }


        }

        private void FrmTextfeldKoppeln_Activated(object sender, EventArgs e)
        {
            TxtName.Focus();
            TxtName.SelectAll();
            Kopplung = true;
            Warning();
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            Warning();
            if(ChkTextfelderKoppeln.Checked)
            {
                Kopplung = true;
                
            }
            else
            {
                Kopplung = false;
            }
            if (Kopplung)
            {
                TxtProjektmappenname.Text = TxtName.Text;

            }
        }

        private void TxtProjektmappenname_Click(object sender, EventArgs e)
        {
            Kopplung = false;
            ChkTextfelderKoppeln.Checked = false;
            Warning();
            
        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtName_Click(object sender, EventArgs e)
        {
            Kopplung = false;
            Warning();
            
        }

        private void FrmTextfeldKoppeln_Load(object sender, EventArgs e)
        {
            Warning();
        }

        private void ChkTextfelderKoppeln_CheckedChanged(object sender, EventArgs e)
        {

            if (ChkTextfelderKoppeln.Checked)
            {
                ChkTextfelderKoppeln.Checked = true;
            }
            else {

                ChkTextfelderKoppeln.Checked = false;
            }

            Warning();
        }

        private void TxtProjektmappenname_Enter(object sender, EventArgs e)
        {
            Warning();
            Kopplung = false;
            ChkTextfelderKoppeln.Checked = false;
        }
    }
}
