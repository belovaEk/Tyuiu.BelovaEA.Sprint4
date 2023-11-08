using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint4.Task5.V23.Lib;

namespace Tyuiu.BelovaEA.Sprint4.Task5.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();

            int[,] ar = { { 1, -2, 3 },
                          { 2, 1, -3 },
                          { 1, -1, 1} };
            int[,] wait = { { 1, 0, 3 },
                          { 2, 1, 0 },
                          { 1, 0, 1} };
            CollectionAssert.AreEqual(wait, ds.Calculate(ar));
        }
    }
}
