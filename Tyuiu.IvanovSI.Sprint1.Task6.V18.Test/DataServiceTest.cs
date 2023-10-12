using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.IvanovSI.Sprint1.Task6.V18.Lib;
namespace Tyuiu.IvanovSI.Sprint1.Task6.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string s = "123";
            int o = 0;
            Assert.AreEqual(true,ds.CheckNumber(s)); 
        }
    }
}
