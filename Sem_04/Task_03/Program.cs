using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: В основной программе ввести значения трех вещественных чисел. Если числа могут быть длинами сторон треугольника - вычислить его площадь по формуле Герона. 

Написать метод, вычисляющий площадь (s) и периметр (p) треугольника по заданным длинам его сторон. Метод должен возвращать значение false, если параметры заданы неверно и треугольник с такими длинами построить нельзя. При удачном задании длин сторон метод возвращает true. 

Заголовок метода: 
bool Triangle(double x, double y, double z, out double p, out double s)

Основная программа, используя метод, «общается» с пользователем.
*/

namespace Task_03
{
    class Program
    {
        static bool Triangle(double x, double y, double z, out double p, out double s) {
            p = s = 0;
            if (x <= 0 || y <= 0 || z <= 0)
                return false;
            if (x > y + z || y > x + z || z > x + y)
                return false;
            double hsum = (x + y + z) / 2;
            s = Math.Sqrt(hsum*(hsum - x)*(hsum - y)*(hsum - z));
            p = x + y + z;
            return true;

        }
        static void Main(string[] args)
        {   //var-s
            double x, y, z; //triangle sides
            double perim;
            double area;

            do
            {
                //input
                Console.Write("Input 1st side:");
                while (!double.TryParse(Console.ReadLine(), out x))
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input 2nd side:");
                while (!double.TryParse(Console.ReadLine(), out y))
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input 3rd side:");
                while (!double.TryParse(Console.ReadLine(), out z))
                    Console.Write("Input ERROR! Input again:");

                //output
                if (Triangle(x, y, z, out perim, out area))
                    Console.WriteLine($"P={perim}, S={area}");
                else
                    Console.WriteLine("Perimeter and area cannot be calculated for such sides");
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
