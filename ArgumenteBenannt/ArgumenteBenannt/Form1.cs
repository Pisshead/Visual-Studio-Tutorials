using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArgumenteBenannt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rechteck("rot", 4, 6, "Punkte");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rechteck("rot", rand: "Striche", breite: 2, laenge: 5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rechteck("gelb", 7);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rechteck("blau", rand: "Haarlinie");
        }

        private void Rechteck(string farbe, int laenge = 1, int breite = 1, string rand = "Linie")
        {

            label1.Text = "Farbe: " + farbe + ", Länge: " + laenge + ",\nBreite: " + breite + ", Rand: " + rand;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
