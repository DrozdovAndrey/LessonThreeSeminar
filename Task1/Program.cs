// Задача 1. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
namespace HelloWorld

{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Введите кординату по оси x:");
                double x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите кординату по оси y:");
                double y = Convert.ToDouble(Console.ReadLine());
                if (x > 0 && y > 0) Console.WriteLine("номер четверти 1");
                if (x < 0 && y > 0) Console.WriteLine("номер четверти 2");
                if (x < 0 && y < 0) Console.WriteLine("номер четверти 3");
                if (x > 0 && y < 0) Console.WriteLine("номер четверти 4");
                if (x == 0 && y == 0) Console.WriteLine("вы находитесь посредине");
            }
            catch
            {
                Console.WriteLine("Введено некоректное значение");
            }
        }
    }
}