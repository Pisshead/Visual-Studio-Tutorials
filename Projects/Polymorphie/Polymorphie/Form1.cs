using System;
using System.Windows.Forms;

namespace Polymorphie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug("Roller", 35);
            Fahrzeug schwalbe = new Fahrzeug("Moped", 45);
            PKW fiat = new PKW("Limousine", 90, 4);
            PKW porsche = new PKW("Sportwagen", 130, 1);

            Fahrzeug[] sammlung = new Fahrzeug[5];
            sammlung[0] = vespa;
            sammlung[1] = schwalbe;
            sammlung[2] = fiat;
            sammlung[3] = porsche;
            sammlung[4] = new Fahrzeug();

            foreach (Fahrzeug f in sammlung)
                LblAnzeige.Text += f;
        }
    }
}
