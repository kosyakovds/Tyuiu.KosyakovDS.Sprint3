using Tyuiu.KosyakovDS.Sprint3.Task4.V10.Lib;

namespace Tyuiu.KosyakovDS.Sprint3.Task4.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            double wait = 0.014;
            double res = ds.Calculate(-5, 5);

            Assert.AreEqual(wait, res);
        }
    }
}
