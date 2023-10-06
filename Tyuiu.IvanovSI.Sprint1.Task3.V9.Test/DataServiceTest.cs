using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint1.Task3.V9.Lib;
namespace Tyuiu.IvanovSI.Sprint1.Task3.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExprssion()
        {
            DataService ds = new DataService();
            double min = 150;
            double res = ds.ConvertMinutesToHours((int)min);
            Assert.AreEqual(res,2);


        }
    }
}
