using System;
using System.IO;
using System.Windows.Forms;

namespace DateiVerzeichnisListe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(@"C:\Temp"))
                Directory.SetCurrentDirectory(@"C:\Temp");
            else
                MessageBox.Show(@"Verzeichnis C:\Temp existiert nicht");
            LblAktuellesVerzeichnis.Text = Directory.GetCurrentDirectory();
        }

        private void CmdDateiliste_Click(object sender, EventArgs e)
        {
            string verzeichnis;
            string[] dateiliste;

            verzeichnis = Directory.GetCurrentDirectory();
            dateiliste = Directory.GetFiles(verzeichnis);
            LstAnzeige.Items.Clear();
            foreach (string s in dateiliste)
                LstAnzeige.Items.Add(s);
        }

        private void CmdSystemEintraege_Click(object sender, EventArgs e)
        {
            SystemEintraege();
        }


        private void SystemEintraege()
        {
            string verzeichnis;
            string[] dateiliste;

            verzeichnis = Directory.GetCurrentDirectory();
            dateiliste = Directory.GetFileSystemEntries(verzeichnis);
            LstAnzeige.Items.Clear();
            foreach (string s in dateiliste)
                LstAnzeige.Items.Add(s);
        }

        private void LstAnzeige_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name;

            if (LstAnzeige.SelectedIndex != -1)
            {
                name = LstAnzeige.Text;
                LblAnzeige.Text = name + "\nErzeugt: " +
                    File.GetCreationTime(name) + "\nLetzter Zugriff: " +
                    File.GetLastAccessTime(name) + "\n" + "Letzter " +
                    "Schreibzugriff:" + File.GetLastWriteTime(name);
            }
            else
                MessageBox.Show("Kein Eintrag ausgewählt");
        }

        private void CmdInVerzeichnis_Click(object sender, EventArgs e)
        {
            if (LstAnzeige.SelectedIndex != -1)
            {
                try
                {
                    Directory.SetCurrentDirectory(LstAnzeige.Text);
                }
                catch
                {
                    MessageBox.Show(LstAnzeige.Text + " ist kein Verzeichnis");
                }
            }
            else
                MessageBox.Show("Kein Eintrag ausgewählt");

            LblAktuellesVerzeichnis.Text = Directory.GetCurrentDirectory();
            SystemEintraege();
        }

        private void CmdNachOben_Click(object sender, EventArgs e)
        {
            Directory.SetCurrentDirectory("..");
            LblAktuellesVerzeichnis.Text = Directory.GetCurrentDirectory();
            SystemEintraege();
        }
    }
}
