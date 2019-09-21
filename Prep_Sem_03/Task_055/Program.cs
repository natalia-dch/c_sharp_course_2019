using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Написать метод, вычисляющий значение функции Y=F(X), заданной требованиями: [photo]*/

namespace Task_055
{
    class Program
    {
        static double CalcFunc(double x) {
            if (x <= -0.5) return 0.5;
            else if (x <= 0) return x + 1;
            else if (x <= 1) return x * x - 1;
            else return x - 1;
        }
        static void Main(string[] args)
        {   //var-s
            double x;
            do
            {
                //input
                Console.Write("Input x:");
                while (!double.TryParse(Console.ReadLine(), out x))
                    Console.Write("Input ERROR! Input again:");
                //processing
                double result = CalcFunc(x);
                //output
                Console.WriteLine(result);
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
