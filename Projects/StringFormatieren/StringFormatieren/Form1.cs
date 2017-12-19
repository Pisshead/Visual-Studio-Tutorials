using System;
using System.Windows.Forms;

namespace StringFormatieren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {
            string format, ausgabe;
            string[] stadt = {"München", "Berlin",
                "Bonn", "Bremerhaven", "Ulm"};

            LstAnzeige.Items.Clear();
            LblAnzeige.Text = "";
            format = "{0,-15}{1,9:0.0000}{2,12:#,##0.0}";

            for (int i = 0; i < stadt.Length; i++)
            {
                ausgabe = String.Format(format,
                    stadt[i], i / 7.0, i * 10000 / 7);
                LstAnzeige.Items.Add(ausgabe);
                LblAnzeige.Text += ausgabe + "\n";
            }
        }
    }
}
