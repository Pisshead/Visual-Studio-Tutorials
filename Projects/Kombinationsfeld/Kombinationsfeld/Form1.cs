﻿using System;
using System.Windows.Forms;

namespace Kombinationsfeld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CmbWerkzeug1.Items.Add("Zange");
            CmbWerkzeug1.Items.Add("Hammer");
            CmbWerkzeug1.Items.Add("Bohrer");
            CmbWerkzeug1.Items.Add("Schraubendreher");

            CmbWerkzeug2.Items.Add("Zange");
            CmbWerkzeug2.Items.Add("Hammer");
            CmbWerkzeug2.Items.Add("Bohrer");
            CmbWerkzeug2.Items.Add("Schraubendreher");

            CmbWerkzeug3.Items.Add("Zange");
            CmbWerkzeug3.Items.Add("Hammer");
            CmbWerkzeug3.Items.Add("Bohrer");
            CmbWerkzeug3.Items.Add("Schraubendreher");
        }

        private void CmdAnzeige1_Click(object sender, EventArgs e)
        {
            LblAnzeige1.Text = "Auswahl: " + CmbWerkzeug1.Text;
        }

        private void CmdAnzeige2_Click(object sender, EventArgs e)
        {
            LblAnzeige2.Text = "Auswahl: " + CmbWerkzeug2.Text;
        }

        private void CmdAnzeige3_Click(object sender, EventArgs e)
        {
            LblAnzeige3.Text = "Auswahl: " + CmbWerkzeug3.Text;
        }
    }
}
