using Tyuiu.KosyakovDS.Sprint3.Task0.V26.Lib;

namespace Tyuiu.KosyakovDS.Sprint3.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 9;
            double wait = -15.642;
            double res = ds.GetMultiplySeries(startValue, stopValue);

            Assert.AreEqual(wait, res);
        }
    }
}
