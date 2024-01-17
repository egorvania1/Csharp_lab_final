using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Логика взаимодействия для PointInfo.xaml
    /// </summary>
    public partial class PointInfo : UserControl, INotifyPropertyChanged  //Возможность предупреждать о изменении
    {
        public PointInfo()
        {
            InitializeComponent();
            DataContext = this;
        }

        public event PropertyChangedEventHandler? PropertyChanged; //Интерфейс INotifyPropertyChanged

        private int x;
        public int X
        {
            get { return x; }
            set
            {
                x = value;
                OnPropertyChanged(); //Предупредить о изменении x
            }
        }

        private double y;
        public double Y
        {
            get { return y; }
            set
            {
                y = value;
                OnPropertyChanged(); //Предупредить о изменении y
            }
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); //Обновить элементы управления
        }

        private void SelPoint_SelectionChanged(object sender, SelectionChangedEventArgs e) //Если изменился выбор в листе
        {
            if (SelPoint.SelectedItem != null) //Если что-то выбрано
            {
                Point point = (Point)SelPoint.SelectedItem;
                X = (int)point;
                Y = point;
            }
        }
    }
}
