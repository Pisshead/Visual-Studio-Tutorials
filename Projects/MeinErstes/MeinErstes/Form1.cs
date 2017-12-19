using System;
using System.Windows.Forms;

namespace MeinErstes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdHallo_Click(object sender, EventArgs e)
        {
            // Diese Anweisung setzt den Text in das Label
            LblAnzeige.Text = "Hallo";
        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            /* Diese Anweisung beendet
               das Programm */
            Close();
        }
    }
}
