using System;
//Вычисление значения логической функции !(X&Y|Z)
namespace Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x, y, z;
            bool result;
            do
            {   //input
                Console.Write("Input x: ");
                while (!bool.TryParse(Console.ReadLine(), out x))
                    Console.Write("Input error! Try again:");
                Console.Write("Input y: ");
                while (!bool.TryParse(Console.ReadLine(), out y))
                    Console.Write("Input error! Try again:");
                Console.Write("Input z: ");
                while (!bool.TryParse(Console.ReadLine(), out z))
                    Console.Write("Input error! Try again:");
                //processing
                result = !(x & y | z);
                //output
                Console.WriteLine(result);
                //ending
                Console.WriteLine("Press <esc> to exit, any key to continue");


            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
