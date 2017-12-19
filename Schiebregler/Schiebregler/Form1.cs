using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schiebregler
{
    public partial class FrmSchiebregler : Form
    {
        public FrmSchiebregler()
        {
            InitializeComponent();
        }

        private void TrkSchiebregler_ValueChanged(object sender, EventArgs e)
        {

            pFarbwechsel.BackColor = Color.FromArgb(TrkRot.Value, TrkGruen.Value, TrkBlau.Value);
            LblRot.Text = "Rot\n" + TrkRot.Value;
            LblGruen.Text = "Grün\n" + TrkGruen.Value;
            LblBlau.Text = "Blau\n" + TrkBlau.Value;
        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
