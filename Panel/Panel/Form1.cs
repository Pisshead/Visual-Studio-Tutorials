using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel
{
    public partial class FrmPanelVerschieben : Form
    {
        int startX = 145;
        int startY = 80;


        public FrmPanelVerschieben()
        {
            InitializeComponent();
        }

        private void CmdNachOben_Click(object sender, EventArgs e)
        {


            p.Location = new Point(p.Location.X, p.Location.Y - 10);

        }

        private void CmdNachLinks_Click(object sender, EventArgs e)
        {


            p.Location = new Point(p.Location.X - 10, p.Location.Y);

        }

        private void CmdNachRechts_Click(object sender, EventArgs e)
        {


            p.Location = new Point(p.Location.X + 10, p.Location.Y);

        }

        private void CmdNachUnten_Click(object sender, EventArgs e)
        {


            p.Location = new Point(p.Location.X, p.Location.Y + 10);

        }

        private void CmdReset_Click(object sender, EventArgs e)
        {


            p.Location = new Point(startX, startY);

        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {


            Close();

        }
    }
}
