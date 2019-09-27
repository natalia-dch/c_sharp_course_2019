using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Написать программу, которая по двум целым неотрицательным числам A и B возвращает их наибольший общий делитель (НОД) и наименьшее общее кратное (НОК)
Для вычисления НОД и НОК использовать один метод, откуда НОД и НОК вернуть, используя out-параметры
*/

namespace Task_07
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
