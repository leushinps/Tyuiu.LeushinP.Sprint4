
using NUnit.Framework;
using System;

using Tyuiu.LeushinP.Sprint4.Task1.V2.Lib;

namespace Tyuiu.LeushinP.Sprint4.Task1.V2.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[] numsArray = { 1, 7, 2, 2, 6, 2, 3, 2, 3, 5, 7, 7, 1, 2 };
            int res = ds.Calculate(numsArray);
            int wait = 34;

            Assert.AreEqual(wait, res);
        }
    }
}