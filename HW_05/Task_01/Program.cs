using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: В основной программе ввести трехзначное натуральное число и преобразовать его в число, где его цифры упорядочены по убыванию.

Для этого написать метод, так преобразующий значение целочисленного трехзначного параметра, чтобы его цифры стали упорядочены по убыванию. Метод должен возвращать значение false, если параметр задан неверно. При удачном преобразовании метод возвращает true. 

Заголовок метода: 
bool Transform(ref uint numb)

Основная программа, используя метод, «общается» с пользователем.
*/

namespace Task_01
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
