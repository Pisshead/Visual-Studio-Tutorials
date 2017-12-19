using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USteuerbetrag
{
    public partial class FrmSteuersatz : Form
    {
        public FrmSteuersatz()
        {
            InitializeComponent();
        }

        private void CmdBerechnen_Click(object sender, EventArgs e)
        {

            int x = (int)NumGehalt.Value;

            switch (x)
            {

                case int n when (n <= 12000):
                    LblAnzeige.Text = "Steuerbetrag: " + x * 12 / 100;
                    break;

                case int n when (n > 12000 && n <= 20000):
                    LblAnzeige.Text = "Steuerbetrag: " + x * 15 / 100;
                    break;
                case int n when (n > 20000 && n <= 30000):

                    LblAnzeige.Text = "Steuerbetrag: " + x * 20 / 100;
                    break;
                default:
                    LblAnzeige.Text = "Steuerbetrag: " + x * 25 / 100;
                    break;




            }
           

        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
