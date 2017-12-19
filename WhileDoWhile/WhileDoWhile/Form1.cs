using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhileDoWhile
{
    public partial class FrmWhileDoWhile : Form
    {
        private Random r = new Random();

        public FrmWhileDoWhile()
        {
            InitializeComponent();
        }

        private void CmdWhile_Click(object sender, EventArgs e)
        {

            int summe = 0, z;

            LblWhileDoWhile.Text = "";

            while (summe < 20)
            {

                z = r.Next(1, 7);
                summe = summe + z;
                LblWhileDoWhile.Text += summe + "\n";

            }

        }

        private void CmdDoWhile_Click(object sender, EventArgs e)
        {

            int summe = 0, z;
            LblWhileDoWhile.Text = "";

            do
            {

                z = r.Next(1, 7);
                summe = summe + z;
                LblWhileDoWhile.Text += summe + "\n";


            }
            while (summe < 20);
        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
