using System;
using System.ComponentModel;

namespace lab_final_attempt2
{
    public class Point : INotifyPropertyChanged //Класс точка, содержащая координаты точек по осям Х и У
    {
        private double x; //поле координаты Х (double)
        private double y; //поле координаты У (double)

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string info)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(info));
            }
        }
        public double X //Вывод и ввод Х
        {
            get { return x; }
            set 
            { 
                x = value;
                OnPropertyChanged("MyDataProperty");
            }

        }
        public double Y //Вывод и ввод У
        {
            get { return y; }
            set { y = value; }
        }
        public Point(double x, double y) //Контруктор точки
        {
            this.x = x;
            this.y = y;
        }
        public double Distance(Point otherP)
        //Метод Distance, принимающий класс точки и выводящий расстоняние от себя до другой точки
        //Возвращает double
        {
            //Console.WriteLine("This x: " + x + ". Other X: " + otherP.x + ". This y: " + y + ". Other Y: " + otherP.y);
            // Формула нахождение расстоние между двумя точками зная из координаты:
            // ( (x2 - x1)^2 + (y2 - y1)^2 )^0,5
            return Math.Sqrt(Math.Pow(otherP.x - x, 2) + Math.Pow(otherP.y - y, 2));
        }
        public override string ToString() //Перегрузка метода ToString
        {
            return "(" + Convert.ToString(x) + "; " + Convert.ToString(y) + ")";
        }
        public static Point operator ++(Point a) //Перегрузка ++
        {
            a.x += 1;
            return a;
        }
        public static Point operator --(Point a) //Перегрузка --
        {
            a.x -= 1;
            return a;
        }
        public static explicit operator int(Point a) //Явный оператор преобразования в целочисленное
        { 
            return Convert.ToInt32(a.x);
        }
        public static implicit operator double(Point a) //Неявный оператор преобразования в вещественное
        {
            return a.y;
        }
        public static double operator +(Point a, Point p) => a.Distance(p); //Перегрузка Point a + Point p
        public static Point operator +(Point a, int num) //Перегрузка Point a + int n
        {
            return new Point(a.x + num, a.y);
        }
        public static Point operator +(int num, Point a) //Перегрузка Point a + int n
        {
            return new Point(a.x + num, a.y);
        }
    }
}