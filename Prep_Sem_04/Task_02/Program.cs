using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Вывести на экран таблицу чисел от 0 до 15 в десятичной и шестнадцатеричной системах счисления
*/

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {   //var-s
            do
            {

                //processing
                //output
                for (int i = 0; i < 16; i++)
                {
                    Console.WriteLine($"{i,-2} | {i,-2:X} | {~i,-3} | {~i,-3:X}");
                };
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
