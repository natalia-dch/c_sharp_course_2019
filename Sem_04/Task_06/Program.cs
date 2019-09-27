using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Написать методы, вычисляющие суммы рядов с машинной точностью (если это возможно):
𝑺=𝒙^𝟐−(𝟐^𝟑 𝒙^𝟒)/𝟒!+(𝟐^𝟓 𝒙^𝟔)/𝟔!−…
𝑺=𝟏+𝒙/𝟏!+𝒙^𝟐/𝟐!+…+𝒙^𝒏/𝒏!+…

Вещественные значения x получать от пользователя в основной программе.
*/

namespace Task_06
{
    class Program
    {
        static double CalcSeries1(double x)
        {
            double sum = 0;
            double elem = x * x;
            int n = 2;
            while (sum + elem != sum)
            {
                sum += elem;
                elem = (-1) * elem * 8 * x * x / ((2 * n - 1)*(2 * n));
                n++;
            };
            return sum;

        }
        static double CalcSeries2(double x)
        {
            double sum = 0;
            double elem = 1;
            int n = 1;
            int factorial = 1;
            while (sum + elem != sum)
            {
                sum += elem;
                factorial = factorial * n;
                elem = elem * x / factorial;
                //Console.Write(elem + " ");
                n++;
            };
            return sum;
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
                //output
                Console.WriteLine($"S1({x})={CalcSeries1(x):F5}");
                Console.WriteLine($"S2({x})={CalcSeries2(x):F5}");
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
