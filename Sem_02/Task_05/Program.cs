/*/* 
Выделение отдельных цифр натурального числа
Задача. 
Ввести трехзначное натуральное число и напечатать его цифры "столбиком".
*/
using System;

    class Program
    {   static void Sum(int num, out int dig1, out int dig2, out int dig3)
    {
        dig1 = num / 100;
        dig2 = num % 100 / 10;
        dig3 =  num % 10;
    }
        static void Main(string[] args)
        {  //var-s
        int num;
        string result;
        do {//input
            Console.Write("Input a positive integer >99 and <1000: ");
            while (!int.TryParse(Console.ReadLine(), out num) || num <= 99 || num >= 1000)
                Console.Write("Input error! Try again:");
            //processing
            int dig1, dig2, dig3;
            Sum(num, out dig1, out dig2, out dig3);
            //output
            Console.WriteLine(dig1);
            Console.WriteLine(dig2);
            Console.WriteLine(dig3);
            //ending
            Console.WriteLine("Press <esc> to exit, any key to continue");


        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
