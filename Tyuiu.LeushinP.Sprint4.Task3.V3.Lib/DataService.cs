using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.LeushinP.Sprint4.Task3.V3.Lib
{
    public class DataService : ISprint4Task3V3
    {
        public int Calculate(int[,] array)
        {
            int count = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 != 0)   // проверка на нечётность
                    {
                        count++;
                    }
                }
            }

            return count;
        }
    }
}