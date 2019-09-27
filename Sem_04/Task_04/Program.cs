using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: В основной программе ввести натуральное число и вычислить суммы его цифр, находящихся в чётных и на нечётных разрядах. 
Разряд единиц считать нулевым и чётным.

Для этого написать метод с натуральным параметром,  вычисляющий суммы цифр, находящихся на четных и на нечетных позициях в
записи значения параметра.  

Заголовок метода: 
void Sums(uint number, out uint sumEven, out uint sumOdd)

Основная программа, используя метод, «общается» с пользователем.

*/

namespace Task_04
{
    class Program
    {
        static void Sums(uint number, out uint sumEven, out uint sumOdd) {
            sumEven = 0;
            sumOdd = 0;
            uint i = 0;
            uint digit;
            while (number > 0) {
                digit = number % 10;
                if (i % 2 == 0)
                    sumEven+=digit;
                else
                    sumOdd+=digit;
                number /= 10;
                i++;

            }

        }
        static void Main(string[] args)
        {   //var-s
            uint num;
            uint sumEven;
            uint sumOdd;
            do
            {
                //input
                Console.Write("Input an integer:");
                while (!uint.TryParse(Console.ReadLine(), out num))
                    Console.Write("Input ERROR! Input again:");
                //processing
                Sums(num, out sumEven, out sumOdd);
                //output
                Console.WriteLine($"Sum of elements on even places is {sumEven}, sum of elements on odd places is {sumOdd}");
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
