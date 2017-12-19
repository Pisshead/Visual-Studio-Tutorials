using System;
using System.Windows.Forms;

namespace ListenfeldMehrfachauswahl
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

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = "";
            foreach (string s in LstSpeisen.SelectedItems)
                LblAnzeige.Text += s + "\n";
        }
    }
}
