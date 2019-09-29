using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Определить все тройки попарно различных целых чисел 𝑎,𝑏,𝑐 из интервала [1;20], для которых верно 𝑎^2+𝑏^2=𝑐^2.
*/

namespace Task_01
{
    class Program
    {
        static void SetsFinder(){
            for (int a = 1; a <= 18; a++){
                for (int b = a + 1; b <= 19; b++)
                    for (int c = b + 1; c <= 20; c++)
                        if (a * a + b * b == c * c)
                            Console.WriteLine($"({a},{b},{c}), ({b},{a},{c})");
            }
        }
        static void Main(string[] args)
        {   //var-s
            do
            {
                //processing
                SetsFinder();
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
