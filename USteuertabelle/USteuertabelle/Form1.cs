using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USteuertabelle
{
    public partial class FrmSteuerbetrag : Form
    {
        double steuern = 0;
        double netto = 0;
        string steuersatz;
        int gehalt = 0;
        int i = 5000;
        int counter = 0;
        

        public FrmSteuerbetrag()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {

            for (i = 5000; i <= 35000; i = i + 3000)
            {

                if(i >= 0 && i <= 12000)
                {
                    gehalt = i;
                    steuern = i * 0.12;
                    steuersatz = "12%";
                    counter++;

                }
                else if(i>12000 && i <= 20000)
                {

                    gehalt = i;
                    steuern = i * 0.15;
                    steuersatz = "15%";
                    counter++;
                }
                else if(i> 20000 && i <= 35000)
                {
                    gehalt = i;

                    steuern = i * 0.2;
                    steuersatz = "20%";
                    counter++;
                }
                else
                {
                    gehalt = i;

                    steuern = i * 0.25;
                    steuersatz = "25%";
                    counter++;
                }

                netto = gehalt - steuern;
                LblAnzeige.Text += gehalt + " €, " + steuersatz + ", " + steuern + " €, " + netto + " €" + "\n";


            }
            LblAnzeige.Text += "\n" + counter;

        }

        private void FrmSteuerbetrag_Load(object sender, EventArgs e)
        {

        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
