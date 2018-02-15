using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KlasseObjekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAusgabe_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa;
            vespa = new Fahrzeug();

            LblAnzeigeV1.Text = vespa.Ausgabe();
            vespa.Beschleunigen(20);
            LblAnzeigeV1.Text += "\n" + vespa.Ausgabe();
            // LblAnzeigeV1.Text = vespa.geschwindigkeit;
        }
    }
}
