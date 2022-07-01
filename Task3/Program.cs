// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1,4

namespace HelloWorld

{
    class Program
    {
        public static void Main(string[] args)
        {
            // читаем число из консоли
            int a = Convert.ToInt32(Console.ReadLine());
            // получаем результат функции GetSquare
            int[] squares = GetSquare(a);
            // перебор массива с помощью цикла for
            for (int i = 0; i < squares.Length; i++)
            {
                // вывод чисел в консоль
                Console.WriteLine(squares[i] + " ");
            }
        }
        //объявление функции
        public static int[] GetSquare(int n)
        {
           //создание массива с размерностью n
            int[] square = new int[n];
            //объявление цикла от 1 до n включительно
            for (int i = 1; i <= square.Length; i++)
            {
                // записываем в i - 1 элемент массива (по индексу) квадрата числа i
                square[i-1] = i * i;    
            }
            return square;
        }
    }
}