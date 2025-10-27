using Tyuiu.KosyakovDS.Sprint3.Task5.V25.Lib;

namespace Tyuiu.KosyakovDS.Sprint3.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            double wait = 6133.748;
            double res = ds.GetSumSumSeries(2, 1, 1, 3, 10);

            Assert.AreEqual(wait, res);
        }
    }
}
