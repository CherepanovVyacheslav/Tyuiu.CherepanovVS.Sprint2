using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.CherepanovVS.Sprint2.Task4.V20.Lib;

namespace Tyuiu.CherepanovVS.Sprint2.Task4.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void VolidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 8;
            Assert.AreEqual(res, wait);
        }
        [TestMethod]
        public void VolidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 7;
            double res = ds.Calculate(x, y);
            double wait = 3.857;
            Assert.AreEqual(res, wait);
        }
    }
}
