using System;
/*
 ФИО: Доскач Наталья Алексеевна
 Группа: 192БПИ
 Вариант: - 
 Задание: Получить от пользователя вещественное значение – бюджет пользователя и целое число – процент бюджета, выделенный на компьютерные игры. Вычислить и вывести на экран сумму в рублях\евро или долларах, выделенную на компьютерные игры. Использовать спецификаторы формата для валют.


 */

namespace Task_01
{
    class Program
    {

        static void Main(string[] args)
        {

            do
            {   //variables
                double budget;
                int gamesPercent;
                //input
                Console.Write("Input your budget:");
                while (!double.TryParse(Console.ReadLine(), out budget) || budget <= 0)
                    Console.Write("Input ERROR! Input again: ");
                Console.Write("Input your percentage:");
                while (!int.TryParse(Console.ReadLine(), out gamesPercent) || gamesPercent <= 0 || gamesPercent > 100)
                    Console.Write("Input ERROR! Input again: ");
                //processing
                double result = budget * gamesPercent / 100;
                //output
                Console.WriteLine($"You can spend {result:C} on games");
                //ending
                Console.WriteLine("Press <esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
