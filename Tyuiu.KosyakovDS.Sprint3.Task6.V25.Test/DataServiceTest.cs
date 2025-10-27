using Tyuiu.KosyakovDS.Sprint3.Task6.V25.Lib;

namespace Tyuiu.KosyakovDS.Sprint3.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            int wait = 99;
            int res = ds.GetSumTheDivisors(16, 24);

            Assert.AreEqual(wait, res);
        }
    }
}
