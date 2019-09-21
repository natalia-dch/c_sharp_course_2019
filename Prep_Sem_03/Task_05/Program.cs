using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Ввести натуральное число и вычислить суммы его цифр, находящихся на четных и на нечетных позициях*/

namespace Task_01
{
    class Program
    {
        static int sumEven(int x) {
            int sum = 0;
            for (int i = 1; x > 0; i=i+2)
            {   
                x /= 10; //coz first digit is odd
                sum += x % 10;
                x /= 10;
            }
            return sum;
        }
        static int sumOdd(int x) {
            int sum = 0;
            for (int i = 1; x > 0; i = i + 2)
            {
                sum += x % 10;
                x /= 100;
            }
            return sum;
        }
        static void Main(string[] args)
        {   //var-s
            int x;
            int sumOddPlaces = 0;
            int sumEvenPlaces = 0;
            do
            {
                //input
                Console.Write("Input x:");
                while (!int.TryParse(Console.ReadLine(), out x) || x < 1)
                    Console.Write("Input ERROR! Input again:");
                //processing
                sumEvenPlaces = sumEven(x);
                sumOddPlaces = sumOdd(x);

                //output
                Console.WriteLine($"Sum of digits on odd places is {sumOddPlaces}, sum of digits on even places is {sumEvenPlaces}");
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
