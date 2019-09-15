using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y; // целочисленные переменные 
            Console.Write("X: "); // ввод представления первого числа
            string InputStr = Console.ReadLine();// Чтение с клавиатуры строки
            X = int.Parse(InputStr); // Преобразование в тип int

            Console.Write("Y: "); // ввод представления второго числа
            InputStr = Console.ReadLine();
            int.TryParse(InputStr, out Y);

            Console.WriteLine("X-Y="+(X-Y)); // вывод
            Console.WriteLine("X*Y=" + (X * Y));
            Console.WriteLine("X/Y=" + (X / Y));
            Console.WriteLine("X%Y=" + (X % Y));
            Console.WriteLine("X<<Y=" + (X << Y));
            Console.WriteLine("X>>Y=" + (X >> Y));
        }
    }
}
