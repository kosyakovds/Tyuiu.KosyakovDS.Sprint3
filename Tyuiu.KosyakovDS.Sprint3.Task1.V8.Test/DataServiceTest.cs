using Tyuiu.KosyakovDS.Sprint3.Task1.V8.Lib;

namespace Tyuiu.KosyakovDS.Sprint3.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            double wait = -302185.684;
            double res = ds.GetSumSeries(0.25, 1, 7);

            Assert.AreEqual(wait, res);
        }
    }
}
