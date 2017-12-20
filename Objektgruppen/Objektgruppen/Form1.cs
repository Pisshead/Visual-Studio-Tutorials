using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Objektgruppen
{
    public partial class FrmOptionsgruppen : Form
    {
        private string AusgabeUrlaubsort = "Berlin";
        private string AusgabeUnterkunft = "Pension";

        public FrmOptionsgruppen()
        {
            InitializeComponent();
        }

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

        private void OptUNterkunft_CheckedChanged(object sender, EventArgs e)
        {

            // Unterkunft
            if (OptAppartement.Checked)
                AusgabeUnterkunft = "Appartement";
            else if (OptPension.Checked)
                AusgabeUnterkunft = "Pension";
            else
                AusgabeUnterkunft = "Hotel";

            LblAnzeige.Text = AusgabeUrlaubsort + ", " + AusgabeUnterkunft;
        }

    }
    }

