using Tyuiu.KosyakovDS.Sprint3.Task4.V10.Lib;

namespace Tyuiu.KosyakovDS.Sprint3.Task4.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите первое значение:");
            int startValue = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе значение:");
            int stopValue = Int32.Parse(Console.ReadLine());

            double res = ds.Calculate(startValue, stopValue);

            Console.WriteLine("Ваш результат: " + res);
        }
    }
}