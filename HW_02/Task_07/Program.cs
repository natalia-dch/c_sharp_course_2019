using System;
/*
 ФИО: Доскач Наталья Алексеевна
 Группа: 192БПИ
 Вариант: - 
 Задание: Написать программу с использованием двух методов. Первый метод возвращает дробную и целую часть числа. Второй метод возвращает квадрат и корень из числа. В основной программе пользователь вводит дробное число. Программа должна вычислить, если это возможно, значение корня, квадрата числа, выделить целую и дробную часть из числа.


 */

namespace Task_01
{
    class Program
    {
        public static void NumberParts(double num, out int wholeP, out double decimalP) {
            num = num < 0 ? -num : num;
            wholeP = (int)num;
            decimalP = num % 1;
        }
        public static void SquareMe_RootMe(double num, out double squared, out double rooted) {
            squared = num * num;
            rooted = num < 0 ? -1 : Math.Sqrt(num);
        }

        static void Main(string[] args)
        {

            do
            {   //var-s
                double num;
                //input
                Console.Write("Input your number:");
                while (!double.TryParse(Console.ReadLine(), out num))
                    Console.Write("Input ERROR! Input again: ");
                //processing
                int wholeP;
                double decimalP;
                double squared, rooted;
                NumberParts(num, out wholeP, out decimalP);
                SquareMe_RootMe(num, out squared, out rooted);
                //output
                Console.WriteLine($"Whole part is {wholeP}, decimal part is {decimalP:F3}, number squared is {squared:F3}");
                if (rooted == -1)
                    Console.WriteLine("Number is negative, so can't be rooted");
                else
                    Console.WriteLine($"Number rooted is {rooted:F3}");
                //ending
                Console.WriteLine("Press <esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
