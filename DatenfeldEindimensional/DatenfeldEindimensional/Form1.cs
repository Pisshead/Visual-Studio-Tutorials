using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatenfeldEindimensional
{
    public partial class FrmDatenfeldEindimensional : Form
    {
        private Random r = new Random();

        public FrmDatenfeldEindimensional()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen1_Click(object sender, EventArgs e)
        {
            int[] a;
            a = new int[7];

            LstDaten.Items.Clear();
            for(int i = 0; i < 7; i++)
            {

                a[i] = r.Next(20, 31);
                LstDaten.Items.Add(a[i]);

               
 
            }
        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdAnzeigen2_Click(object sender, EventArgs e)
        {

            int[] a = new int[7];
            int MaxWert, Minwert, MaxwertIndex, MinwertIndex;

           
            LstDaten.Items.Clear();
            for (int i = 0; i < 7; i++)
            {

                a[i] = r.Next(20, 31);
                LstDaten.Items.Add(a[i]);
            }

                /* Max/Min Initialisieren */
                MaxWert = a[0];
                Minwert = a[0];
                MaxwertIndex = 0;
                MinwertIndex = 0;

                /* Max/Min suchen */
                for(int i = 1; i < a.Length; i++)
            {

                if (a[i] > MaxWert)
                {

                    MaxWert = a[i];
                    MaxwertIndex = i;

                }

                if (a[i] < Minwert)
                {

                    Minwert = a[i];
                    MinwertIndex = i;

                }
                /* Min/Max ausgeben */
                LblAnzeige.Text = "Max. Wert: " + MaxWert + " bei Index " + MaxwertIndex + "\n" + "Min. Wert: " + Minwert + " bei Index " + MinwertIndex;
            }

        }

        private void CmdAnzeigen3_Click(object sender, EventArgs e)
        {
            int[] a = new int[7], b = new int[7];
            int SuchIndex;

            for(int i = 0; i<a.Length; i++)
            {
                a[i] = r.Next(20, 31);
            }

            b = (int[])a.Clone();

            Array.Sort(b);

            LstDaten.Items.Clear();
            for (int i = 0; i < a.Length; i++)
            {

                LstDaten.Items.Add(b[i]);
            }
            SuchIndex = Array.IndexOf(b, 25);
            LblAnzeige.Text = "Gesuchter Wert 25 bei Index: " + SuchIndex;


        }
    }
}
