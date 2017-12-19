using System;
using System.Windows.Forms;

namespace MethodenRueckgabe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdAnzeigen_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = 12;
            b = 17;
            c = MaxWert(a, b);
            LblAnzeige.Text = "Maximum: " + c;
        }

        private int MaxWert(int x, int y)
        {
            if (x > y)
                return x;
            else
                return y;
        }
    }
}
