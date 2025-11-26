
using Tyuiu.LeushinP.Sprint4.Task3.V3.Lib;


namespace Tyuiu.LeushinP.Sprint4.Task3.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int[,] matrix = {
                { 9, 4, 5, 4, 8 },
                { 7, 6, 7, 7, 4 },
                { 4, 4, 3, 5, 6 },
                { 6, 5, 9, 4, 9 },
                { 9, 7, 8, 7, 7 }
            };
            Console.Title = "Спринт #4 | Выполнил: Леушин П.С | СМАРТб-25-1";
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #4                                                                      *");
            Console.WriteLine("* Тема: Двумерные массивы (статический ввод)                                     *");
            Console.WriteLine("* Задание #3                                                                     *");
            Console.WriteLine("* Вариaнт #3                                                                     *");
            Console.WriteLine("* Выполнил: Леушин Павел Сергеевич | СМАРТб-25-1                                 *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный               *");
            Console.WriteLine("* статическими значениями в диапазоне от 3 до 9.                                 *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine("Исходный массив:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int result = ds.Calculate(matrix);
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine($"Количество нечётных элементов: {result}");

            Console.ReadKey();
        }
    }
}