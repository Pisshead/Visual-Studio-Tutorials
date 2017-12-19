using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TastaturMaus
{
    public partial class FrmTastaturMaus : Form
    {
        public FrmTastaturMaus()
        {
            InitializeComponent();
        }

        private void TxtTastatur_KeyDown(object sender, KeyEventArgs e)
        {
            LblTastatur.Text = "KeyDown, Code:" + e.KeyCode + ", Value:" + e.KeyValue + ", Alt:" + e.Alt + ", Control:" + e.Control + ", Shift:" + e.Shift;
            if(e.KeyCode == Keys.Return)
            {

                LblTastatur.Text += ", Return";

            }
            else if(e.KeyCode == Keys.Delete)
            {

                LblTastatur.Text += ",Delete";

            }
        }

        private void pMouse_MouseDown(object sender, MouseEventArgs e)
        {

            LblMouse.Text = "MouseDown, X:" + e.X + ", Y:" + e.Y + ", Button:" + e.Button + ", CLicks:" + e.Clicks;

        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
