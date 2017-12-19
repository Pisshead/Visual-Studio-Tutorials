using System;
using System.IO;
using System.Windows.Forms;

namespace DateiSicherSchreiben
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAusnahme_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamWriter sw;
            string dateiname = @"C:\Temp\Daten\aus.txt";

            try
            {
                fs = new FileStream(dateiname, FileMode.Create);
                sw = new StreamWriter(fs);
                sw.WriteLine(TxtEingabe.Text);
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
