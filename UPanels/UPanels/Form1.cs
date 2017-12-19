using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPanels
{
    public partial class FrmZeitgeber : Form
    {

        


        public FrmZeitgeber()
        {
            InitializeComponent();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {


            TimPanels.Enabled = true;

        }

        private void TimPanels_Tick(object sender, EventArgs e)
        {


            pGreen.Location = new Point(pGreen.Location.X - 9, pGreen.Location.Y + 9);
            pRed.Location = new Point(pRed.Location.X + 9, pRed.Location.Y + 9);
            pBlue.Location = new Point(pBlue.Location.X - 9, pBlue.Location.Y - 9);
            pYellow.Location = new Point(pYellow.Location.X + 9, pYellow.Location.Y - 9);

        }

        private void CmdStop_Click(object sender, EventArgs e)
        {

            TimPanels.Enabled = false;

        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
