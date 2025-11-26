using NUnit.Framework;
using Tyuiu.LeushinP.Sprint4.Task5.V22.Lib;

namespace Tyuiu.LeushinP.Sprint4.Task5.V22.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] nums = new int[3, 3] { { -1, 2, 3 }, { 4, -5, 6 }, { 5, 6, 7 } };
            int res = ds.Calculate(nums);
            Assert.AreEqual(2, res);
        }
    }
}