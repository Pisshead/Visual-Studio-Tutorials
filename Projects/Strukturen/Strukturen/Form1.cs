using System;
using System.Windows.Forms;

namespace Strukturen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            /* Objekte ohne Daten */
            Kontakt x = new Kontakt();
            Kontakt y = new Kontakt();

            /* Zuweisung */
            x.plz = 43024;
            x.ort = "Aachen";
            x.strasse = "Hunsrückweg";
            x.hausnummer = 104;
            x.tel.vorwahl = "0466";
            x.tel.nummer = 532626;
            x.fax.vorwahl = "0466";
            x.fax.nummer = 532627;

            /* Kopie aller Werte und Ausgabe */
            y = x;
            LblAnzeige.Text = y + "";

            /* Objekte mit Daten */
            Kontakt z = new Kontakt(43035, "Düren", "Eifelweg", 12,
                new Telefon("0463", 887743), new Telefon("0463", 887744));
            LblAnzeige.Text += "\n\n" + z;
        }
    }
}
