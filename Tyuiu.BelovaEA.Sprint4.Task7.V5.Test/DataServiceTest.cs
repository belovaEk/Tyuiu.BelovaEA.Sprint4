using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint4.Task7.V5.Lib;

namespace Tyuiu.BelovaEA.Sprint4.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            string a = "123456";
            int res = ds.Calculate(2,3, a);
            Assert.AreEqual(3,res);
        }
    }
}
