using Tyuiu.KosyakovDS.Sprint3.Task1.V8.Lib;

namespace Tyuiu.KosyakovDS.Sprint3.Task1.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите х:");
            double x = double.Parse(Console.ReadLine());

            double res = ds.GetSumSeries(x, 1, 7);

            Console.WriteLine("Ваш результат: " + res);
        }
    }
}