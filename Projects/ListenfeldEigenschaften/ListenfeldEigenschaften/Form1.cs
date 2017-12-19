using System;
using System.Windows.Forms;

namespace ListenfeldEigenschaften
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LstSpeisen.Items.Add("Spaghetti");
            LstSpeisen.Items.Add("Grüne Nudeln");
            LstSpeisen.Items.Add("Tortellini");
            LstSpeisen.Items.Add("Pizza");
            LstSpeisen.Items.Add("Lasagne");
        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {
            LblAnzeige1.Text = "Anzahl: " + LstSpeisen.Items.Count;
            LblAnzeige2.Text = "Ausgewählter Eintrag: " +
                LstSpeisen.SelectedItem;
            LblAnzeige3.Text = "Nummer des ausgewählten Eintrags: " +
                LstSpeisen.SelectedIndex;

            LblAnzeige4.Text = "Alle Einträge:" + "\n";
            for (int i = 0; i < LstSpeisen.Items.Count; i++)
                LblAnzeige4.Text += LstSpeisen.Items[i] + "\n";
        }

        private void CmdForeach_Click(object sender, EventArgs e)
        {
            LblAnzeige4.Text = "Alle Einträge:" + "\n";
            foreach (string s in LstSpeisen.Items)
                LblAnzeige4.Text += s + "\n";
        }
    }
}
