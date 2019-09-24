using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Используя операции побитового сдвига, написать методы «быстрого возведения» двойки в заданную целую степень.
*/

namespace Task_01
{
    class Program
    {
        static int PowerOf2(int power) {
            return 1 << power;
        }
        static void Main(string[] args)
        {   //var-s
            int power;
            do
            {
                //input
                Console.Write("Input the power:");
                while (!int.TryParse(Console.ReadLine(), out power) || power <= 1)
                    Console.Write("Input ERROR! Input again:");
                //output
                Console.WriteLine(PowerOf2(power));
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
