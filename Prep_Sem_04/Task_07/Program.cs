using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Используя операции побитового сдвига, написать метод «быстрого умножения» числа на 2
*/

namespace Task_01
{
    class Program
    {
        static int MultBy2(int num)
        {
            return num << 1;
        }
        static void Main(string[] args)
        {   //var-s
            int num;
            do
            {
                //input
                Console.Write("Input the number:");
                while (!int.TryParse(Console.ReadLine(), out num) || num < 1)
                    Console.Write("Input ERROR! Input again:");
                //output
                Console.WriteLine(MultBy2(num));
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
