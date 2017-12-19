using System;
using System.Windows.Forms;

namespace Eigenschaftsmethode
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
            LblAnzeige.Text = "Geschwindigkeit: " + vespa.Geschwindigkeit;
            vespa.Beschleunigen(120);
            // vespa.Geschwindigkeit = 50;
            LblAnzeige.Text += "\nGeschwindigkeit: " +
                vespa.Geschwindigkeit;
        }
    }
}
