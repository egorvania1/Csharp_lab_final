using System;
using System.Collections.Generic;
using System.Drawing;
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
    /// Логика взаимодействия для IntPlusPoint.xaml
    /// </summary>
    public partial class IntPlusPoint : UserControl
    {
        public IntPlusPoint()
        {
            InitializeComponent();
        }

        private void ResButton_Click(object sender, RoutedEventArgs e)
        {
            if (SelPoint.SelectedItem != null)
            {
                Point point = (Point)SelPoint.SelectedItem;
                int number = Convert.ToInt32(IntInput.Text);
                point += number;
                SelPoint.SelectedItem = point;
                ResText.Text = "Результат: " + point;
            }
            else
            {
                ResText.Text = "Результат: Не выбрана точка";
            }
        }
    }
}
