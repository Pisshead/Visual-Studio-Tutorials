using System;
using System.Windows.Forms;

namespace SwitchCase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeige1_Click(object sender, EventArgs e)
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

        private void CmdAnzeige2_Click(object sender, EventArgs e)
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
