﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeinErstes

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdHallo_Click(object sender, EventArgs e)
        {

            /*Diese Anweisung fügt "Hallo"
             * in das Label ein */

            LblAnzeige.Text = "Hallo";

        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            /* Diese ANweisung beendet
             * das Programm*/

            Close();

        }
    }
}
