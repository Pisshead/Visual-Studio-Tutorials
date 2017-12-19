using System;
using System.Windows.Forms;

namespace MehrereFormulare
{
    public partial class Form2 : Form
    {
        private Form1 fh;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 aufrufer)
        {
            fh = aufrufer;
            // fh.Hide();
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TxtUnter.Text = fh.Controls["TxtHaupt"].Text;

            CheckBox cb = fh.Controls["ChkHaupt"] as CheckBox;
            ChkUnter.Checked = cb.Checked;
        }

        private void CmdEndeUnter_Click(object sender, EventArgs e)
        {
            fh.Controls["TxtHaupt"].Text = TxtUnter.Text;

            CheckBox cb = fh.Controls["ChkHaupt"] as CheckBox;
            cb.Checked = ChkUnter.Checked;

            // fh.Show();
            Close();
        }
    }
}
