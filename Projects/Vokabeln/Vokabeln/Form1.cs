using System;
using System.Windows.Forms;

using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;

namespace Vokabeln
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Liste der Fragen */
        private List<string> frage = new List<string>();

        /* Liste der Antworten */
        private List<string> antwort = new List<string>();

        /* Zufallszahl für ein Element der beiden Listen */
        private int zufallszahl;

        /* Richtung der Vokabel-Abfrage */
        private int richtung;

        /* Erzeugen und initialisieren des Zufallsgenerators */
        private Random r = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            /* Startrichtung Englisch - Deutsch */
            richtung = 2;
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader reader;

            con.ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
               "Data Source=C:\\Temp\\lernen.accdb";

            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM vokabel";

            frage.Clear();
            antwort.Clear();

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();

                /* Speicherung in den Listen gemäß
                   der ausgewählten Richtung */
                while (reader.Read())
                {
                    if (richtung == 1 || richtung == 3)
                        frage.Add((string)reader["deutsch"]);
                    else if (richtung == 2)
                        frage.Add((string)reader["englisch"]);
                    else
                        frage.Add((string)reader["französisch"]);

                    if (richtung == 2 || richtung == 4)
                        antwort.Add((string)reader["deutsch"]);
                    else if (richtung == 1)
                        antwort.Add((string)reader["englisch"]);
                    else
                        antwort.Add((string)reader["französisch"]);
                }

                reader.Close();
                con.Close();

                /* Buttons und Menü (de)aktivieren */
                CmdStart.Enabled = false;
                CmdPruefen.Enabled = true;
                MnuRichtung.Enabled = false;
                TxtAntwort.Enabled = true;

                /* Erste Vokabel erscheint */
                Naechste_Vokabel();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Naechste_Vokabel()
        {
            /* Falls keine Vokabel mehr in der Liste: Ende */
            if (frage.Count < 1)
            {
                MessageBox.Show("Gratuliere! Alles geschafft");
                Test_Init();
            }

            /* Falls noch Vokabeln in der Liste: Nächste */
            else
            {
                zufallszahl = r.Next(0, frage.Count);
                LblFrage.Text = "" + frage[zufallszahl];
                TxtAntwort.Text = "";
            }
        }

        private void Test_Init()
        {
            /* Buttons und Menü (de)aktivieren */
            CmdStart.Enabled = true;
            CmdPruefen.Enabled = false;
            MnuRichtung.Enabled = true;
            TxtAntwort.Enabled = false;

            /* Felder leeren */
            LblFrage.Text = "";
            TxtAntwort.Text = "";
        }

        private void CmdPruefen_Click(object sender, EventArgs e)
        {
            /* Falls richtig beantwortet: Vokabel aus Liste nehmen */
            if (TxtAntwort.Text == (string)antwort[zufallszahl])
            {
                MessageBox.Show("Richtig", "Vokabel");
                frage.RemoveAt(zufallszahl);
                antwort.RemoveAt(zufallszahl);
            }

            /* Falls falsch beantwortet: richtige Antwort nennen */
            else
                MessageBox.Show("Falsch, richtige Antwort" +
                    " ist\n'" + antwort[zufallszahl] +
                    "'", "Vokabel");

            /* Nächste Vokabel erscheint */
            Naechste_Vokabel();
        }

        private void MnuEndeTest_Click(object sender, EventArgs e)
        {
            /* Abbruch mit Rückfrage */
            if (MessageBox.Show("Test wirklich abbrechen?", "Vokabel",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                Test_Init();
        }

        private void MnuEndeProgramm_Click(object sender, EventArgs e)
        {
            /* Beenden mit Rückfrage */
            if (MessageBox.Show("Programm wirklich beenden?", "Vokabel",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void MnuDE_Click(object sender, EventArgs e)
        {
            /* Richtung wird geändert */
            richtung = 1;
            Check_False();
            MnuDE.Checked = true;
            LblRichtung.Text = "deutsch/englisch";
        }

        private void MnuED_Click(object sender, EventArgs e)
        {
            richtung = 2;
            Check_False();
            MnuED.Checked = true;
            LblRichtung.Text = "englisch/deutsch";
        }

        private void MnuDF_Click(object sender, EventArgs e)
        {
            richtung = 3;
            Check_False();
            MnuDF.Checked = true;
            LblRichtung.Text = "deutsch/französisch";
        }

        private void MnuFD_Click(object sender, EventArgs e)
        {
            richtung = 4;
            Check_False();
            MnuFD.Checked = true;
            LblRichtung.Text = "französisch/deutsch";
        }

        private void Check_False()
        {
            MnuDE.Checked = false;
            MnuED.Checked = false;
            MnuDF.Checked = false;
            MnuFD.Checked = false;
        }

        private void MnuAnleitung_Click(object sender, EventArgs e)
        {
            FileStream fs;
            StreamReader sr;
            string dateiname = "hilfe.txt";
            string ausgabe;

            if (!File.Exists(dateiname))
            {
                MessageBox.Show("Die Datei " + dateiname +
                    " existiert nicht");
                return;
            }

            fs = new FileStream(dateiname, FileMode.Open);
            sr = new StreamReader(fs);

            ausgabe = "";
            while (sr.Peek() != -1)
                ausgabe += sr.ReadLine() + "\n";
            sr.Close();

            MessageBox.Show(ausgabe);
        }
    }
}
