using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwitchCase
{
    public partial class FrmSwitchCase : Form
    {
        public FrmSwitchCase()
        {
            InitializeComponent();
        }

        private void CmdAuswerten_Click(object sender, EventArgs e)
        {

            int x = (int)NumX.Value;

            switch (x)
            {


                case 1:
                case 3:
                case 5:
                case 7:
                case 9:

                    LblAnzeige.Text = "einstellig, ungerade";

                    break;

                case 2:
                case 4:
                case 6:
                case 8:

                    LblAnzeige.Text = "einstellig, gerade";

                    break;

                default:

                    LblAnzeige.Text = "zweistellig";

                    break;




            }

        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        
        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {

            string s = "Nizza";
            LblAnzeige.Text = "";

            switch (s)
            {



                case "France":
                    LblAnzeige.Text += "Frankreich\n";
                    break;

                case "Bordeaux":

                    LblAnzeige.Text += "Atlantik\n";
                    goto case "France";

                case "Nizza":
                    LblAnzeige.Text += "Cote d'Azur\n";
                    goto case "France";
                default:
                    LblAnzeige.Text += "restliche Fälle\n";
                    break;



            }        

        }
    }
}
