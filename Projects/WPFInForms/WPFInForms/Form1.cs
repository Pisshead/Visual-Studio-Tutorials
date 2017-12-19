using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace WPFInForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            System.Windows.Controls.Button nb =
                new System.Windows.Controls.Button()
                {
                    Content = "WPF Button"
                };
            nb.Click += new RoutedEventHandler(Nb_Click);
            EHost1.Child = nb;

            StackPanel sp = new StackPanel();
            for (int i = 1; i <= 3; i++)
            {
                TextBlock tb = new TextBlock()
                {
                    Text = "Inhalt " + i
                };
                sp.Children.Add(tb);
            }
            Expander ep = new Expander()
            {
                Header = "WPF Expander",
                Content = sp
            };
            EHost2.Child = ep;
        }

        private void Nb_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show((sender as System.Windows.Controls.Button).Content + "");
        }

        private void WFO_Button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Windows Forms Button");
        }
    }
}
