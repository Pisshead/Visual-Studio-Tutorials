using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EreignisEnter
{
    public partial class FrmEreignisEnter : Form
    {
        public FrmEreignisEnter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstLieferart.Items.Add("DHL");
            LstLieferart.Items.Add("UPS");
            LstLieferart.Items.Add("Homes");
        }

        private void FrmEreignisEnter_Activated(object sender, EventArgs e)
        {
            LblHilfe.Text = "";
        }

        private void TxtEingabe_Enter(object sender, EventArgs e)
        {
            LblHilfe.Text = "Bitte geben Sie Nachname, Vorname ein!";
        }

        private void ChkBeretisKunde_Enter(object sender, EventArgs e)
        {
            LblHilfe.Text = "Kreuzen Sie an, ob Sie bereits Kunde sind!";
        }

        private void LstLieferart_Enter(object sender, EventArgs e)
        {
            LblHilfe.Text = "Wählen Sie einen Paketdienst aus!";
        }

        private void OptZahlungsform_CheckedChanged(object sender, EventArgs e)
        {
            LblHilfe.Text = "Wählen Sie eine Zahlungsform!";
        }

        private void TxtEingabe_Click(object sender, EventArgs e)
        {
            LblHilfe.Text = "Bitte geben Sie Nachname, Vorname ein!";
        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
