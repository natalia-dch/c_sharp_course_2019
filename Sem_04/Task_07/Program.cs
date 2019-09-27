using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Написать программу, которая по двум целым неотрицательным числам A и B возвращает их наибольший общий делитель (НОД) и наименьшее общее кратное (НОК)
Для вычисления НОД и НОК использовать один метод, откуда НОД и НОК вернуть, используя out-параметры
*/

namespace Task_07
{
    class Program
    {
        static void GCD_LCM(uint A, uint B, out uint GCD, out uint LCM) {
            uint x = A;
            uint y = B;
            while (x != y) {
                if (x > y)
                    x -= y;
                else
                    y -= x;
                        }
            GCD = x;
            LCM = A * B / GCD;
        }
        static void Main(string[] args)
        {   //var-s
            uint A, B;
            uint GCD, LCM;
            do
            {
                //input
                Console.Write("Input A:");
                while (!uint.TryParse(Console.ReadLine(), out A))
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input B:");
                while (!uint.TryParse(Console.ReadLine(), out B))
                    Console.Write("Input ERROR! Input again:");
                //processing
                GCD_LCM(A, B, out GCD, out LCM);
                //output
                Console.WriteLine($"GCD({A},{B})={GCD}");
                Console.WriteLine($"LMC({A},{B})={LCM}");
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
