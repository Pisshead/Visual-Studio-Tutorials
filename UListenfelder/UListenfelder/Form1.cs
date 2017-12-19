using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UListenfelder
{
    public partial class FrmUListenfelder : Form
    {
        List<String> willGoToTheRight = new List<String>();
        List<String> willGoToTheLeft = new List<String>();

        public FrmUListenfelder()
        {
            InitializeComponent();
        }

        private void FrmUListenfelder_Load(object sender, EventArgs e)
        {
            LstLaenderRechts.Sorted = true;
            LstLaenderLinks.Sorted = true;

            LstLaenderLinks.Items.Add("Malta");
            LstLaenderLinks.Items.Add("Zypern");
            LstLaenderLinks.Items.Add("Slowenien");
            LstLaenderLinks.Items.Add("Estland");
            LstLaenderLinks.Items.Add("Rumänien");

            LstLaenderRechts.Items.Add("Belgien");
            LstLaenderRechts.Items.Add("Spanien");
            LstLaenderRechts.Items.Add("Italien");
            LstLaenderRechts.Items.Add("Portugal");
            LstLaenderRechts.Items.Add("Dänemark");

        }

        private void CmdToTheRight_Click(object sender, EventArgs e)
        {
            foreach (string s in LstLaenderLinks.SelectedItems)
            {

                willGoToTheRight.Add(s);

            }



            foreach ( string s in willGoToTheRight)
            {

                LstLaenderRechts.Items.Add(s);
                LstLaenderLinks.Items.Remove(s);
                


            }

            willGoToTheRight.Clear();
            LstLaenderRechts.Sorted = true;
            LstLaenderLinks.Sorted = true;


        }

        private void Links_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblLinks.Text = "These countries will go to the right:\n";

            

            foreach(string s in LstLaenderLinks.SelectedItems)
            {

                
                LblLinks.Text +=  s + "\n";
               

            }

          

        }

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        
        }

        private void CmdReset_Click(object sender, EventArgs e)
        {

            LstLaenderLinks.Items.Clear();
            LstLaenderRechts.Items.Clear();

            LstLaenderLinks.Items.Add("Malta");
            LstLaenderLinks.Items.Add("Zypern");
            LstLaenderLinks.Items.Add("Slowenien");
            LstLaenderLinks.Items.Add("Estland");
            LstLaenderLinks.Items.Add("Rumänien");

            LstLaenderRechts.Items.Add("Belgien");
            LstLaenderRechts.Items.Add("Spanien");
            LstLaenderRechts.Items.Add("Italien");
            LstLaenderRechts.Items.Add("Portugal");
            LstLaenderRechts.Items.Add("Dänemark");

        }

        private void CmdToTheLeft_Click(object sender, EventArgs e)
        {

            foreach (string s in LstLaenderRechts.SelectedItems)
            {

                willGoToTheLeft.Add(s);

            }



            foreach (string s in willGoToTheLeft)
            {

                LstLaenderLinks.Items.Add(s);
                LstLaenderRechts.Items.Remove(s);



            }

            willGoToTheLeft.Clear();
            LstLaenderRechts.Sorted = true;
            LstLaenderLinks.Sorted = true;

        }

        private void Rechts_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblRechts.Text = "These countries will go to the left:\n";



            foreach (string s in LstLaenderRechts.SelectedItems)
            {


                LblRechts.Text += s + "\n";


            }
        }
    }
}
