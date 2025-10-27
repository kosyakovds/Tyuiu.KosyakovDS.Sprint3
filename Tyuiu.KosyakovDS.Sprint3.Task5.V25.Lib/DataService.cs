using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KosyakovDS.Sprint3.Task5.V25.Lib
{
    public class DataService : ISprint3Task5V25
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double y = 1;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int j = startValue2; j <= stopValue2; j++)
                {
                    y += Math.Pow(x, j) + Math.Cos(j);
                }
            }

            return Math.Round(y, 3);
        }
    }
}
