using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint4.Task4.V27.Lib;

namespace Tyuiu.BelovaEA.Sprint4.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            int[,] ar = { { 1, 2, 3 },
                          { 2, 1, 3 },
                          { 1, 1, 1} };
            Assert.AreEqual(11, ds.Calculate(ar));
        }
    }
}
