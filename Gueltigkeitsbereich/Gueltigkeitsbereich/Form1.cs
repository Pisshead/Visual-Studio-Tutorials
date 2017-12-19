using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gueltigkeitsbereich
{
    public partial class Form1 : Form
    {
        private double x = 0;

        public Form1()
        {
            InitializeComponent();
        }


        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {

            double y = 0;
            y = y + 0.1;
            x = x + 0.1;
            LblAnzeige.Text = "x: " + x + " y: " + y;

        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {

            double z = 0;
            z = z + 0.1;
            x = x + 0.1;
            LblAnzeige.Text = "x: " + x + "z: " + z;

        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
