using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.LeushinP.Sprint4.Task3.V3.Lib
{
    public class DataService : ISprint3Task3V3
    {
        public int GetMinCharCount(string value, char item)
        {
            int count = 0;

            foreach (char c in value)
            {
                if (c == item)
                {
                    count++;
                }
            }

            return count;
        }
    }
}