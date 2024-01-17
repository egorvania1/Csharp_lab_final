using System.Collections.ObjectModel;
using System.Net.Http.Headers;
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
        public class Employee
        {
            public string Name { get; set; }
            public string SurName { get; set; }
            public Employee(string name, string surName)
            {
                this.Name = name;
                this.SurName = surName;
            }
        }

        private ObservableCollection<Point> points;
        public ObservableCollection<Point> Points
        {
            get { return points; }
            set { points = value; }
        }

        public PointCollection()
        {
            points = new ObservableCollection<Point>
            {
                new Point(10.5, 10.5),
                new Point(20.5, 20.5),
                new Point(0, 0),
                new Point(-35, 5.7),
                new Point(83, -2.1),
                new Point(60, 10),
                new Point(-7, 5.4),
                new Point(-0.1, 0.1),
                new Point(3, -3),
            };
        }
        public ObservableCollection<Point> GetPoints()
        {
            return points;
        }
    }

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Title = "Тестирования методов класса точки (Point)";
        }
    }
}