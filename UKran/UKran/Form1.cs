using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UKran
{
    public partial class FrmKran : Form
    {
        public FrmKran()
        {
            InitializeComponent();
        }

        private void CmdHakenNachOben_Click(object sender, EventArgs e)
        {
            TimHakenAbsenken.Enabled = false;
            TimHakenAnheben.Enabled = true;

           


        }

        private void CmdHakenNachUnten_Click(object sender, EventArgs e)
        {
            TimHakenAnheben.Enabled = false;
            TimHakenAbsenken.Enabled = true;
               


        }

        private void CmdKranNachRechts_Click(object sender, EventArgs e)
        {
            TimKranNachLinks.Enabled = false;
            TimKranNachRechts.Enabled = true;
        

        }

        private void CmdKranNachLinks_Click(object sender, EventArgs e)
        {
            TimKranNachRechts.Enabled = false;
            TimKranNachLinks.Enabled = true;


        }

        private void CmdAusleger_Click(object sender, EventArgs e)
        {
            TimAuslegerNachRechts.Enabled = false;
            TimAuslegerNachLinks.Enabled = true;

            

        }

        private void CmdAuslegerNachRechts_Click(object sender, EventArgs e)
        {

            TimAuslegerNachLinks.Enabled = false;
            TimAuslegerNachRechts.Enabled = true;


        }


       

        private void CmdEnde_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TimStart_Tick(object sender, EventArgs e)
        {

            if (pHaken.Location.Y + pHaken.Size.Height - 20 > pHaken.Location.Y)
            {


                pHaken.Size = new Size(

            pHaken.Size.Width, pHaken.Size.Height - 5

            );



            }


        }

        private void CmdStop_Click(object sender, EventArgs e)
        {

            TimHakenAnheben.Enabled = false;
            TimKranNachLinks.Enabled = false;
            TimKranNachRechts.Enabled = false;
            TimHakenAbsenken.Enabled = false;
            TimAuslegerNachLinks.Enabled = false;
            TimAuslegerNachRechts.Enabled = false;


        }

        private void TimKranNachLinks_Tick(object sender, EventArgs e)
        {
            

            if (pWaagrecht.Location.X > 10)
            {

                pHaken.Location = new Point(pHaken.Location.X - 5, pHaken.Location.Y);
                pWaagrecht.Location = new Point(pWaagrecht.Location.X - 5, pWaagrecht.Location.Y);
                pFundament.Location = new Point(pFundament.Location.X - 5, pFundament.Location.Y);
                pSenkrecht.Location = new Point(pSenkrecht.Location.X - 5, pSenkrecht.Location.Y);
            }


        }

        private void TimKranNachRechts_Tick(object sender, EventArgs e)
        {
            

            if (pWaagrecht.Location.X + pWaagrecht.Size.Width + 10 < CmdEnde.Location.X)
            {

                pHaken.Location = new Point(pHaken.Location.X + 5, pHaken.Location.Y);
                pWaagrecht.Location = new Point(pWaagrecht.Location.X + 5, pWaagrecht.Location.Y);
                pFundament.Location = new Point(pFundament.Location.X + 5, pFundament.Location.Y);
                pSenkrecht.Location = new Point(pSenkrecht.Location.X + 5, pSenkrecht.Location.Y);



            }

        }

        private void TimHakenAbsenken_Tick(object sender, EventArgs e)
        {
            


            if (pHaken.Location.Y + pHaken.Size.Height + 5 < pFundament.Location.Y)
            {


                pHaken.Size = new Size(

         pHaken.Size.Width, pHaken.Size.Height + 5

         );

            }

        }

        private void TimAuslegerNachRechts_Tick(object sender, EventArgs e)
        {


            if (pHaken.Location.X + pHaken.Size.Width + 10 < pSenkrecht.Location.X) {

                pHaken.Location = new Point(pHaken.Location.X + 5, pHaken.Location.Y);
            }
                

        }

        private void TimAuslegerNachLinks_Tick(object sender, EventArgs e)
        {

            if (pHaken.Location.X - 10 > pWaagrecht.Location.X)
            {

                pHaken.Location = new Point(pHaken.Location.X - 5, pHaken.Location.Y);

            }

        }
    }
}
