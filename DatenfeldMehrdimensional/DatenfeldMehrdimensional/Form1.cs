using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatenfeldMehrdimensional
{
    public partial class FrmMehrdimensionaleDatenfelder : Form
    {
        private Random r = new Random();
        List<string> hilfsliste = new List<string>();
        int[,,] a;
        int i, k, l;
        int MinWert;
        
        string MinWertIndex;

        public FrmMehrdimensionaleDatenfelder()
        {
            InitializeComponent();
        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {


            
            a = new int[6, 3, 4];
            
            MinWertIndex = "";
            

            LstSpalte0Zeile0.Items.Clear();
            LstSpalte1Zeile0.Items.Clear();
            LstSpalte2Zeile0.Items.Clear();
            LstSpalte0Zeile1.Items.Clear();
            LstSpalte1Zeile1.Items.Clear();
            LstSpalte2Zeile1.Items.Clear();
            LstSpalte0Zeile2.Items.Clear();
            LstSpalte1Zeile2.Items.Clear();
            LstSpalte2Zeile2.Items.Clear();
            LstSpalte0Zeile3.Items.Clear();
            LstSpalte1Zeile3.Items.Clear();
            LstSpalte2Zeile3.Items.Clear();

            for (i = 0; i <= a.GetUpperBound(0); i++)
            {

                for (k = 0; k <= a.GetUpperBound(1); k++)
                {
                    for (l = 0; l <= a.GetUpperBound(2); l++)
                    {

                        a[i, k, l] = r.Next(20, 31);
                       

                    }
                    
                }

                    LstSpalte0Zeile0.Items.Add(a[i, 0, 0]);
                    LstSpalte1Zeile0.Items.Add(a[i, 1, 0]);
                    LstSpalte2Zeile0.Items.Add(a[i, 2, 0]);
                    LstSpalte0Zeile1.Items.Add(a[i, 0, 1]);
                LstSpalte1Zeile1.Items.Add(a[i, 1, 1]);
                LstSpalte2Zeile1.Items.Add(a[i, 2, 1]);
                LstSpalte0Zeile2.Items.Add(a[i, 0, 2]);
                LstSpalte1Zeile2.Items.Add(a[i, 1, 2]);
                LstSpalte2Zeile2.Items.Add(a[i, 2, 2]);
                LstSpalte0Zeile3.Items.Add(a[i, 0, 3]);
                LstSpalte1Zeile3.Items.Add(a[i, 1, 3]);
                LstSpalte2Zeile3.Items.Add(a[i, 2, 3]);



            }
            

        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }

      private void LstSpalte_Click(object sender, EventArgs e)
        {
            ListBox lst = sender as ListBox;
            int x;
            if(lst == LstSpalte0Zeile0)
            {
                x = 0;
            }
            else if(lst == LstSpalte1Zeile0)
            {
                x = 1;
            }
            else
            {
                x = 2;
            }
            LblAnzeige.Text = "Indizes: " + lst.SelectedIndex + "," + x;
        }

        private void CmdInitialisieren_Click(object sender, EventArgs e)
        {
            LblMinima.Text = "";
            MinWert = a.Length;
            if (a[i, k, l] < MinWert)
            {

                MinWert = a[i, k, l];
                MinWertIndex = "Die Minima mit " + MinWert + " befinden sich in Zelle " + i + ", von Spalte " + k + " und Zeile " + l + "\n";
                hilfsliste.Add(MinWertIndex);

            }

            foreach (string g in hilfsliste)
            {

                LblMinima.Text = LblMinima.Text + MinWertIndex;

            }
        }
    }
}
