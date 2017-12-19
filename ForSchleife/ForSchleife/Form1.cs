using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForSchleife
{
    public partial class FrmForSchleife : Form
    {
        public FrmForSchleife()
        {
            InitializeComponent();
        }

        private void CmdSchleife1_Click(object sender, EventArgs e)
        {
            int i;
            LblSchleife1.Text = "";

            for(i=3; i<=7; i++)
            {

                LblSchleife1.Text += i + "\n";


            }
        }

        private void CmdSchleife2_Click(object sender, EventArgs e)
        {
            LblSchleife2.Text = "";

            for (int i = 3; i <= 11; i = i + 2)
            {

                LblSchleife2.Text += i + "\n";

            }
        }

        private void CmdSchleife3_Click(object sender, EventArgs e)
        {

            LblSchleife3.Text = "";

            for (int i = 7; i >= 3; i--)
            {

                LblSchleife3.Text += i + "\n";

            }

        }

        private void CmdSchleife4_Click(object sender, EventArgs e)
        {

            LblSchleife4.Text = "";

            for(double d = 3.5; d <= 7.5; d = d + 1.5)
            {

                LblSchleife4.Text += d + "\n";

            }

        }

        private void CmdSchleife5_Click(object sender, EventArgs e)
        {

            LblSchleife5.Text = "";

            for(int i = 3; i <= 20; i++)
            {

                if (i >= 5 && i <= 7)
                {

                    continue;

                }

                if (i >= 11)
                {

                    break;

                }
                LblSchleife5.Text += i + "\n";

            }

        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
