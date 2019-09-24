using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: представить число в двоичной записи
*/

namespace Task_01
{
    class Program
    {
        static void MakeBinary(int numb) {
            int bit, temp;
            bit = 1;
            temp = numb;
            while (temp > 1)
            {
                bit++;
                temp = numb;
                temp = temp >> bit;
            }
            while (bit >= 0)
            {
                temp = numb;
                Console.Write(((temp >> bit) % 2) + " ");
                bit--;
            };
            Console.WriteLine();
        }
        static void Main(string[] args)
        {   //var-s
            int numb;
            do
            {
                //input
                Console.Write("Input ...:");
                while (!int.TryParse(Console.ReadLine(), out numb) || numb <= 0)
                    Console.Write("Input ERROR! Input again:");
                //processing
                MakeBinary(numb);
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}


