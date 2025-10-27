using Tyuiu.KosyakovDS.Sprint3.Task5.V25.Lib;

namespace Tyuiu.KosyakovDS.Sprint3.Task5.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите x:");
            int x = Int32.Parse(Console.ReadLine());

            double res = ds.GetSumSumSeries(x, 1, 1, 3, 10);

            Console.WriteLine("Ваш результат: " + res);
        }
    }
}