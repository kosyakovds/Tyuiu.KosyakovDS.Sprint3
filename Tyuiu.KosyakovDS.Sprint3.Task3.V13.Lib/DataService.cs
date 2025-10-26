using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.KosyakovDS.Sprint3.Task3.V13.Lib
{
    public class DataService : ISprint3Task3V13
    {
        public int ConvertStringToInt(string value)
        {
            int res = 0;

            foreach (char c in value)
            {
                if (Char.IsDigit(c))
                {
                    res += int.Parse(c.ToString());
                }
            }

            return res;
        }
    }
}
