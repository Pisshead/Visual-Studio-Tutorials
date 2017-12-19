using System.Windows;
using System.Windows.Controls;

namespace WPFSteuerelemente
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

        private void Cb_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("eingeschaltet");
        }

        private void Cb_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ausgeschaltet");
        }

        private void Bu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Tb.Text + " / " + Tb.SelectedText);
        }

        private void Lb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (IsLoaded)
            {
                string ausgabe = "";
                foreach (ListBoxItem lbi in Lb.SelectedItems)
                    ausgabe += lbi.Content + " ";
                MessageBox.Show(ausgabe);
            }
        }

        private void Sl_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (IsLoaded)
                MessageBox.Show(Sl.Value + "");
        }
    }
}
