using System;
/*Дано целое число, большее 999. Используя одну операцию деления нацело и одну операцию взятия остатка от деления,
 * определить и вывести на экран цифру, соответствующую разряду сотен в записи этого числа.*/
class Program
    {
        static void Main(string[] args)
        {
        do
        {
            int userNum;
            int result;
            Console.WriteLine("Input a whole number bigger than 999");
            while (!int.TryParse(Console.ReadLine(), out userNum) || userNum < 999)
                Console.WriteLine("Input error! Input again");
            result = (userNum / 100) % 10;
            Console.WriteLine("The result is " + result);


            Console.WriteLine("Press <esc> to exit, any key to continue");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }

