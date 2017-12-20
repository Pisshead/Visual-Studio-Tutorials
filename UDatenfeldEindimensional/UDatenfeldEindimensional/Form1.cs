using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDatenfeldEindimensional
{
    public partial class FrmDatenfeldEindimensional : Form
    {
        Random r = new Random();
        int[] a = new int[10];
        int c = 0;

        public FrmDatenfeldEindimensional()
        {
            InitializeComponent();
        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdMinima_Click(object sender, EventArgs e)
        {
            if (LstBoxRandom.Items.Count == 0)
            {
                LblAnzeige.Text = "Bitte zuerst \nZahlen generieren.";
            }
            else
            {
                List<object> help = new List<object>();
                help.Clear();
                int[] b = new int[c];
                b = (int[])a.Clone();
                Array.Sort(b);
                LblAnzeige.Text = "Die Minima sind:";
                

                foreach (int i in b)
                {

                    if (Convert.ToInt32(b.GetValue(0)) == i)
                    {
                        help.Add(i);
                    }

                }

                if (help.Count == 1)
                {

                    LblAnzeige.Text = "Das Minimum ist: ";

                    foreach (int i in help)
                    {
                        LblAnzeige.Text += "\n" + i;
                    }
                }
                else {
                    LblAnzeige.Text = "Die Minima sind:";
                    foreach (int i in help)
                    {
                        LblAnzeige.Text += "\n" + i;

                    }
                }

                

            }
             
                
                


        }

        private void CmdGenerieren_Click(object sender, EventArgs e)
        {
            LstBoxRandom.Items.Clear();
            LblAnzeige.Text = "";

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(20, 31);
                LstBoxRandom.Items.Add(a[i]);
                c = a.Length;

            }
        }
    }
}
