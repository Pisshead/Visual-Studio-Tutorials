using System;
using System.Windows.Forms;

namespace StatischeElemente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            Zahl x = new Zahl(2.5);
            Zahl p = new Zahl(-5);
            double y, r;

            /* Objektbezogene Methoden */
            x.MalDrei();
            LblAnzeige.Text = x + "\n" + p;

            /* Klassenbezogene und öffentliche Methode */
            y = 4;
            LblAnzeige.Text += "\n" + "Zahl: " + y + "\n" +
                "Nach Verdopplung: " + Zahl.Verdoppeln(y);

            /* Klassenbezogene und öffentliche Eigenschaft */
            r = 6;
            LblAnzeige.Text += "\n" + "Radius: " + r + "\n" +
                "Fläche: " + r * r * Zahl.pi;
        }
    }
}
