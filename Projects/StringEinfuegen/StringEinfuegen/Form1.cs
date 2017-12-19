using System;
using System.Windows.Forms;

namespace StringEinfuegen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdEinfuegen_Click(object sender, EventArgs e)
        {
            string eingabe, einfuegen, anzeige;
            eingabe = TxtEingabe.Text;
            einfuegen = TxtEinfuegen.Text;

            anzeige = eingabe.Insert((int)NumEinfuegen.Value, einfuegen);
            LblAnzeige.Text = anzeige;
        }

        private void TxtEingabe_TextChanged(object sender, EventArgs e)
        {
            string eingabe;
            eingabe = TxtEingabe.Text;
            NumEinfuegen.Maximum = eingabe.Length;
        }
    }
}
