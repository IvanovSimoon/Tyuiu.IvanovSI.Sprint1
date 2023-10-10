using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint1.Task5.V1.Lib;

namespace Tyuiu.IvanovSI.Sprint1.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = -1;
            double x2 = 2;
            double y1 = -1;
            double y2 = 3;
            double res = ds.DistanceBetweenDots(x1, y1, x2, y2);
            int rezult = Convert.ToInt32(res);
            int wait = 5;
            Assert.AreEqual(wait, rezult);
        }
    }
}
