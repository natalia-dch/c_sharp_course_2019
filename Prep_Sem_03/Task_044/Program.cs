using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Куб с известным ребром из вещества с заданной плотностью погружен в воду (гранью вниз). Напишите метод, выводящий в консольное приложение сообщение «Тонет» или «Плавает». Если плавает – вычислите «осадку» (расстояние от дна куба до поверхности воды)*/

namespace Task_01
{
    class Program
    {   static bool isSinking(double cubeDen) {
            const double H2ODen = 997;
            if (cubeDen > H2ODen)
            { Console.WriteLine("It sinks");
                return true;
            }
            else
            {
                Console.WriteLine("It floats");
                return false; }
        }
        static void Main(string[] args)
        {   //var-s
            double draft;
            double cubeDen;
            double cubeSide;
            const double H2ODen = 997;
            do
            {
                //input
                Console.Write("Input density of the cube:");
                while (!double.TryParse(Console.ReadLine(), out cubeDen) || cubeDen <= 0)
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input a side of the cube:");
                while (!double.TryParse(Console.ReadLine(), out cubeSide) || cubeSide <= 0)
                    Console.Write("Input ERROR! Input again:");
                //processing
                if (!isSinking(cubeDen)) {
                    draft = cubeSide * cubeDen / H2ODen;
                    Console.WriteLine($"The draft is {draft:F2}cm");
                }
                //output
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
