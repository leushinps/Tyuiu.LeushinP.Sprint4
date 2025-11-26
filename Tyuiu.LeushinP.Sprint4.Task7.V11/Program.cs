using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DatskiyDE.Sprint4.Task7.V11.Lib;

namespace Tyuiu.SpirinAA.Sprint4.Task7.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
          

            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Леушин П.С | Смартб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Операции сравнения                                                *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Леушин Павел Сергеевич | Смартб-25-1                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из одноразрядных цифр 56789012. Преобразуйте ее в матрицу   *");
            Console.WriteLine("* 4 на 2 и подсчитайте количество нечетных чисел в матрице.               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int n = 4;
            int m = 2;
            string value = "56789012";

            Console.WriteLine("Количество строк (n): " + n);
            Console.WriteLine("Количество столбцов (m): " + m);
            Console.WriteLine("Строка: " + value);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int countOdd = ds.Calculate(n, m, value);

            Console.WriteLine($"Количество нечётных чисел в матрице {n}x{m}: {countOdd}");


            Console.WriteLine("Матрица:");
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(int.Parse(value[index].ToString()));
                    if (j < m - 1) Console.Write(" ");
                    index++;
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}