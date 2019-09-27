using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Написать программу, выводящую на экран таблицу значений суммы ряда из n элементов для n = 1,…, K. Значение K – целое неотрицательное вводится с клавиатуры пользователем.
Сумму вычислять в методе по формуле:
𝑆=∑_(𝑘=1)^𝑛/(𝑘+0,3)/(3𝑘^2+5)

*/

namespace Task_05
{
    class Program
    {
        static double CalcSeries(uint K) {
            double sum = 0;
            for (int i = 1; i <= K; i++) {
                sum += (i + 0.3) / (3 * i * i + 5);
            }
            return sum;
        }

        static void Main(string[] args)
        {   //var-s
            uint K;
            do
            {
                //input
                Console.Write("Input K:");
                while (!uint.TryParse(Console.ReadLine(), out K))
                    Console.Write("Input ERROR! Input again:");
                //output
                for (uint n = 1; n <= K; n++) {

                    Console.WriteLine($"{n} \t {CalcSeries(n):F3}");
                }
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
