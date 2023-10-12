using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint1.Task7.V28.Lib;

namespace Tyuiu.IvanovSI.Sprint1.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double z = Math.Round(ds.Calculate(x, y),3);
            Assert.AreEqual(4.787, z);

        }
    }
}
