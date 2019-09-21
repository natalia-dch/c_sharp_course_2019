using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача:Написать метод вычисления площади треугольника по формуле Герона. Параметры – длины сторон и вычисляемая площадь. Если значения параметров не могут быть длинами сторон треугольника, метод должен возвращать в точку вызова значение false, иначе - true. */

namespace Task_011
{
    class Program
    {   static bool Heron(double a, double b, double c, out double area) {
            if (a >= b + c || b >= a + c || c >= a + b)
            { area = 0;
                return false;
            }
            double p = (a + b + c) / 2;
            area = Math.Sqrt(p*(p - a)*(p - b)*(p - c));
            return true;
        }
        static void Main(string[] args)
        {   //var-s
            double a, b, c;
            double area;
            bool isTriangle;
            do
            {
                //input
                Console.Write("Input a:");
                while (!double.TryParse(Console.ReadLine(), out a) || a <=0)
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input b:");
                while (!double.TryParse(Console.ReadLine(), out b) || b <=0 )
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input c:");
                while (!double.TryParse(Console.ReadLine(), out c) || c <=0 )
                    Console.Write("Input ERROR! Input again:");
                //processing
                isTriangle = Heron(a, b, c, out area);
                //output
                if (isTriangle)
                    Console.WriteLine($"The area is {area}");
                else
                    Console.WriteLine("It's not a triangle");


                

                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
