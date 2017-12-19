using System;
using System.IO;
using System.Windows.Forms;

namespace DateiLesen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdLesen_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("ein.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string zeile;

            LblAnzeige.Text = "";
            while (sr.Peek() != -1)
            {
                zeile = sr.ReadLine();
                LblAnzeige.Text += zeile + "\n";
            }
            sr.Close();
        }
    }
}
