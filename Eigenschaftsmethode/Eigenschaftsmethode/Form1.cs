using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eigenschaftsmethode
{
    public partial class FrmEigenschaftsmethode : Form
    {
        public FrmEigenschaftsmethode()
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
