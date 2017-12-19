using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodeOhneEreignis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string AusgabeUrlaubsort = "Berlin";
        private string AusgabeUnterkunft = "Pension";

        private void OptUrlaubsort_CheckedChanged(object sender, EventArgs e)
        {
            // Urlaubsort
            if (OptBerlin.Checked)
                AusgabeUrlaubsort = "Berlin";
            else if (OptParis.Checked)
                AusgabeUrlaubsort = "Paris";
            else
                AusgabeUrlaubsort = "Rom";

            Anzeigen();
        }

        private void OptUnterkunft_CheckedChanged(object sender, EventArgs e)
        {
            // Unterkunft
            if (OptAppartement.Checked)
                AusgabeUnterkunft = "Appartement";
            else if (OptPension.Checked)
                AusgabeUnterkunft = "Pension";
            else
                AusgabeUnterkunft = "Hotel";

            Anzeigen();
        }

        private void Anzeigen()
        {
            LblAnzeige.Text = AusgabeUrlaubsort +
                ", " + AusgabeUnterkunft;
        }
    }
}
