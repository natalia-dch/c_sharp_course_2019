using System;
/*
 ФИО: Доскач Наталья Алексеевна
 Группа: 192БПИ
 Вариант: - 
 Задание: Ввести натуральное трехзначное число Р. Найти наибольшее целое число, которое можно получить, переставляя цифры числа Р.

 */

namespace Task_01
{
    class Program
    {
        static int FindBiggestNum(int num)
        {
        int biggestDigit,
             middleDigit,
            smallestDigit;
            int x1, x2, x3;
            x1 = num / 100;
            x2 = num % 100 / 10;
            x3 = num % 10;
            //тернарка
            biggestDigit = Math.Max(Math.Max(x1,x2),x3);
            smallestDigit = Math.Min(Math.Min(x1, x2), x3);
            middleDigit = x1 != smallestDigit & x1 != biggestDigit ? x1 : (x2 != smallestDigit & x2 != biggestDigit? x2 : x3);
            int result =  biggestDigit*100 + middleDigit*10 + smallestDigit;
            return result;
        }
        static void Main(string[] args)
        {
            int num;
            do
            {
                //input
                Console.Write("Input integer >99 and <1000 :");
                while (!int.TryParse(Console.ReadLine(), out num) || num<100 || num > 999)
                    Console.Write("Input ERROR! Input again: ");
                //processing
                int result = FindBiggestNum(num);
                //output
                Console.WriteLine("The biggest number is {0}",result);
                //ending
                Console.WriteLine("Press <esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
