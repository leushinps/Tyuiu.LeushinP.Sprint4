
using NUnit.Framework;
using System;

using Tyuiu.LeushinP.Sprint4.Task0.V28.Lib;


namespace Tyuiu.LeushinP.Sprint4.Task0.V28.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidGetMultEvenArrEl()
        {
            DataService ds = new DataService();
            int[] array = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            int wait = 9216;

            var rez = ds.GetMultEvenArrEl(array);
            Assert.AreEqual(wait, rez);
        }
    }
}