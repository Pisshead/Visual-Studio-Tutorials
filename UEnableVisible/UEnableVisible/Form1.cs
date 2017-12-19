using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UEnableVisible
{
    public partial class FrmUEnabledVisible : Form
    {
        List<string> delete = new List<string>();
        List<string> helpdelete = new List<string>();
        List<string> reset = new List<string>();

    public FrmUEnabledVisible()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



           
                CmdLoeschen.Enabled = false;

           
                CmdReset.Visible = true;
            

            LstList.Items.Add("Liechtenstein");
            LstList.Items.Add("Malta");
            LstList.Items.Add("Andorra");
            LstList.Items.Add("San Marino");
            LstList.Items.Add("Monaco");


        }

       

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CmdLoeschen_Click(object sender, EventArgs e)
        {
            CmdReset.Enabled = true;
            foreach(string s in delete)
            {

                helpdelete.Add(s);
                reset.Add(s);
            }

            foreach(string s in helpdelete)
            {
                LstList.Items.Remove(s);

            }

            delete.Clear();
            helpdelete.Clear();

            CmdLoeschen.Enabled = false;

            if (LstList.Items.Count == 0)
            {

                CmdReset.Visible = true;
            }
        }

        private void CmdReset_Click(object sender, EventArgs e)
        {
       

                CmdLoeschen.Enabled = false;
                CmdReset.Enabled = false;

            if(LstList.Items.Count != 0)
            {

                foreach (string s in delete)
                {

                    reset.Add(s);
                }
                foreach(string s in reset)
                {

                    LstList.Items.Add(s);

                }
                delete.Clear();
                reset.Clear();
            }
            else
            {
                LstList.Items.Add("Liechtenstein");
                LstList.Items.Add("Malta");
                LstList.Items.Add("Andorra");
                LstList.Items.Add("San Marino");
                LstList.Items.Add("Monaco");

            }

           
        }

        private void Loeschen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LstList.Items.Count == 0)
            {

                CmdLoeschen.Enabled = false;

            }
            else
            {
                CmdLoeschen.Enabled = true;

            }

            foreach (string s in LstList.SelectedItems)
                if (delete.Contains(s))
                {
                    

                }
                else
                { delete.Add(s); }
        }

        private void CmdEnde_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
