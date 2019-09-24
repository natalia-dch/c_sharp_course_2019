using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: 
*/

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {   //var-s
            do
            {
                //input
                Console.Write("Input ...:");
                while (!int.TryParse(Console.ReadLine(), out x))
                    Console.Write("Input ERROR! Input again:");
                //processing
                uint a = 13;
                byte b = 5;
                int c = a * b;

                //output
                Console.WriteLine();
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}

