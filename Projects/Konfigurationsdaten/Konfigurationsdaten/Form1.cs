using System;
using System.Windows.Forms;

using System.Data.OleDb;
using System.Collections.Specialized;
using System.Configuration;

namespace Konfigurationsdaten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            /* Konfigurationsdatei lesen */
            NameValueCollection appset = ConfigurationSettings.AppSettings;

            /* Verbindung einrichten */
            OleDbConnection con = new OleDbConnection();
            con.ConnectionString =
                "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                appset["DBVerzeichnis"] + "\\firma.accdb";

            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader reader;

            cmd.Connection = con;
            cmd.CommandText = "select * from personen";

            try
            {
                con.Open();

                reader = cmd.ExecuteReader();
                LstAnzeige.Items.Clear();
                while (reader.Read())
                {
                    LstAnzeige.Items.Add(
                        reader["name"] + " # " +
                        reader["vorname"] + " # " +
                        reader["personalnummer"] + " # " +
                        reader["gehalt"] + " # " +
                        reader["geburtstag"]);
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
