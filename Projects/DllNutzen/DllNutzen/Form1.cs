using System;
using System.Windows.Forms;

using DllErstellen;

namespace DllNutzen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug();
            LblAnzeige.Text = vespa + "";
            vespa.Beschleunigen(20);
            LblAnzeige.Text += "\n" + vespa;
        }
    }
}
