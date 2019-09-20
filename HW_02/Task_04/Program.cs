using System;
/*
 ФИО: Доскач Наталья Алексеевна
 Группа: 192БПИ
 Вариант: - 
 Задание: Получить от пользователя четырехзначное натуральное число и напечатать его цифры в обратном порядке.
 */

namespace Task_01
{
    class Program
    {

        static void Main(string[] args)
        {

            do
            {
                int num;
                string result = "";
                int digit;
                //input
                Console.Write("Input 4digit number:");
                while (!int.TryParse(Console.ReadLine(), out num) || num < 1000 || num > 9999)
                    Console.Write("Input ERROR! Input again: ");
                //processing
                while (num > 0) {
                    digit = num % 10;
                    result += digit;
                    num = num / 10;
                }
                //output
                Console.WriteLine(result);
                //ending
                Console.WriteLine("Press <esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
