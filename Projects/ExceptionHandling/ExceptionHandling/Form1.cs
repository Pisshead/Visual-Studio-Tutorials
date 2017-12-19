using System;
using System.Windows.Forms;

namespace ExceptionHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdRechnen_Click(object sender, EventArgs e)
        {
            int x, y, z;

            try
            {
                x = Convert.ToInt32(TxtEingabe1.Text);
                y = Convert.ToInt32(TxtEingabe2.Text);
                z = x / y;
                LblAusgabe.Text = "Ergebnis: " + z;
            }
            catch (Exception ex)
            {
                LblAusgabe.Text = "Fehler: " + ex.Message;
            }
        }
    }
}
