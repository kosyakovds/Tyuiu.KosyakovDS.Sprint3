using Tyuiu.KosyakovDS.Sprint3.Task2.V20.Lib;

namespace Tyuiu.KosyakovDS.Sprint3.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            double wait = 914700.94;
            double res = ds.GetMultiplySeries(1, 1, 6);

            Assert.AreEqual(wait, res);
        }
    }
}
