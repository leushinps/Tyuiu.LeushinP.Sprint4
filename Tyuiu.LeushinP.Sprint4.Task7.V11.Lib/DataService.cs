using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.DatskiyDE.Sprint4.Task7.V11.Lib
{
    public class DataService : ISprint4Task7V11
    {
        public int Calculate(int n, int m, string value)
        {
            // матрица n x m
            int[,] matrix = new int[n, m];

            // Заполнение из строки 
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value[index].ToString());
                    index++;
                }
            }

            // ?нечётные
            int countOdd = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 != 0)
                        countOdd++;
                }
            }

            return countOdd;
        }
    }
}