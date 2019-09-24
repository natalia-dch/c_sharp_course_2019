using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Написать метод, вычисляющий логическое значение функции G=F(X,Y). Результат равен true, если точка с координатами (X,Y) попадает в фигуру G, и результат равен false, если точка с координатами (X,Y) не попадает в фигуру G. Фигура G - сектор круга радиусом R=2 в диапазоне углов -90<= fi <=45.
*/

namespace Task_03
{
    class Program
    {
        static bool isInside(int x, int y) {
            bool crit1 = x * x + y * y <= 4; //точка внутри круга
            bool crit2 = x >= 0;
            bool crit3 = x >= y;
            return crit1 && crit2 && crit3;
        }
        static void Main(string[] args)
        {   //var-s
            int x;
            int y;
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
                bool result = isInside(x, y);
                //output
                if (result)
                   Console.WriteLine($"({x},{y}) is inside the figure");
                else
                    Console.WriteLine($"({x},{y}) is not inside the figure");
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
