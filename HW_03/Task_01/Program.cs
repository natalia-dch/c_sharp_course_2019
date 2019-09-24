using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Написать метод, находящий трехзначное десятичное число s, все цифры которого одинаковы и которое представляет собой сумму первых членов натурального ряда, то есть s = 1+2+3+4+… 
Вывести полученное число, количество членов ряда и условное изображение соответствующей суммы, в которой указаны первые три и последние три члена, а средние члены обозначены многоточием. Например, если последний член равен 25, то вывести: 1+2+3+…+23+24+25.

*/

namespace Task_01
{
    class Program
    {
        static int numFinder(out int n)
        {
            int num = 0;
            int step = 1;
            bool checker = false;
            while (num < 1000 && (num < 100 || !checker)) {
                num += step;
                int d1 = num % 10;
                int d2 = num / 10 % 10;
                int d3 = num / 100;
                checker = d1 == d2 && d2 == d3 ? true : false;
                step += 1;
            }
            n = step;
            return num;
        }
        static void Main(string[] args)
        {   //var-s
            int number;
            int n; //количество членов ряда
            do
            {
                //processing
                number = numFinder(out n);
                //output
                Console.WriteLine($"{number}=1+2+3+... ...+{n - 2}+{n - 1}+{n}. Sum consists of {n} elements");
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
