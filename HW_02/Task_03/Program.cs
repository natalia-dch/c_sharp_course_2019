using System;
/*
 ФИО: Доскач Наталья Алексеевна
 Группа: 192БПИ
 Вариант: - 
 Задание: Введя значения коэффициентов А, В, С, вычислить корни квадратного уравнения. Учесть (как хотите) возможность появления комплексных корней. Оператор if не применять.      

 */

namespace Task_01
{
    class Program
    {

        static void Main(string[] args)
        {

            do
            {
                int a, b, c;
                string x1, x2;
                //input
                Console.Write("Input A:");
                while (!int.TryParse(Console.ReadLine(), out a))
                    Console.Write("Input ERROR! Input again: ");
                Console.Write("Input B:");
                while (!int.TryParse(Console.ReadLine(), out b))
                    Console.Write("Input ERROR! Input again: ");
                Console.Write("Input C:");
                while (!int.TryParse(Console.ReadLine(), out c))
                    Console.Write("Input ERROR! Input again: ");
                //processing
                double D = b * b - 4 * a * c;
                if (D >= 0)
                {
                    x1 = ((-b + Math.Sqrt(D)) / 2 * a).ToString();
                    x2 = ((-b - Math.Sqrt(D)) / 2 * a).ToString();
                }
                else
                {
                    x1 = -b / (2 * a) +"+"+ Math.Sqrt(-D) / (2 * a) + "i";
                    x2 = -b / (2 * a) +"-"+ Math.Sqrt(-D) / (2 * a) + "i";
                };

                //output
                Console.WriteLine("x1 = {0}, x2 = {1}",x1,x2);
                //ending
                Console.WriteLine("Press <esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
