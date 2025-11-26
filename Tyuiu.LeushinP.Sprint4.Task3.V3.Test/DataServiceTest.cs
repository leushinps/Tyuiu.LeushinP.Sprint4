using NUnit.Framework;
using Tyuiu.LeushinP.Sprint4.Task3.V3.Lib;

namespace Tyuiu.LeushinP.Sprint4.Task3.V3.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void TestCalculateOddCount()
        {
            DataService ds = new DataService();

            int[,] matrix = {
                { 9, 4, 5, 4, 8 },
                { 7, 6, 7, 7, 4 },
                { 4, 4, 3, 5, 6 },
                { 6, 5, 9, 4, 9 },
                { 9, 7, 8, 7, 7 }
            };

            int expected = 14;
            int actual = ds.Calculate(matrix);

            Assert.AreEqual(expected, actual);
        }
    }