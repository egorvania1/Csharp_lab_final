using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
    /// Логика взаимодействия для UnaryOperations.xaml
    /// </summary>
    public partial class UnaryOperations : UserControl
    {
        public UnaryOperations()
        {
            InitializeComponent();
        }

        private void PlusButton_Click(object sender, RoutedEventArgs e)
        {
            Point point = (Point)SelPoint.SelectedItem;
            point++;
            SelPoint.SelectedItem = point;
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e)
        {
            Point point = (Point)SelPoint.SelectedItem;
            point--;
            SelPoint.SelectedItem = point;
        }
    }
}
