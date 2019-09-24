using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Вычислите приближенное значение бесконечной суммы [photo]*/

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {   //var-s
            float result = 0;
            float element;
            float n = 1;
            do
            {
                //processing
                do {
                    element = 1 / (n * (n + 1) * (n + 2));
                    result += element;
                    n += 1;
                } while (result != result + element);
                //output
                Console.WriteLine($"The sum is {result}");
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}

