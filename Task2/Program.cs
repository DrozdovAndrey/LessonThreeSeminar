// Задача 2. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
// namespace HelloWorld  

// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
        
//             Console.Clear();    
                      
           
//         }  
//     }
// }
public class ProgramSeminar
{

    int a;

    public int GetA()
    {

        try
        {

            Console.WriteLine("Введите  число от 1 до 4");

            a = Convert.ToInt32(Console.ReadLine());


        }
        catch (System.Exception)
        {
            Console.WriteLine("Введите число правильно");
            GetA();

        }

        if (a < 1 || a > 4)
        {
            Console.WriteLine("Данное число не соответсвует запросу");
            GetA();


        }


        return a;
    }

    public static void Main(string[] args)
    {

        ProgramSeminar programSeminar = new ProgramSeminar();
        programSeminar.GetA();

        switch (programSeminar.a)
        {
            case 1:
                Console.WriteLine("X и Y будут от 0 до  MaxValue");
                break;
            case 2:
                Console.WriteLine("X будет от MinValue до 0 и  Y будет от 0 до  MaxValue");
                break;

            case 3:
                Console.WriteLine("X будет от MinValue до 0 и  Y будет от MinValue до 0");
                break;
            case 4:
                Console.WriteLine("X будет от 0 до  MaxValue и y будет от MinValue до 0 ");
                break;

        }


    }









}

