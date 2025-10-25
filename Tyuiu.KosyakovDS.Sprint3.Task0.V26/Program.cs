using Tyuiu.KosyakovDS.Sprint3.Task0.V26.Lib;

namespace Tyuiu.KosyakovDS.Sprint3.Task0.V26
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите х:");
            double x = double.Parse(Console.ReadLine());

            int startValue = 1;
            int stopValue = 9;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            Console.WriteLine(res);
        }
    }
}