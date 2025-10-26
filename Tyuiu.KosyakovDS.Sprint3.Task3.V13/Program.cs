using Tyuiu.KosyakovDS.Sprint3.Task3.V13.Lib;

namespace Tyuiu.KosyakovDS.Sprint3.Task3.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("Введите строку:");
            string x = Console.ReadLine();

            int res = ds.ConvertStringToInt(x);

            Console.WriteLine("Ваш результат: " + res);
        }
    }
}