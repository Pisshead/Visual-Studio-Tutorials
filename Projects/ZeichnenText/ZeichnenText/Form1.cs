using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZeichnenText
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Graphics z;
        private Font f = new Font("Arial", 16);
        private SolidBrush pinsel = new SolidBrush(Color.Red);
        private Color[] colorFeld = { Color.Red, Color.Green, Color.Blue };

        private void Form1_Load(object sender, EventArgs e)
        {
            z = CreateGraphics();

            LstSchriftart.Items.Add("Arial");
            LstSchriftart.Items.Add("Courier New");
            LstSchriftart.Items.Add("Symbol");
            LstSchriftart.SelectedIndex = 0;

            LstFarbe.Items.Add("Rot");
            LstFarbe.Items.Add("Grün");
            LstFarbe.Items.Add("Blau");
            LstFarbe.SelectedIndex = 0;
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            z.DrawString(TxtEingabe.Text, f, pinsel, 20, 20);
        }

        private void LstSchriftart_SelectedIndexChanged(object sender, EventArgs e)
        {
            f = new Font(LstSchriftart.Text, f.Size);
        }

        private void NumSchriftgroesse_ValueChanged(object sender, EventArgs e)
        {
            f = new Font(f.FontFamily, (float)NumSchriftgroesse.Value);
        }

        private void LstFarbe_SelectedIndexChanged(object sender, EventArgs e)
        {
            pinsel.Color = colorFeld[LstFarbe.SelectedIndex];
        }

        private void CmdLoeschen_Click(object sender, EventArgs e)
        {
            z.Clear(BackColor);
        }
    }
}
