using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - */

namespace Task_01
{
    class Program
    {
        static int GCD(int x, int y) {
            while (x != y)
            {
                if (x > y)
                    x -= y;
                else
                    y -= x;
            }
            return x;
        }
        static void Main(string[] args)
        {   //var-s
            int numer, denom;
            do
            {
                //input
                Console.Write("Input numerator:");
                while (!int.TryParse(Console.ReadLine(), out numer))
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input denom:");
                while (!int.TryParse(Console.ReadLine(), out denom))
                    Console.Write("Input ERROR! Input again:");
                //processing
                int myGCD = GCD(numer, denom);
                numer /= myGCD;
                denom /= myGCD;


                //output
                Console.WriteLine($"The new fraction is {numer}/{denom}");
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
