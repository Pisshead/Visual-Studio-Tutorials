using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UForSchleife
{
    public partial class FrmUForSchleife : Form
    {
        

        public FrmUForSchleife()
        {
            InitializeComponent();
        }

        private void CmdFor_Click(object sender, EventArgs e)
        {
            LblFor.Text = "";
            double s = 0, average = 0;
            int counter = 0;
            

            for (double i = 35; i >= 20; i = i - 2.5)
            {

                LblFor.Text += i + "\n";
                s = i + s;
                counter = counter + 1;
                average = s / counter;
                
            }

            LblFor.Text += "Summe: " + s + "\n" + "Mittelwert: " + average;

        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
