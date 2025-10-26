using Tyuiu.KosyakovDS.Sprint3.Task3.V13.Lib;

namespace Tyuiu.KosyakovDS.Sprint3.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            int wait = 5;
            double res = ds.ConvertStringToInt("?sd!! 5gh. s!");

            Assert.AreEqual(wait, res);
        }
    }
}
