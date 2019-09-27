using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: В основной программе ввести натуральное число и вычислить суммы его цифр, находящихся в чётных и на нечётных разрядах. Разряд единиц считать нулевым и чётным.

Для этого написать метод с натуральным параметром,  вычисляющий суммы цифр, находящихся на четных и на нечетных позициях в записи значения параметра.  

Заголовок метода: 
void Sums(uint number, out uint sumEven, out uint sumOdd)

Основная программа, используя метод, «общается» с пользователем.

*/

namespace Task_04
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
