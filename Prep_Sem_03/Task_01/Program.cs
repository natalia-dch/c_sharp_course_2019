using System;
/*Ввести значение вещественной переменной х и вычислить(и вывести) значение функции, заданной соотношениями:...*/

namespace Task_01
{
    class Program
    {
        static double Function(double x) {
            if (x < 0)
                return 1 / (x * x);
            else if (x == 0)
                return 12;
            else if (x < 10)
                return x * x;
            else
                return 100;
        }
        static void Main(string[] args)
        {   //var-s
            double x;
            double result;
            do {
                //input
                Console.Write("Input x:");
                while (!double.TryParse(Console.ReadLine(), out x))
                    Console.Write("Input ERROR! Input again:");
                //processing
                result = Function(x);
                    //output
                    Console.WriteLine(result);
            //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
