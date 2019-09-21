using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Написать метод, выполняющий арифметические операции над значениями двух параметров. Третий параметр – символ операции.

В основной программе, вводить значения двух переменных целого типа и символ операции, обращаясь к методу, вычислять значение соответствующего выражения.*/

namespace Task_01
{
    class Program
    {   static int Mod(int a, int b) {
            while (a >= b)
                a = a - b;
            return a;

        }
        static int Calculate(int a, int b, char c)
        {
            int res;
            switch (c)
            {
                case '+': res = a + b; break;
                case '-': res = a - b; break;
                case '*': res = a * b; break;
                case '/': res = a / b; break;
                case '%': res = Mod(a,b); break;
                default: res = 0; Console.WriteLine("Error!"); break;
            };
            return res;
        }
        static void Main(string[] args)
        {   //var-s
            int a, b;
            char c;
            int result;
            do
            {
                //input
                Console.Write("Input a:");
                while (!int.TryParse(Console.ReadLine(), out a))
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input b:");
                while (!int.TryParse(Console.ReadLine(), out b))
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input operation:");
                while (!char.TryParse(Console.ReadLine(), out c) || (c != '+' && c != '-' && c != '*' && c != '/' && c!='%'))
                    Console.Write("Input ERROR! Input again:");
                //processing
                result = Calculate(a, b, c);
                //output
                Console.WriteLine(result);
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
