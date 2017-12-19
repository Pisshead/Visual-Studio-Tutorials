using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DBZugriffAccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAlleSehen_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader reader;

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=C:\\Temp\\firma.accdb";

            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM personen";

            try
            {
                con.Open();

                reader = cmd.ExecuteReader();
                LstAnzeige.Items.Clear();
                while (reader.Read())
                {
                    LstAnzeige.Items.Add(reader["name"] + " # " +
                        reader["vorname"] + " # " +
                        reader["personalnummer"] + " # " +
                        reader["gehalt"] + " # " + reader["geburtstag"]);
                }

                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CmdAendern_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            int anzahl;
            string op;

            con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                "Data Source=C:\\Temp\\firma.accdb";

            cmd.Connection = con;

            if (sender == CmdErhoehen)
                op = "*";
            else
                op = "/";
            cmd.CommandText =
                "UPDATE personen SET gehalt = gehalt " + op + " 1.05";

            try
            {
                con.Open();

                anzahl = cmd.ExecuteNonQuery();
                MessageBox.Show("Datensätze geändert: " + anzahl);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
