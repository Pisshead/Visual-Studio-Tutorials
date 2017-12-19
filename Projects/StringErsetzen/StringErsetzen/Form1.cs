using System;
using System.Windows.Forms;

namespace StringErsetzen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdErsetzen_Click(object sender, EventArgs e)
        {
            string eingabe, suchen, ersetzen, anzeige;
            eingabe = TxtEingabe.Text;
            suchen = TxtSuchen.Text;
            ersetzen = TxtErsetzen.Text;
            anzeige = eingabe.Replace(suchen, ersetzen);
            LblAnzeige.Text = anzeige;
        }
    }
}
