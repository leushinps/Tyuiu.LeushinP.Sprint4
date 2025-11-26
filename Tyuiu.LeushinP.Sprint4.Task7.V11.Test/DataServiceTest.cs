using NUnit.Framework;
using Tyuiu.DatskiyDE.Sprint4.Task7.V11.Lib;


namespace Tyuiu.LeushinP.Sprint4.Task7.V11.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int n = 4;
            int m = 2;
            string value = "56789012";

            int result = ds.Calculate(n, m, value);
            int expected = 4;

            Assert.AreEqual(expected, result);
        }
    }
}