using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Написать метод для решения квадратного уравнения. 
Параметры – коэффициенты уравнения А, В, С, и два параметра, для получения значений вещественных корней. 

При отсутствии вещественных корней (если А=В=С=0 или А=В=0 и С!=0) метод должен возвращать в точку вызова значение false, иначе - true. 

В основной программе вводить коэффициенты квадратного уравнения, выводить значения вещественных корней или сообщение об их отсутствии.
*/

namespace Task_01
{
    class Program
    {
        static bool SolveEquation(int A, int B, int C, out double x1, out double x2) {
            x1 = 0;
            x2 = 0;
            if (A == 0 && B == 0)
                return false;
            double D = B * B - 4 * A * C;
            if (D < 0)
                return false;
            x1 = (-B + Math.Sqrt(D)) / (2 * A);
            x2 = (-B - Math.Sqrt(D)) / (2 * A);
            return true;

        }
        static void Main(string[] args)
        {   //var-s
            int A, B, C;
            double x1, x2;
            do
            {
                //input
                Console.Write("Input A:");
                while (!int.TryParse(Console.ReadLine(), out A))
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input B:");
                while (!int.TryParse(Console.ReadLine(), out B))
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input C:");
                while (!int.TryParse(Console.ReadLine(), out C))
                    Console.Write("Input ERROR! Input again:");
                //processing
                bool result = SolveEquation(A, B, C, out x1, out x2) ;
                //output
                if (result)
                    Console.WriteLine($"x1={x1:F3}, x2={x2:F3}");
                else
                    Console.WriteLine("This equation cannot be solved in real numbers");
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}

