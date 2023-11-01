using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint4.Task1.V15.Lib;

namespace Tyuiu.BelovaEA.Sprint4.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            int[] array = { 1, 2, 3, 4 };
            Assert.AreEqual(8, ds.Calculate(array));
        }
    }
}
