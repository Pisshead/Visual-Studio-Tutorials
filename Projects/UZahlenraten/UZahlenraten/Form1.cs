using System;
using System.Windows.Forms;

namespace UZahlenraten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random r = new Random();
        private int zahl = -1;

        private void CmdErzeugen_Click(object sender, EventArgs e)
        {
            zahl = r.Next(1, 101);
        }

        private void CmdPruefen_Click(object sender, EventArgs e)
        {
            int eingabe;

            if (zahl == -1)
                LblAnzeige.Text = "Zuerst eine Zahl erzeugen";
            else
            {
                eingabe = Convert.ToInt32(TxtEingabe.Text);

                if (eingabe > zahl)
                    LblAnzeige.Text = "Die Zahl " + eingabe + " ist zu groß";
                else if (eingabe < zahl)
                    LblAnzeige.Text = "Die Zahl " + eingabe + " ist zu klein";
                else
                    LblAnzeige.Text = eingabe + " ist die richtige Zahl";
            }
        }
    }
}
