using System;
using System.Windows;

namespace WPFFormsInside
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WPF_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hallo WPF");
        }

        private void WFO_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Wfh.Child.Text);
        }
    }
}
