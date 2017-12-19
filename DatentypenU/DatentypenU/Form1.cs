using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatentypenU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeige_Click(object sender, EventArgs e)
        {

            string firstName = "Joël";
            string lastName = "Schöni";
            string street = "Südbahnhofstrasse";
            int housenumber = 10;
            string additional = "";
            int PLZ = 3007;
            string city = "Bern";

            int age = 34;
            double salary = 2136.55;

            LblAnzeige.Text = "Name: " + firstName + " " + lastName + "\n" + "Adresse: " + street + " " + housenumber + "\n" 
                
                + "Wohnort: " + PLZ + " " + city + "\n\n" + "Alter: " + age + "\n" + "Gehalt: " + salary;





        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
