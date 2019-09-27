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
        static void Main(string[] args)
        {   //var-s
            do
            {
                //input
                Console.Write("Input ...:");
                while (!int.TryParse(Console.ReadLine(), out x))
                    Console.Write("Input ERROR! Input again:");
                //processing
                //output
                Console.WriteLine();
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
