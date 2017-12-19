using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UZahlenraten
{
    public partial class FrmZahlenraten : Form
    {
        private Random r = new Random();
        int zahl = 0;
        string anfang = "Hinweis: Die gesuchte Zahl ist ";
        string ende = ". Gib eine neue Zahl ein und prüfe sie erneut!";
        

        public FrmZahlenraten()
        {
            InitializeComponent();
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {

            zahl = r.Next(1, 101);
            LblInfo.Text = "Jetzt bitte Zahl eingeben und prüfen.";

        }

        private void CmdPruefen_Click(object sender, EventArgs e)
        {

            int geraten = Convert.ToInt16(TxtRaten.Text);
            if(geraten == zahl)
            {

                LblHinweis.Text = "Gewonnen!";


            }
            else if(geraten < zahl)
            {

                LblHinweis.Text = anfang + "grösser" + ende;

            }
            else
            {

                LblHinweis.Text = anfang + "kleiner" + ende;

            }

        }
    }
}
