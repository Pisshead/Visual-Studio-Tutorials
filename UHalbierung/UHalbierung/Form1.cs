using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UHalbierung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdHalbieren_Click(object sender, EventArgs e)
        {
            LblHalbieren.Text = "";
            //double resultat = 0;
            double eingabe = Convert.ToDouble(TxtHalbieren.Text);

            if (eingabe >= 0.001)
            {


                do
                {

                    eingabe = eingabe / 2;
                    LblHalbieren.Text += eingabe + "\n";


                }
                while (eingabe/2 > 0.001);

               
            }


        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}
