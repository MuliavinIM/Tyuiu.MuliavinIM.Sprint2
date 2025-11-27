using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MuliavinIM.Sprint2.Task7.V5.Lib;

namespace Tyuiu.MuliavinIM.Sprint2.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.5;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool expect = true;

            Assert.AreEqual(expect, res);
        }
    }
}
