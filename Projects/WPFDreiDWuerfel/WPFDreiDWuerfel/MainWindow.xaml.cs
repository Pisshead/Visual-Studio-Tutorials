using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Media3D;

namespace WPFDreiDWuerfel
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

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.V)
            {
                Oc.Position = new Point3D(1, 3, 5);
                Oc.LookDirection = new Vector3D(-1, -3, -5);
                Dl.Direction = new Vector3D(-1, -3, -5);
                Title = "WPFDreiDWuerfel, von vorne";
            }
            else if (e.Key == Key.H)
            {
                Oc.Position = new Point3D(-1, -3, -5);
                Oc.LookDirection = new Vector3D(1, 3, 5);
                Dl.Direction = new Vector3D(1, 3, 5);
                Title = "WPFDreiDWuerfel, von hinten";
            }
        }
    }
}
