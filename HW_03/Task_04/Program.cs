using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Написать метод, вычисляющий значение функции [photo]
*/

namespace Task_04
{
    class Program
    {
        static double Function(double x, double y) {
            if (x > y && x > 0)
                return x + Math.Sin(y);
            else if (x > y && x < 0)
                return y - Math.Cos(x);
            else
                return 0.5 * x * y;
        }
        static void Main(string[] args)
        {   //var-s
            double x, y;
            do
            {
                //input
                Console.Write("Input x:");
                while (!double.TryParse(Console.ReadLine(), out x))
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input y:");
                while (!double.TryParse(Console.ReadLine(), out y))
                    Console.Write("Input ERROR! Input again:");
                //output
                Console.WriteLine(Function(x,y).ToString("F3"));
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
