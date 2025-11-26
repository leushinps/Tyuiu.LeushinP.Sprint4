using NUnit.Framework;
using Tyuiu.LeushinP.Sprint4.Task4.V18.Lib;

namespace Tyuiu.LeushinP.Sprint4.Task4.V18.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void TestReplaceOddElements()
        {
            DataService ds = new DataService();

            int[,] input = {
                { 4, 7, 4, 5, 4 },
                { 4, 5, 6, 7, 4 },
                { 7, 5, 6, 6, 4 },
                { 6, 7, 6, 6, 4 },
                { 5, 6, 6, 6, 5 }
            };

            int[,] expected = {
                { 4, 0, 4, 0, 4 },
                { 4, 0, 6, 0, 4 },
                { 0, 0, 6, 6, 4 },
                { 6, 0, 6, 6, 4 },
                { 0, 6, 6, 6, 0 }
            };

            int[,] actual = ds.Calculate(input);

            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    Assert.AreEqual(expected[i, j], actual[i, j]);
                }
            }
        }
    }
}