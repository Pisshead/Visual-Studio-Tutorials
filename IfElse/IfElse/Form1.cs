using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IfElse
{
    public partial class FrmIfElse : Form
    {
        public FrmIfElse()
        {
            InitializeComponent();
        }

        private void CmdIf_Click(object sender, EventArgs e)
        {

            int x = (int)NumX.Value;
            LblAnzeige.Text = "";

            if (x > 12)
            {

                LblAnzeige.Text = "x ist grösser als 12";
                NumX.BackColor = Color.LightGreen;

            }
            else {

                LblAnzeige.Text = "x ist kleiner oder gleich 12.";
                NumX.BackColor = Color.LightBlue;

            }

        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
