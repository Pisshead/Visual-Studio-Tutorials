using System;
using System.Windows.Forms;

namespace MehrereFormulare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdStartUnter_Click(object sender, EventArgs e)
        {
            Form2 fu = new Form2(this);
            fu.ShowDialog();
            // Close();
        }

        private void CmdEndeHaupt_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
