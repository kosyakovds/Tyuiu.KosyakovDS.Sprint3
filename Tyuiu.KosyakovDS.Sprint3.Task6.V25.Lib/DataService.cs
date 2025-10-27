using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KosyakovDS.Sprint3.Task6.V25.Lib
{
    public class DataService : ISprint3Task6V25
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                for (int j = 1; j <= startValue; j++)
                {
                    if (i % j == 0)
                    {
                        if (j > 10)
                        {
                            break;
                        }
                        sum += j;
                    }
                }
            }
            return sum;
        }
    }
}
