using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatenfeldDynamisch
{
    public partial class FrmDatenfeldDynamisch : Form
    {

        private Random r = new Random();
        private int[] a;

        public FrmDatenfeldDynamisch()
        {
            InitializeComponent();
        }

        private void CmdEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdOriginal_Click(object sender, EventArgs e)
        {

            a = new int[4];
            LstZahlen.Items.Clear();
            for(int i = 0; i< a.Length; i++)
            {

                a[i] = r.Next(20, 31);
                LstZahlen.Items.Add(a[i]);

            }

        }

        private void CmdFeldNeu_Click(object sender, EventArgs e)
        {

            Array.Resize(ref a, 6);
            LstZahlen.Items.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(20, 31);
                LstZahlen.Items.Add(a[i]);

            }

        }

        private void CmdFeldBestimmteGroesse_Click(object sender, EventArgs e)
        {

            Array.Resize(ref a, (int)NumGroesse.Value);
            LstZahlen.Items.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(20, 31);
                LstZahlen.Items.Add(a[i]);

            }

        }
    }
}
