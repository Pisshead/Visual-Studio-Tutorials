using System;
using System.Windows.Forms;

namespace Syntaxfehler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {
            int i;
            if (TxtEingabe.Txt = "")
                return;

            i = Convert.ToInt(TxtEingabe.Text);

            if (i > 0)
                LblAnzeige.Text = "positiv";
            else if  i < 0
                LblAnzeige.Text = "negativ"
            else
                LblAnzeige = "gleich 0";
        }
    }
}
