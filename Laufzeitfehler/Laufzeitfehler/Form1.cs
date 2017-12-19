using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laufzeitfehler
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

                x = Convert.ToInt32(TxtZahl1.Text);
                y = Convert.ToInt32(TxtZahl2.Text);
                z = x / y;
                LblAnzeige.Text = "Ergebnis: " + z;
            }
            catch(FormatException ex)
            {
                LblAnzeige.Text = "Fehler: falsches Eingabeformat";

            }
           catch(DivideByZeroException ex)
            {
                LblAnzeige.Text = "Fehler: Division durch 0 (null)";

            }
            catch(Exception ex)
            {
                LblAnzeige.Text = "Fehler: allgemein";

            }
            

        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
