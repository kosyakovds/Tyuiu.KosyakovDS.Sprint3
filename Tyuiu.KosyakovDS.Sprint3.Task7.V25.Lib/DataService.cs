using System.Runtime.Intrinsics.X86;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KosyakovDS.Sprint3.Task7.V25.Lib
{
    public class DataService : ISprint3Task7V25
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] mass = new double[len];
            int i = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double res = Math.Cos(x) + (4 * x) / 2 - Math.Sin(x) * 3 * x;

                mass[i] = Math.Round(res, 2);
                i++;
            }
            return mass;
        }
    }
}
