using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Написать программу, выводящую на экран таблицу значений суммы ряда из n элементов для n = 1,…, K. Значение K – целое неотрицательное вводится с клавиатуры пользователем.
Сумму вычислять в методе по формуле:
𝑆=∑_(𝑘=1)^𝑛▒(𝑘+0,3)/(3𝑘^2+5)

*/

namespace Task_05
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
