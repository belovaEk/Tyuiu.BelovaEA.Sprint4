using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BelovaEA.Sprint4.Task0.V30.Lib;

namespace Tyuiu.BelovaEA.Sprint4.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestGetSumEvenArrEl()
        {
            DataService ds = new DataService();
            int[] array = {1, 0, 4, 8};
            int wait = 12;
            int res = ds.GetSumEvenArrEl(array);
            Assert.AreEqual(wait, res);
        }
    }
}
