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
        static void Main(string[] args)
        {   //var-s
            do
            {
                //input
                Console.Write("Input ...:");
                while (!int.TryParse(Console.ReadLine(), out x))
                    Console.Write("Input ERROR! Input again:");
                //processing
                //output
                Console.WriteLine();
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
