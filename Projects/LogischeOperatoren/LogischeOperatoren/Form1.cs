using System;
using System.Windows.Forms;

namespace LogischeOperatoren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdNicht_Click(object sender, EventArgs e)
        {
            int A = 1, B = 3;
            LblAnzeige.Text = "Bedingung: " + !(A < B);
        }

        private void CmdUnd_Click(object sender, EventArgs e)
        {
            int A = 1, B = 3, C = 5;
            LblAnzeige.Text = "Bedingung: " + ((B > A) && (C > B));
        }

        private void CmdOder_Click(object sender, EventArgs e)
        {
            int A = 1, B = 3, C = 5;
            LblAnzeige.Text = "Bedingung: " + ((B < A) || (C < B));
        }

        private void CmdExklusivOder_Click(object sender, EventArgs e)
        {
            int A = 1, B = 3, C = 5;
            LblAnzeige.Text = "Bedingung: " + ((B < A) ^ (C > B));
        }

        private void CmdUndMitAbbruch_Click(object sender, EventArgs e)
        {
            /* Die zweite Bedingung wird nicht geprüft, weil die erste Bedingung bereits
               falsch ist. Daher wird B++ nicht ausgeführt, B behält den Wert 3 */
            int A = 1, B = 3, C = 5;
            LblAnzeige.Text = "Bedingung: " + ((B < A) && (C > B++));
            LblWert.Text = "Wert: " + B;
        }

        private void CmdBitweiseUnd_Click(object sender, EventArgs e)
        {
            /* Die zweite Bedingung wird geprüft, obwohl die erste Bedingung bereits
               falsch ist. Daher wird B++ ausgeführt, B ändert seinen Wert auf 4 */
            int A = 1, B = 3, C = 5;
            LblAnzeige.Text = "Bedingung: " + ((B < A) & (C > B++));
            LblWert.Text = "Wert: " + B;
        }

        private void CmdOderMitAbbruch_Click(object sender, EventArgs e)
        {
            /* Die zweite Bedingung wird nicht geprüft, weil die erste Bedingung bereits
               wahr ist. Daher wird B++ nicht ausgeführt, B behält den Wert 3 */
            int A = 1, B = 3, C = 5;
            LblAnzeige.Text = "Bedingung: " + ((B > A) || (C < B++));
            LblWert.Text = "Wert: " + B;
        }

        private void CmdBitweiseOder_Click(object sender, EventArgs e)
        {
            /* Die zweite Bedingung wird geprüft, obwohl die erste Bedingung bereits
               wahr ist. Daher wird B++ ausgeführt, B ändert seinen Wert auf 4 */
            int A = 1, B = 3, C = 5;
            LblAnzeige.Text = "Bedingung: " + ((B > A) | (C < B++));
            LblWert.Text = "Wert: " + B;
        }
    }
}
