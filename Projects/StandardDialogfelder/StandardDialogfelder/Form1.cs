using System;
using System.Windows.Forms;

namespace StandardDialogfelder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdOpenFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Multiselect = true,
                InitialDirectory = "C:\\Temp",
                Filter = "Tabellen (*.xlsx)|*.xlsx|" +
                    " Texte (*.txt; *docx)|*.txt;*.docx|" +
                    " Alle Dateien (*.*)|*.*",
                Title = "Datei zum Öffnen auswählen"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
                foreach (string s in ofd.FileNames)
                    MessageBox.Show("Öffnen: " + s);
            else
                MessageBox.Show("Abbruch");
        }

        private void CmdSaveFileDialog_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                InitialDirectory = "C:\\Temp",
                Filter = "Tabellen (*.xlsx)|*.xlsx|" +
                " Texte (*.txt; *docx)|*.txt;*.docx|" +
                " Alle Dateien (*.*)|*.*",
                Title = "Datei zum Speichern auswählen"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Speichern unter: " + sfd.FileName);
            else
                MessageBox.Show("Abbruch");
        }

        private void CmdFolderBrowserDialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog()
            {
                RootFolder = Environment.SpecialFolder.Desktop,
                ShowNewFolderButton = false,
                Description = "Verzeichnis auswählen"
            };

            if (fbd.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Zugriff auf Verzeichnis: " +
                    fbd.SelectedPath);
            else
                MessageBox.Show("Abbruch");
        }

        private void CmdColorDialog_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();

            if (cd.ShowDialog() == DialogResult.OK)
                LblAnzeige.ForeColor = cd.Color;
            else
                MessageBox.Show("Abbruch");
        }

        private void CmdFontDialog_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog()
            {
                ShowColor = true,
                MinSize = 8,
                MaxSize = 20
            };

            if (fd.ShowDialog() == DialogResult.OK)
            {
                LblAnzeige.Font = fd.Font;
                LblAnzeige.ForeColor = fd.Color;
            }
            else
                MessageBox.Show("Abbruch");
        }
    }
}
