using System;
using System.Windows.Forms;

namespace ArgumenteBenannt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            Rechteck("rot", 4, 6, "Punkte");
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {
            Rechteck("rot", rand: "Striche", breite: 2, laenge: 5);
        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            Rechteck("gelb", 7);
        }

        private void CmdAnzeigen4_Click(object sender, EventArgs e)
        {
            Rechteck("blau", rand: "Haarlinie");
        }

        private void Rechteck(string farbe, int laenge = 1,
           int breite = 1, string rand = "Linie")
        {
            LblAnzeige.Text = "Farbe: " + farbe + ", Länge: " + laenge +
                ", Breite: " + breite + ", Rand: " + rand;
        }
    }
}
