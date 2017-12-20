using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArgumenteBeliebig
{
    public partial class FrmArgumenteBeliebig : Form
    {
        public FrmArgumenteBeliebig()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double a = 4.5, b = 7.2, c = 10.3, d = 9.2;
            label1.Text = "Ergebnis: " + Mittelwert(a, b, c, d);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = 4.5, b = 7.2;
            label1.Text = "Ergebnis: " + Mittelwert(a, b);
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Ergebnis: " + Mittelwert();
        }

        private double Mittelwert(params double[] x)
        {

            double summe = 0;
            if (x.Length == 0)
            {
                return 0;
            }
            else
            {
                foreach (int z in x)
                {
                    summe += z;
                }
            }
                    return summe / x.Length;
                }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }

