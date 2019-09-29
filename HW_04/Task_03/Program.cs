using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Протабулировать функцию 𝑦 на заданном диапазоне, с заданным шагом изменения аргумента, значения 𝑎,𝑏,𝑐 вводит пользователь: [photo]
*/

namespace Task_03
{
    class Program
    {
        static double InputNum(string varName) {
            double num;
            Console.Write($"Input {varName}:");
            while (!double.TryParse(Console.ReadLine(), out num))
                Console.Write("Input ERROR! Input again:");
            return num;
        }
        static double Func(double x, double a, double b, double c) {
            if (x < 1.2)
                return a * x * x + b * x + c;
            else if (x == 1.2)
                return a / x + Math.Sqrt(x * x + 1);
            else
                return (a + b * x) / Math.Sqrt(x * x + 1);
        }
        static void Main(string[] args)
        {   //var-s
            do
            {
                //input
                double A = InputNum("A");
                double B = InputNum("B");
                double C = InputNum("C");
                //processing
                for (double x = 1; x <= 2; x += 0.05)
                { Console.WriteLine($"F({x})={Func(x,A,B,C):F3}"); }
                //output
                Console.WriteLine();
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
