using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Вычислить значение выражения 2^𝑁+2^𝑀, 𝑁, 𝑀 – целые неотрицательные числа вводятся пользователем с клавиатуры. Используйте битовые операции для организации «быстрого умножения». Помните о возможности переполнения.
*/

namespace Task_04
{
    class Program
    {
        static int InputNum(string varName)
        {
            int num;
            Console.Write($"Input {varName}:");
            while (!int.TryParse(Console.ReadLine(), out num))
                Console.Write("Input ERROR! Input again:");
            return num;
        }
        static long TwoToPower(int pow) {
            long result = 1;
            int temp = 1;
            while (pow > 0) {
                temp = 1;
                if (pow <= 7)
                {
                    temp = temp << pow;
                    result *= temp;
                    pow = 0;

                }
                else
                {
                    temp = temp << 7;
                    result *= temp;
                    pow -=7;
                }
                    }
            return result;
            }
        static void Main(string[] args)
        {   //var-s
            int N,
                M;
            do
            {
                //input
                N = InputNum("N");
                M = InputNum("M");
                //processing and output
                Console.WriteLine($"2^N+2^M={TwoToPower(N)+TwoToPower(M)}");
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
