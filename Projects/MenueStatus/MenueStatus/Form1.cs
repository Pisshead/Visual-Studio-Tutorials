using System;
using System.Drawing;
using System.Windows.Forms;

namespace MenueStatus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private double endeZeit;

        private void Form1_Load(object sender, EventArgs e)
        {
            CboSchriftgroesse.Items.Add("8,25");
            CboSchriftgroesse.Items.Add("10");
            CboSchriftgroesse.Items.Add("13");
            CboSchriftgroesse.Items.Add("18");
            CboSchriftgroesse.SelectedIndex = 0;

            CboSymSchriftgroesse.Items.Add("8,25");
            CboSymSchriftgroesse.Items.Add("10");
            CboSymSchriftgroesse.Items.Add("13");
            CboSymSchriftgroesse.Items.Add("18");
            CboSymSchriftgroesse.SelectedIndex = 0;

            StaLabelZeit.Text = DateTime.Today.ToShortDateString();
        }

        private void MnuKopieren_Click(object sender, EventArgs e)
        {
            LblAnzeige.Text = TxtEingabe.Text;
            if (LblAnzeige.Text == "")
                LblAnzeige.Text = "(leer)";
        }

        private void MnuEnde_Click(object sender, EventArgs e)
        {
            endeZeit = 0;
            TimEndezeit.Enabled = true;
        }

        private void TimEndezeit_Tick(object sender, EventArgs e)
        {
            endeZeit += 0.1;
            if (endeZeit >= 5)
                Close();
            else
                StaProgressEnde.Value = (int)endeZeit;
        }

        private void MnuGelb_Click(object sender, EventArgs e)
        {
            LblAnzeige.BackColor = Color.Yellow;
            MnuGelb.Checked = true;
            MnuBlau.Checked = false;
            MnuRot.Checked = false;
        }

        private void MnuBlau_Click(object sender, EventArgs e)
        {
            LblAnzeige.BackColor = Color.Blue;
            MnuGelb.Checked = false;
            MnuBlau.Checked = true;
            MnuRot.Checked = false;
        }

        private void MnuRot_Click(object sender, EventArgs e)
        {
            LblAnzeige.BackColor = Color.Red;
            MnuGelb.Checked = false;
            MnuBlau.Checked = false;
            MnuRot.Checked = true;
        }

        private void MnuCourierNew_Click(object sender, EventArgs e)
        {
            LblAnzeige.Font = new Font(
                "Courier New", LblAnzeige.Font.Size, LblAnzeige.Font.Style);
            MnuCourierNew.Checked = true;
            MnuSymbol.Checked = false;
            MnuArial.Checked = false;
        }

        private void MnuSymbol_Click(object sender, EventArgs e)
        {
            LblAnzeige.Font = new Font(
                "Symbol", LblAnzeige.Font.Size, LblAnzeige.Font.Style);
            MnuCourierNew.Checked = false;
            MnuSymbol.Checked = true;
            MnuArial.Checked = false;
        }

        private void MnuArial_Click(object sender, EventArgs e)
        {
            LblAnzeige.Font = new Font(
                "Arial", LblAnzeige.Font.Size, LblAnzeige.Font.Style);
            MnuCourierNew.Checked = false;
            MnuSymbol.Checked = false;
            MnuArial.Checked = true;
        }

        private void MnuFett_Click(object sender, EventArgs e)
        {
            LblAnzeige.Font = new Font(LblAnzeige.Font.FontFamily, LblAnzeige.Font.Size,
                LblAnzeige.Font.Style ^ FontStyle.Bold);
            MnuFett.Checked = !MnuFett.Checked;
            ConLblFett.Checked = !ConLblFett.Checked;
            SymFett.Checked = !SymFett.Checked;
        }

        private void MnuKursiv_Click(object sender, EventArgs e)
        {
            LblAnzeige.Font = new Font(LblAnzeige.Font.FontFamily, LblAnzeige.Font.Size,
                LblAnzeige.Font.Style ^ FontStyle.Italic);
            MnuKursiv.Checked = !MnuKursiv.Checked;
            SymKursiv.Checked = !SymKursiv.Checked;
        }

        private void CboSchriftgroesse_TextChanged(object sender, EventArgs e)
        {
            double schriftgroesse;
            ToolStripComboBox cb = sender as ToolStripComboBox;

            try
            {
                schriftgroesse = Convert.ToDouble(cb.Text);
            }
            catch
            {
                schriftgroesse = 8.25;
            }

            CboSchriftgroesse.Text = "" + schriftgroesse;
            CboSymSchriftgroesse.Text = "" + schriftgroesse;

            LblAnzeige.Font = new Font(LblAnzeige.Font.FontFamily, (float)schriftgroesse, LblAnzeige.Font.Style);
        }

        private void ConTxtReadOnly_Click(object sender, EventArgs e)
        {
            TxtEingabe.ReadOnly = !TxtEingabe.ReadOnly;
            ConTxtReadOnly.Checked = !ConTxtReadOnly.Checked;
        }

        private void ConTxtMultiline_Click(object sender, EventArgs e)
        {
            TxtEingabe.Multiline = !TxtEingabe.Multiline;

            if (TxtEingabe.Multiline)
                TxtEingabe.ScrollBars = ScrollBars.Vertical;
            else
                TxtEingabe.ScrollBars = ScrollBars.None;
            ConTxtMultiline.Checked = !ConTxtMultiline.Checked;
        }
    }
}
