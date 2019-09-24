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
        static double Function(double x)
        {
            if (x <=0.5)
                return Math.Sin(Math.PI/2);
            else
                return Math.Sin(Math.PI*(x-1) / 2);
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
                //output
                Console.WriteLine(Function(x).ToString("F3"));
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
