using System;

namespace Utilities {
    //Полезные утилиты
    class Input 
    //Данный класс содержит методы, позволяющие преобразовать ввод в Int32, Double или String, обрабатывая при этом ошибки.
    //Также при необходимости ввода от пользователя выводится строка line.
    {
        public static double IntoDouble(string line)
        {
            try
            {
                Console.Write(line);
                double output = Convert.ToDouble(Console.ReadLine().Replace(",", "."));
                return output;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return IntoDouble(line);
        }
        public static int IntoInt32(string line)
        {
            try
            {
                Console.Write(line);
                int output = Convert.ToInt32(Console.ReadLine());
                return output;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return IntoInt32(line);
        }
        public static string IntoString(string line)
        {
            try
            {
                Console.Write(line);
                string output = Console.ReadLine();
                return output;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return IntoString(line);
        }
    }
}