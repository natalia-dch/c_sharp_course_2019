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
        static bool Transform(ref uint numb) {
            if (numb < 100 || numb > 999)
                return false;
            uint d1 = numb / 100;
            uint d2 = numb / 10 % 10;
            uint d3 = numb % 10;
            uint bgD = d1 > d2 ? (d1 > d3 ? d1 : d3) : (d2 > d3 ? d2 : d3);
            uint mdD = d1 > d2 ? (d2 > d3? d2 : d1 < d3? d1 : d3) : (d2 < d3? d2 : d1 < d3 ? d3 : d1);
            uint smD = d1 < d2? (d1 < d3? d1 : d3) : (d2 < d3? d2 : d3);
            numb = bgD * 100 + mdD * 10 + smD;
            return true;

        }

        static void Main(string[] args)
        {   //var-s
            uint num;
            do
            {
                //input
                Console.Write("Input a number:");
                while (!uint.TryParse(Console.ReadLine(), out num))
                    Console.Write("Input ERROR! Input again:");
                //processing
                bool result = Transform(ref num);
                //output
                if (result)
                    Console.WriteLine(num);
                else
                    Console.WriteLine("Cannot transform the number");
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
