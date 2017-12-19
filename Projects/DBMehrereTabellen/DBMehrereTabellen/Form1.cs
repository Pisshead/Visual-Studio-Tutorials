using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DBMehrereTabellen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Auswahl(string sqlbefehl, params string[] felder)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader reader;
            int i;
            string zeile;

            con.ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=C:\\Temp\\projektverwaltung.accdb";

            cmd.Connection = con;
            cmd.CommandText = sqlbefehl;

            try
            {
                con.Open();

                reader = cmd.ExecuteReader();
                LstAnzeige.Items.Clear();
                while (reader.Read())
                {
                    zeile = "";
                    for (i = 0; i < felder.Length; i++)
                        zeile += reader[felder[i]] + " # ";
                    LstAnzeige.Items.Add(zeile);
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmdAllePersonen_Click(object sender, EventArgs e)
        {
            Auswahl("SELECT * FROM person ORDER BY pe_nachname, pe_vorname", "pe_nachname", "pe_vorname");
        }

        private void CmdAnzahlKunden_Click(object sender, EventArgs e)
        {
            Auswahl("SELECT COUNT(ku_id) AS count_ku_id FROM kunde", "count_ku_id");
        }

        private void CmdAlleKundenAlleProjekte_Click(object sender, EventArgs e)
        {
            Auswahl("SELECT ku_name, ku_ort, pr_bezeichnung FROM kunde INNER JOIN projekt ON kunde.ku_id = projekt.pr_ku_id ORDER BY ku_name, ku_ort, pr_bezeichnung", "ku_name", "ku_ort", "pr_bezeichnung");
        }

        private void CmdAllePersonenAlleProjektzeiten_Click(object sender, EventArgs e)
        {
            Auswahl("SELECT pe_nachname, pr_bezeichnung, pp_datum, pp_zeit FROM projekt INNER JOIN(person INNER JOIN projekt_person ON person.pe_id = projekt_person.pe_id) ON projekt.pr_id = projekt_person.pr_id ORDER BY pe_nachname, pr_bezeichnung, pp_datum", "pe_nachname", "pr_bezeichnung", "pp_datum");
        }

        private void CmdAllePersonenZeitsumme_Click(object sender, EventArgs e)
        {
            Auswahl("SELECT pe_nachname, SUM(pp_zeit) AS sum_pp_zeit FROM person INNER JOIN projekt_person ON person.pe_id = projekt_person.pe_id GROUP BY person.pe_id, pe_nachname ORDER BY pe_nachname", "pe_nachname", "sum_pp_zeit");
        }

        private void CmdAlleProjekteAllePersonenzeiten_Click(object sender, EventArgs e)
        {
            Auswahl("SELECT pr_bezeichnung, pp_datum, pe_nachname, pp_zeit FROM projekt INNER JOIN(person INNER JOIN projekt_person ON person.pe_id = projekt_person.pe_id) ON projekt.pr_id = projekt_person.pr_id ORDER BY pr_bezeichnung, pe_nachname, pp_datum", "pr_bezeichnung", "pe_nachname", "pp_datum");
        }

        private void CmdAlleProjekteZeitsumme_Click(object sender, EventArgs e)
        {
            Auswahl("SELECT pr_bezeichnung, SUM(pp_zeit) AS sum_pp_zeit FROM projekt INNER JOIN projekt_person ON projekt.pr_id = projekt_person.pr_id GROUP BY projekt.pr_id, pr_bezeichnung ORDER BY pr_bezeichnung", "pr_bezeichnung", "sum_pp_zeit");
        }
    }
}
