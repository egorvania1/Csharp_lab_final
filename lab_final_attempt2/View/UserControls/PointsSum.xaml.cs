using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab_final_attempt2.View.UserControls
{
    /// <summary>
    /// Логика взаимодействия для PointsSum.xaml
    /// </summary>
    public partial class PointsSum : UserControl
    {
        public PointsSum()
        {
            InitializeComponent();
        }

        private void ResButton_Click(object sender, RoutedEventArgs e)
        {
            Point point1 = (Point)SelPoint1.SelectedItem;
            Point point2 = (Point)SelPoint2.SelectedItem;
            double sum = point1 + point2;
            ResText.Text = sum.ToString();
        }

        private void SelPoint_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (SelPoint1.SelectedItem != null && SelPoint2.SelectedItem != null)
            {
                ResButton.IsEnabled = true;
            }
            else
            {
                ResButton.IsEnabled = false;
            }
        }
    }
}
