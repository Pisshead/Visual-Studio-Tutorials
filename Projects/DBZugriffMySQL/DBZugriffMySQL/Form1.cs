using System;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace DBZugriffMySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAlleSehen_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            MySqlDataReader reader;
            DateTime geburtstag;

            con.ConnectionString = "Data Source=localhost;" +
                "Initial Catalog=firma;UID=root";

            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM personen";

            try
            {
                con.Open();

                reader = cmd.ExecuteReader();
                LstAnzeige.Items.Clear();
                while (reader.Read())
                {
                    geburtstag = Convert.ToDateTime(reader["geburtstag"]);

                    LstAnzeige.Items.Add(
                        reader["name"] + " # " +
                        reader["vorname"] + " # " +
                        reader["personalnummer"] + " # " +
                        reader["gehalt"] + " # " +
                        geburtstag.ToShortDateString());
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
            MySqlConnection con = new MySqlConnection();
            MySqlCommand cmd = new MySqlCommand();
            int anzahl;
            string op;

            con.ConnectionString = "Data Source=localhost;" +
                "Initial Catalog=firma;UID=root";

            cmd.Connection = con;

            if (sender == CmdErhoehen)
                op = "*";
            else
                op = "/";
            cmd.CommandText = "UPDATE personen SET" +
                " gehalt = gehalt " + op + " 1.05";

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
