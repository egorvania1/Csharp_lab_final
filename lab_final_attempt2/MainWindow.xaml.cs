using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using lab_final_attempt2.View.UserControls;

namespace lab_final_attempt2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public class PointCollection
    {
        private List<Point> points;
        public List<Point> Points
        {
            get { return points; }
            set { points = value; }
        }

        public PointCollection()
        {
            points = new List<Point>
            {
                new Point(10.5, 10.5),
                new Point(20.5, 20.5)
            };
        }
        public List<Point> GetPoints()
        {
            return points;
        }
    }

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

    }

}