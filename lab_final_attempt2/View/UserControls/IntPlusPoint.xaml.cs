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

        private void ResButton_Click(object sender, RoutedEventArgs e) //Когда была нажата кнопка
        {
            Point point = (Point)SelPoint.SelectedItem; //Берём выбранную точку
            int number;
            if (!int.TryParse(IntInput.Text, out number)) //Пытаемся преобразовать ввод в int
            {
                ResText.Text = "Введён не int"; //Если введено не число
            }
            else
            {
                point += number; //Проверка перегрузки Point + Int
                ResText.Text = point.ToString();
            }
        }

        private void SelPoint_SelectionChanged(object sender, SelectionChangedEventArgs e) //Если изменился выбор в листе
        {
            if (SelPoint.SelectedItem != null) //Если что-то выбрано
            {
                ResButton.IsEnabled = true; //то включить кнопку
            }
            else
            {
                ResButton.IsEnabled = false; //Если ничего не выбрано, то выключить кнопку
            }
        }
    }
}
