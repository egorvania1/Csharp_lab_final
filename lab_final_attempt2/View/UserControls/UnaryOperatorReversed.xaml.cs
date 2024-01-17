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
    /// Логика взаимодействия для UnaryOperatorReversed.xaml
    /// </summary>

    //Код как в UnaryOperations, но операторы ++ и -- стоят слева
    //(Почему я не назвал этот файл UnaryOperationsReversed)
    public partial class UnaryOperatorReversed : UserControl 
    {
        public UnaryOperatorReversed()
        {
            InitializeComponent();
        }
        private void PlusButton_Click(object sender, RoutedEventArgs e) //Когда нажата кнопка ++
        {
            Point point = (Point)SelPoint.SelectedItem; //Берём выбранную точку
            ++point; //Проверка перегрузки ++ (левосторонняя)
            SelPoint.SelectedItem = point; //Замещаем точку получившийся (Почему-то работает и без этого. Достаточно обновить список. ПОЧЕМУ?)
            SelPoint.Items.Refresh(); //Обновляем список
        }

        private void MinusButton_Click(object sender, RoutedEventArgs e) //Когда нажата кнопка --
        {
            Point point = (Point)SelPoint.SelectedItem; //Берём выбранную точку
            --point; //Проверка перегрузки -- (левосторонняя)
            SelPoint.SelectedItem = point; //Замещаем точку получившийся (Почему-то работает и без этого. Достаточно обновить список. ПОЧЕМУ?)
            SelPoint.Items.Refresh(); //Обновляем список
        }

        private void SelPoint_SelectionChanged(object sender, SelectionChangedEventArgs e) //Если изменился выбор в листе
        {
            if (SelPoint.SelectedItem != null) //Если что-то выбрано
            {
                PlusButton.IsEnabled = true; //то включить кнопки
                MinusButton.IsEnabled = true;
            }
            else
            {
                PlusButton.IsEnabled = false; //Если ничего не выбрано, то выключить кнопки
                MinusButton.IsEnabled = false;
            }
        }
    }
}
