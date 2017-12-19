using System;
using System.Windows.Forms;

namespace UDatenfeldEindimensional
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Random r = new Random();

        private void CmdMinima_Click(object sender, EventArgs e)
        {
            int[] a = new int[10];
            int MinWert;

            LstZahl.Items.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(20, 31);
                LstZahl.Items.Add(a[i]);
            }

            MinWert = a[0];
            for (int i = 0; i < a.Length; i++)
                if (a[i] < MinWert)
                    MinWert = a[i];

            LblAnzeige.Text = "Minimum: " + MinWert + "\n";
            for (int i = 0; i < a.Length; i++)
                if (a[i] == MinWert)
                    LblAnzeige.Text += "an Position: " + i + "\n";
        }
    }
}
