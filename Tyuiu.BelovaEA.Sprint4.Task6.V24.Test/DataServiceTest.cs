using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint4.Task6.V24.Lib;

namespace Tyuiu.BelovaEA.Sprint4.Task6.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestCalculate()
        {
            DataService ds = new DataService();
            string[] a = { "ааа", "ыыыыыыыыы", "оооооооо", "ууууу" };
            string[] wait = { "ыыыыыыыыы", "оооооооо" };
            string[] res = ds.Calculate(a);
            CollectionAssert.AreEqual(wait, res);
        }
    }
}
