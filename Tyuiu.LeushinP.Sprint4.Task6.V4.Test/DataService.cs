using NUnit.Framework;
using Tyuiu.LeushinP.Sprint4.Task6.V4.Lib;

namespace Tyuiu.LeushinP.Sprint4.Task6.V4.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void TestCalculateShortStrings()
        {
            DataService ds = new DataService();

            string[] input = {
                "Москва",
                "Санкт Петербург",
                "Новосибирск",
                "Екатеринбург",
                "Нижний Новгород",
                "Казахстан",
                "Самара"
            };

            string[] expected = { "Москва", "Самара" };
            string[] actual = ds.Calculate(input);

            Assert.AreEqual(expected, actual);
        }
    }
}