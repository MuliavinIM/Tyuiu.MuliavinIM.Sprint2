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

            DataService ds = new DataService();
            double x = -0.4;
            double y = 0.4;
            bool wait = true;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}