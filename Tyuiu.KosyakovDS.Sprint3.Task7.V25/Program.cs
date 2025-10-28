using Tyuiu.KosyakovDS.Sprint3.Task7.V25.Lib;

namespace Tyuiu.KosyakovDS.Sprint3.Task7.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите начало диапазона:");
            int startValue = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец диапазона:");
            int stopValue = Int32.Parse(Console.ReadLine());

            var res = ds.GetMassFunction(startValue, stopValue);
            Console.WriteLine("Таблица значений:");
            for (int i = 0; i <= (stopValue - startValue); i++)
            {
                Console.WriteLine(res[i]);
            }
        }
    }
}