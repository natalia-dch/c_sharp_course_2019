using System;
/*
 ФИО: Доскач Наталья Алексеевна
 Группа: 192БПИ
 Вариант: - 
 Задание: Ввести значение x и вывести значение полинома: F(x) = 12x4 + 9x3 - 3x2 + 2x – 4. Не применять возведение в степень. Использовать минимальное количество операций умножения.
 */

namespace Task_01
{
    class Program
    {
        static double CalcPoly(double x) {
            double x2;
            double x3;
            double x4;
            double result;
            x2 = x * x;
            x3 = x2 * x;
            x4 = x3 * x;
            result = 12*x4 + 9*x3 - 3*x2 + 2*x - 4;
            return result;
        }
        static void Main(string[] args)
        {
            double x;
            do {
                //input
                Console.Write("Input... :");
                while (!double.TryParse(Console.ReadLine(), out x))
                    Console.Write("Input ERROR! Input again: ");
                //processing
                double result = CalcPoly(x);
                //output
                Console.WriteLine("For F(x) = 12x4 + 9x3 - 3x2 + 2x – 4 F({0:F3})={1:F3}", x, result);
                //ending
                Console.WriteLine("Press <esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
