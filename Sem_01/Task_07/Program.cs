using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt, secondInt; // целочисленные переменные 
            Console.Write("Целое число: "); // ввод представления первого числа
            string InputStr = Console.ReadLine();// Чтение с клавиатуры строки
            firstInt = int.Parse(InputStr); // Преобразование в тип int

            Console.Write("Целое число: "); // ввод представления второго числа
            InputStr = Console.ReadLine();
            int.TryParse(InputStr, out secondInt);

            Console.WriteLine("Ваш текст: " + (firstInt + secondInt)); // вывод

        }
    }
}
