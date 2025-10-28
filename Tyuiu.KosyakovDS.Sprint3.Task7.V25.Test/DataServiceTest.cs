using Tyuiu.KosyakovDS.Sprint3.Task7.V25.Lib;

namespace Tyuiu.KosyakovDS.Sprint3.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckValid()
        {
            DataService ds = new DataService();

            double[] wait = {4.67, 0.43, -8.26, -9.87, -3.98, 1, 0.02, -1.87, 3.74, 16.43, 24.67};
            double[] res = ds.GetMassFunction(-5, 5);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
