using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KosyakovDS.Sprint3.Task1.V8.Lib
{
    public class DataService : ISprint3Task1V8
    {
        public double GetSumSeries(double value, int startValue, int stopValue) 
        {
            double s = 1;

            while (startValue <= stopValue)
            {
                int k = startValue;

                s *= Math.Pow(1 / (Math.Cos(k) + Math.Pow(value, k)), k);

                startValue++;
            }

            return Math.Round(s, 3);
        }
    }
}
