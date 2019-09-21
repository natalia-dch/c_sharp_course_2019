using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Задан круг с центром (10; 10) и радиусом 5. Ввести координаты центра и радиус второго круга. Если круги пересекаются, ввести координаты новой точки и оценить ее принадлежность пересечению кругов. Проверку пересечения кругов выполнять в методе IsCrossed(), оценку принадлежности точки пересечению кругов в методе IsLaidIn().*/

namespace Task_033
{
    class Program
    {
        static bool isCrossed(int XC1, int YC1, int RC1,
          int xc2, int yc2, int rc2)
        {
            double bwCenters = Math.Sqrt(Math.Pow(XC1 - xc2, 2) + Math.Pow(YC1 - yc2, 2));
            return RC1 + rc2 >= bwCenters;
        }
        static bool isLaidIn(int XC1, int YC1, int RC1,
        int xc2, int yc2, int rc2, int x, int y)
        {
            bool inside1Cir = Math.Pow(x - XC1, 2) + Math.Pow(y - YC1, 2) <= RC1 * RC1;
            bool inside2Cir = Math.Pow(x - xc2, 2) + Math.Pow(y - yc2, 2) <= rc2 * rc2;
            return inside1Cir && inside2Cir;
        }
        static void Main(string[] args)
        {   //var-s
            const int XC1 = 10;
            const int YC1 = 10;
            const int RC1 = 5;
            int xc2, yc2, rc2;
            int x, y;
            //bool isCircCrossed, isPointInside;
            do
            {
                //input
                Console.Write("Input x of the circle:");
                while (!int.TryParse(Console.ReadLine(), out xc2))
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input y of the circle:");
                while (!int.TryParse(Console.ReadLine(), out yc2))
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input radius:");
                while (!int.TryParse(Console.ReadLine(), out rc2))
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input x of the point:");
                while (!int.TryParse(Console.ReadLine(), out x))
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input y of the point:");
                while (!int.TryParse(Console.ReadLine(), out y))
                    Console.Write("Input ERROR! Input again:");
                //processing
                if (isCrossed(XC1, YC1, RC1,
        xc2, yc2, rc2))
                {
                    if (isLaidIn(XC1, YC1, RC1, xc2, yc2, rc2, x, y))
                        Console.WriteLine("Point is inside both circles");
                    else
                        Console.WriteLine("Point is not inside both circles, but circles are crossed");
                }
                else
                    Console.WriteLine("Circles aren't crossed");
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
