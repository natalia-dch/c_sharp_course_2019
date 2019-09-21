using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Написать метод определения принадлежности точки заданной области на плоскости. Область задана соотношениями: -10 < y < 10 и y < -x +10 и y > -x – 10. В основной программе, вводя значения координат, проверять принадлежность точки области.*/

namespace Task_022
{
    class Program
    {   static bool AreaChecker(int x, int y) {
            if (y > -10 && y < 10 && y < -x + 10 && y > -x - 10)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {   //var-s
            int x, y;
            bool isInArea;
            do
            {
                //input
                Console.Write("Input x:");
                while (!int.TryParse(Console.ReadLine(), out x))
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input y:");
                while (!int.TryParse(Console.ReadLine(), out y))
                    Console.Write("Input ERROR! Input again:");
                //processing
                isInArea = AreaChecker(x,y);
                //output
                if (isInArea)
                    Console.WriteLine($"({x},{y}) is in the area");
                else
                    Console.WriteLine($"({x},{y}) is not in the area");
                Console.WriteLine();
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
