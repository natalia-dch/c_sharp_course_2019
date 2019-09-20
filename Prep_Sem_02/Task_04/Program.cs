using System;
/*Не используя методов класса Math вычислить значение a^n.
 * Для n = 4 используя не более 2-х операций умножения,
 * n = 6, 8 – не более 3-х;
 * n = 7, 9, 10 – не более 4-х;
 * n = 13, 15 – не более 5-ти;
 * для n = 21, 28, 64 – не более 6-ти.*/
class Program
{
    static void Main(string[] args)
    {
        do
        {
            double a;
            int n;
            double result;
            Console.Write("Input a:");
            while (!double.TryParse(Console.ReadLine(), out a))
                Console.Write("Input error! Input a again:");
            Console.Write("Input n:");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 2)
                Console.Write("Input error! Input n again:");
            //обработка
            result = 1;
            while (n > 0)
            {
                if (n % 2 == 1)
                { result = result * a;
                    Console.Write("*");
                    n = n - 1; }
                n = n / 2;
                a = a * a;
                Console.Write("*");
            };

            Console.WriteLine("The result is " + result);
            Console.WriteLine("Press <esc> to exit, any key to continue");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}
