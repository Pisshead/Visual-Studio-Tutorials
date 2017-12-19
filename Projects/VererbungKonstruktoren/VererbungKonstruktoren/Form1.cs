using System;
using System.Windows.Forms;

namespace VererbungKonstruktoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            PKW fiat = new PKW("Limousine", 50, 2);
            PKW peugeot = new PKW();
            LblAnzeige.Text = fiat + "\n" + peugeot;
        }
    }
}
