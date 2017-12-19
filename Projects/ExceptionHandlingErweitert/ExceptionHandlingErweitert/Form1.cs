using System;
using System.Windows.Forms;

namespace ExceptionHandlingErweitert
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
            catch (FormatException ex)
            {
                LblAusgabe.Text = "Fehler: Falsches Eingabeformat";
            }
            catch (DivideByZeroException ex)
            {
                LblAusgabe.Text = "Fehler: Division durch 0";
            }
            catch (Exception ex)
            {
                LblAusgabe.Text = "Fehler: Allgemein";
            }
        }
    }
}
