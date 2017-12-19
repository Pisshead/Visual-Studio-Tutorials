using System;
using System.Windows.Forms;

namespace Optionsgruppen
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

            LblAnzeige.Text = AusgabeUrlaubsort +
                ", " + AusgabeUnterkunft;
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

            LblAnzeige.Text = AusgabeUrlaubsort +
                ", " + AusgabeUnterkunft;
        }
    }
}
