using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListenfeldMethoden
{
    public partial class FrmListenMethoden : Form
    {
        List<String> saved = new List<String>();

        public FrmListenMethoden()
        {
            InitializeComponent();
        }

        private void CmdLoeschen_Click(object sender, EventArgs e)
        {
            save();

            int x = LstSpeisen.SelectedIndex;
            if (x != -1)
            {

                LstSpeisen.Items.RemoveAt(x);

            }

        }

        private void CmdNeu_Click(object sender, EventArgs e)
        {
            save();

            if (TxtNeu.Text == "")
            {

                return;

            }

            if (OptAnfang.Checked)
            {

                LstSpeisen.Items.Insert(0, TxtNeu.Text);

            }
            else if (OptStelle.Checked) {

                if (LstSpeisen.SelectedIndex != -1)
                {

                    LstSpeisen.Items.Insert(
                        LstSpeisen.SelectedIndex, TxtNeu.Text
                        );

                }

                

                }
            else
            {

                LstSpeisen.Items.Add(TxtNeu.Text);

                TxtNeu.Text = "";

            }


        }

        private void CmdReplace_Click(object sender, EventArgs e)
        {
            save();

            int x = LstSpeisen.SelectedIndex;

            if(TxtReplace.Text != "" && x != -1)
            {


                LstSpeisen.Items.RemoveAt(x);
                LstSpeisen.Items.Insert(x, TxtReplace.Text);
                TxtReplace.Text = "";

            }

        }

        private void CmdClearAll_Click(object sender, EventArgs e)
        {
            save();
            LstSpeisen.Items.Clear();

        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdUndo_Click(object sender, EventArgs e)
        {
            LstSpeisen.Items.Clear();

            foreach (string s in saved)
            {
                
                LstSpeisen.Items.Add(s);

            }
        }

        public void save()
        {
            saved = LstSpeisen.Items.OfType<String>().ToList();



                    


        }

        private void Auswahl_SelectedIndexChanged(object sender, EventArgs e)
        {


            LblAuswahl.Text = "Aktive Auswahl:\n\n";
            foreach (string s in LstSpeisen.SelectedItems)
                LblAuswahl.Text += s + "\n";

        }
    }
}
