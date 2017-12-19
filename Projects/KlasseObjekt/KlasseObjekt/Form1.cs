using System;
using System.Windows.Forms;

namespace KlasseObjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa;
            vespa = new Fahrzeug();

            LblAnzeige.Text = vespa.Ausgabe();
            vespa.Beschleunigen(20);
            LblAnzeige.Text += "\n" + vespa.Ausgabe();
            // LblAnzeige.Text = vespa.geschwindigkeit;
        }
    }
}
