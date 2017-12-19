using System;
using System.Windows.Forms;

namespace DatumUhrzeit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            DateTime d1 = new DateTime(2017, 7, 18, 16, 35, 12);
            DateTime d2 = new DateTime(2017, 8, 23);
            DateTime d3, d4 = new DateTime();

            LstAnzeige.Items.Add("d1: " + d1);
            LstAnzeige.Items.Add("d2: " + d2.ToShortDateString());
            d3 = DateTime.Now;
            d4 = DateTime.Today;
            LstAnzeige.Items.Add("d3: " + d3);
            LstAnzeige.Items.Add("d4: " + d4.ToShortDateString());

            LstAnzeige.Items.Add("Tag der Woche: " + d1.DayOfWeek);
            if (d1.DayOfWeek == DayOfWeek.Sunday)
                LstAnzeige.Items.Add("Sonntag");
            else
                LstAnzeige.Items.Add("Kein Sonntag");

            LstAnzeige.Items.Add("Tag des Jahres: " + d1.DayOfYear);
            LstAnzeige.Items.Add("Datum: " + d1.Date);
            LstAnzeige.Items.Add("Uhrzeit: " + d1.TimeOfDay);
        }
    }
}
