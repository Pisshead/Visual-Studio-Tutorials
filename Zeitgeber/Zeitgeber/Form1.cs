using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeitgeber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {

            TimAnzeige.Enabled = true;


        }

        private void CmdStop_Click(object sender, EventArgs e)
        {

            TimAnzeige.Enabled = false;


        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {

            Close();
        

        }

        private void TimAnzeige_Tick(object sender, EventArgs e)
        {

            LblAnzeige.Text += "x";

        }

        private void CmdReset_Click(object sender, EventArgs e)
        {

            LblAnzeige.Text = "";

        }
    }
}
