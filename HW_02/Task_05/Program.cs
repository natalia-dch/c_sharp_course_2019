using System;
/*
 ФИО: Доскач Наталья Алексеевна
 Группа: 192БПИ
 Вариант: - 
 Задание: Получить от пользователя три вещественных числа и проверить для них неравенство треугольника. Оператор if не применять. Точность вывода три знака после запятой.

 */

namespace Task_01
{
    class Program
    {

        static void Main(string[] args)
        {

            do
            {   //variables
                double A, B, C;
                string result;
                //input
                Console.Write("Input 1st number:");
                while (!double.TryParse(Console.ReadLine(), out A))
                    Console.Write("Input ERROR! Input again: ");
                Console.Write("Input 2nd number:");
                while (!double.TryParse(Console.ReadLine(), out B))
                    Console.Write("Input ERROR! Input again: ");
                Console.Write("Input 3rd number:");
                while (!double.TryParse(Console.ReadLine(), out C))
                    Console.Write("Input ERROR! Input again: ");
                //processing
                result = (A < B + C & B < A + C & C < A + B) ? "it's a triangle!" : "it's not a triangle";
                //output
                Console.WriteLine(result);
                //ending
                Console.WriteLine("Press <esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
