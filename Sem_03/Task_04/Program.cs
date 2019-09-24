using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Написать метод для вычисления по формуле Ньютона с точностью до «машинного нуля» приближенного значения арифметического квадратного корня. 
Параметры: подкоренное значение, полученное значение корня и значение точности, достигнутой при его вычислении. Если подкоренное значение отрицательно - метод должен возвращать в точку вызова значение false, иначе - true. 

В основной программе вводить вещественные числа и выводить их корни. При отрицательных числах выводить сообщения.
*/

namespace Task_01
{
    class Program
    {
        static bool RootMe(double a, out double sq, out double eps) {
            double r1, r2 = a;
            sq = eps = 0.0;
            if (a < 0)
                return false;
            do
            {
                r1 = r2;
                eps = a / r1 / 2 - r1 / 2;
                r2 = r1 + eps;
            } while (r1 != r2);
            sq = r2;


            return  true;
        }
        static void Main(string[] args)
        {   //var-s
            double A;
            double sq;
            double eps;
            bool result;
            do
            {
                //input
                Console.Write("Input A:");
                while (!double.TryParse(Console.ReadLine(), out A))
                    Console.Write("Input ERROR! Input again:");
                //processing
                result = RootMe(A, out sq, out eps);
                if (result)
                    Console.WriteLine($"The root is {sq:F5}");
                else
                    Console.WriteLine("Error! Cannot take the square root of a negative number");
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
