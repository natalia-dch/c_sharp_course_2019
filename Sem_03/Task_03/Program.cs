using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Вычислить площадь под графиком функции X^2 на отрезке [0;A]
при помощи метода трапеций, вещественная точка A и шаг интегрирования delta задаются с клавиатуры.
Чтобы организовать проверку корректности введённых данных, определите ограничения на значения А и delta.
Как вычисляется значение, добавляемое к интегральной сумме на каждом шаге.
Определите условие выхода из цикла формирования интегральной суммы.
*/

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {   //var-s
            double A; //правая граница отрезка
            double delta;
            double area=0;
            double x = 0;
            double height;
            do
            {
                //input
                Console.Write("Input A:");
                while (!double.TryParse(Console.ReadLine(), out A) || A <=0 )
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input delta:");
                while (!double.TryParse(Console.ReadLine(), out delta) || delta >= A/10)
                    Console.Write("Input ERROR! Input again:");
                //processing
                while (x <= A) {
                    height = x * x;
                    area += height * delta;
                    x += delta;
                }
                //output
                Console.WriteLine($"With A={A}, delta={delta}, your area is {area:F2}");
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
