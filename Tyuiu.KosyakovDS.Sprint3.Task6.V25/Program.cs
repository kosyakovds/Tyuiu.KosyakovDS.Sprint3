using Tyuiu.KosyakovDS.Sprint3.Task6.V25.Lib;

namespace Tyuiu.KosyakovDS.Sprint3.Task6.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите значение 1:");
            int startValue = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение 2:");
            int stopValue = Int32.Parse(Console.ReadLine());

            double res = ds.GetSumTheDivisors(startValue, stopValue);

            Console.WriteLine("Ваш результат: " + res);
        }
    }
}