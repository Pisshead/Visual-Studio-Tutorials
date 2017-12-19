using System;
using System.Windows.Forms;

namespace TextfeldKoppeln
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Kopplung;

        private void Form1_Activated(object sender, EventArgs e)
        {
            TxtName.Focus();
            TxtName.SelectAll();
            Kopplung = true;
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            if (Kopplung)
                TxtProjektmappenname.Text = TxtName.Text;
        }

        private void TxtProjektmappenname_Click(object sender, EventArgs e)
        {
            Kopplung = false;
        }
    }
}
