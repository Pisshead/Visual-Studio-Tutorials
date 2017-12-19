using System;
using System.Windows.Forms;

namespace ReferenzenVergleicheTypen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdReferenzZuweisen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug("Moped", 50);
            Fahrzeug schwalbe;
            schwalbe = vespa;
            MessageBox.Show(vespa + " / " + schwalbe);
            vespa.Beschleunigen(35);
            MessageBox.Show(vespa + " / " + schwalbe);
        }

        private void CmdReferenzenVergleichen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug("Roller", 35);
            Fahrzeug schwalbe = new Fahrzeug("Roller", 35);

            if (vespa == schwalbe)
                MessageBox.Show("Die beiden Objektverweise" +
                    " zeigen auf dasselbe Objekt");
            else
                MessageBox.Show("Die beiden Objektverweise" +
                    " zeigen nicht auf dasselbe Objekt");
        }

        private void CmdObjekteVergleichen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug("Roller", 35);
            Fahrzeug schwalbe = new Fahrzeug("Roller", 35);

            if (vespa.Equals(schwalbe))
                MessageBox.Show("Die beiden Objekte sind gleich");
            else
                MessageBox.Show("Die beiden Objekte sind nicht gleich");
        }

        private void CmdKlasseErmitteln_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug("Roller", 35);

            MessageBox.Show("Objekt vespa ist vom Typ "
                + vespa.GetType().ToString());
            MessageBox.Show("Die Klasse heißt " + typeof(Fahrzeug));

            vespa = null;
            if (vespa == null)
                MessageBox.Show("Verweis vespa zeigt auf kein Objekt");

            MessageBox.Show("Der Button ist vom Typ "
                + CmdKlasseErmitteln.GetType().ToString());
            MessageBox.Show("Die Klasse heißt " + typeof(Button));
        }

        private void CmdKlasseVergleichen_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug("Roller", 35);

            if (vespa is Fahrzeug)
                MessageBox.Show("Objekt vespa ist vom Typ Fahrzeug");

            if (CmdKlasseErmitteln is Button)
                MessageBox.Show(
                    "Objekt CmdKlasseErmitteln ist vom Typ Button");
        }
    }
}
