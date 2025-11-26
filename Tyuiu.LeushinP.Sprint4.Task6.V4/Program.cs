using System;
using Tyuiu.LeushinP.Sprint4.Task6.V4.Lib;

namespace Tyuiu.LeushinP.Sprint4.Task6.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Леушин П.С | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Леушин Павел Сергеевич | СМАРТб-25-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных                                             *");
            Console.WriteLine("* [\"Москва\", \"Санкт Петербург\", \"Новосибирск\", \"Екатеринбург\",    *");
            Console.WriteLine("* \"Нижний Новгород\", \"Казахстан\", \"Самара\"],                        *");
            Console.WriteLine("* используя класс Array, выведите элементы массива, длина которых < 7.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] cities = {
                "Москва",
                "Санкт Петербург",
                "Новосибирск",
                "Екатеринбург",
                "Нижний Новгород",
                "Казахстан",
                "Самара"
            };

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ: Элементы с длиной < 7 символов                              *");
            Console.WriteLine("***************************************************************************");

            string[] result = ds.Calculate(cities);

            foreach (string item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("***************************************************************************");
            Console.ReadKey();
        }
    }
}