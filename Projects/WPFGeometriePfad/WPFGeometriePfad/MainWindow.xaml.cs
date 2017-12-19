using System.Windows;
using System.Windows.Media;

namespace WPFGeometriePfad
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

        private void Aendern_Click(object sender, RoutedEventArgs e)
        {
            PathGeometry pg = Pt.Data as PathGeometry;
            ArcSegment asg = pg.Figures[1].Segments[0] as ArcSegment;
            asg.Size = new Size(asg.Size.Width + 5, asg.Size.Height + 5);
        }
    }
}
