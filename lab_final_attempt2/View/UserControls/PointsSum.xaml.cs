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

    //Код как в PointsDistance, но с перегрузкой Point + Point
    public partial class PointsSum : UserControl
    {
        public PointsSum()
        {
            InitializeComponent();
        }

        private void ResButton_Click(object sender, RoutedEventArgs e) //Когда была нажата кнопка
        {
            Point point1 = (Point)SelPoint1.SelectedItem; //Берём выбранную точку из листа 1
            Point point2 = (Point)SelPoint2.SelectedItem; //Берём выбранную точку из листа 2
            double sum = Math.Round(point1 + point2, 4); //Проверка перегрузки Point + Point (выдаёт результат метода Distance)
            ResText.Text = sum.ToString(); //Вывод результата
        }

        private void SelPoint_SelectionChanged(object sender, SelectionChangedEventArgs e) //Если изменился выбор в каком-то листе
        {
            if (SelPoint1.SelectedItem != null && SelPoint2.SelectedItem != null) //Если в обеих ListBox что-то выбрано
            {
                ResButton.IsEnabled = true; //то включить кнопку
            }
            else
            {
                ResButton.IsEnabled = false;//Если хоть в одном ничего не выбрано, то выключить кнопку
            }
        }
    }
}
