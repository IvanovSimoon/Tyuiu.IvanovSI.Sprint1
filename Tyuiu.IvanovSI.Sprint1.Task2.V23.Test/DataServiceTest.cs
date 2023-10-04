using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint1.Task2.V23.Lib;

namespace Tyuiu.IvanovSI.Sprint1.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            int min = 10;
            int sec = 60;

            int res = ds.Calc(min,sec);
            Assert.AreEqual(res, 600);
        }
    }
}
