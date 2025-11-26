using NUnit.Framework;
using Tyuiu.LeushinP.Sprint4.Task3.V3.Lib;

namespace Tyuiu.LeushinP.Sprint4.Task3.V3.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void TestGetMinCharCount()
        {
            DataService ds = new DataService();
            string input = "apple pineapple";
            char target = 'p';
            int expected = 4;

            int actual = ds.GetMinCharCount(input, target);
            Assert.AreEqual(expected, actual);
        }
    }
}