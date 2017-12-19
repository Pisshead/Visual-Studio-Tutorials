using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steuerelemente
{
    public partial class FrmPosGrFrb : Form
    {
        public FrmPosGrFrb()
        {
            InitializeComponent();
        }

        private void CmdPosRel_Click(object sender, EventArgs e)
        {

            CmdTest.Location = new Point(
                
                CmdTest.Location.X + 20, CmdTest.Location.Y);


        }

        private void CmdPosAbs_Click(object sender, EventArgs e)
        {

            CmdTest.Location = new Point(100, 200);

        }

        private void CmdGrRel_Click(object sender, EventArgs e)
        {

            CmdTest.Size = new Size(

                CmdTest.Size.Width + 20, CmdTest.Size.Height);

        }

        private void CmdGrAbs_Click(object sender, EventArgs e)
        {


            CmdTest.Size = new Size(50, 100);

        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {

            LblAnzeige.Text = "Position: X: " + CmdTest.Location.X + ", Y" + CmdTest.Location.Y + "\n" + "Grösse: Breit: " 
                
                + CmdTest.Size.Width + ", Höhe: " + CmdTest.Size.Height;


        }

        private void CmdFrb_Click(object sender, EventArgs e)
        {

            BackColor = Color.Yellow;
            LblAnzeige.BackColor = Color.FromArgb(192, 255, 0);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
