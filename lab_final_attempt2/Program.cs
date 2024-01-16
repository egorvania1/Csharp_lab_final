/*
Добавить к реализованному во втором задании классу указанные в варианте перегруженные операции. 
Протестировать все методы. 
Название класса: point.
// Методы //
Унарные операции:
++ увеличить координаты x на 1,
-- уменьшение координаты х на 1.
Операции приведения типа:
int (явная) – результатом является целая часть координаты х;
double (неявная) – результатом является координата y.
Бинарные операции:
+ Point p – вычисляется расстояние до точки p. Результатом должно быть вещественное число.
+ целое число (лево- и правосторонние операции).
Увеличивается координата х, результатом является объект типа Point.
*/

using System;
using System.Globalization;
using Utilities;

namespace lab_final_attempt2
{
    internal class Program
    {
        public static void notMain(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture; //Ввод вещественных чисел через точку
            Console.WriteLine("Задание 3.");
            Console.WriteLine("Добавить к реализованному во втором задании классу указанные в варианте перегруженные операции. Протестировать все методы.");

            Console.WriteLine("/// Ввод точки 1 ///");
            Point point1 = new Point(10.5, 10.5); //Точка 1
            point1.X = Input.IntoDouble("Введите координаты Х1: ");
            point1.Y = Input.IntoDouble("Введите координаты Y1: ");
            Console.WriteLine("Координаты точки 1: " + point1); //Проверка перегрузки ToString()

            Console.WriteLine("/// Ввод точки 2 ///");
            Point point2 = new Point(20.5, 20.5); //Точка 2
            point2.X = Input.IntoDouble("Введите координаты Х2: ");
            point2.Y = Input.IntoDouble("Введите координаты Y2: ");
            Console.WriteLine("Координаты точки 2: " + point2); //Проверка перегрузки ToString()
            Console.WriteLine("Расстояние от точки 1 до точки 2: " + point1.Distance(point2)); //Проверка Distance()

            // Проверка унарной операции ++ //
            Console.WriteLine("/// Проверка унарной операции ++ ///");
            Console.WriteLine("point1++");
            point1++;
            Console.WriteLine("Новые координаты точки 1: " + point1); //Проверка перегрузки ToString()

            // Проверка унарной операции -- //
            Console.WriteLine("/// Проверка унарной операции -- ///");
            Console.WriteLine("point2--");
            point2--;
            Console.WriteLine("Новые координаты точки 2: " + point2); //Проверка перегрузки ToString()

            // Проверка бинарной операции Point a + целое число //
            Console.WriteLine("/// Проверка бинарной операции Point a + целое число ///");
            Console.WriteLine("point3 = point2 + 20");
            Point point3 = point2 + 20;
            Console.WriteLine("Координаты точки 3: " + point3);
            Console.WriteLine("point3 = 20 + point2");
            point3 = 20 + point2;
            Console.WriteLine("Координаты точки 3: " + point3);

            // Проверка бинарной операции Point a + Point p //
            Console.WriteLine("/// Проверка бинарной операции Point a + Point p ///");
            Console.WriteLine("Расстояние от точки 2 до точки 3: " + Convert.ToString(point2 + point3));

            // Тесты преобразований //
            Console.WriteLine("/// Тесты преобразований точки point3 ///");
            //Проверка явной операции приведения
            int testInt = (int)point3;
            Console.WriteLine("Явное преобразование в int " + Convert.ToString(testInt));
            //Проверка неявной операции приведения
            double testDouble = point3;
            Console.WriteLine("Неявное преобразование в double " + Convert.ToString(testDouble));
        }
    }
}

