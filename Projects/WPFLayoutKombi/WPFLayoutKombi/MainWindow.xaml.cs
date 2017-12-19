using System.Windows;
using System.Windows.Controls;

namespace WPFLayoutKombi
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

        private void B1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("B1");
        }

        private void B2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("B2");
        }

        private void Sp_Click(object sender, RoutedEventArgs e)
        {
            Button b = e.Source as Button;
            MessageBox.Show(b.Name);
        }
    }
}
