using Tyuiu.KosyakovDS.Sprint3.Task2.V20.Lib;

namespace Tyuiu.KosyakovDS.Sprint3.Task2.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите х:");
            int x = Int32.Parse(Console.ReadLine());

            double res = ds.GetMultiplySeries(x, 1, 6);

            Console.WriteLine("Ваш результат: " + res);
        }
    }
}