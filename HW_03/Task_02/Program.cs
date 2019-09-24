using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Написать метод, преобразующий число переданное в качестве параметра в число, записанное теми же цифрами, но идущими в обратном порядке. 
Например, 1024 - > 4201, 120 -> 21
*/

namespace Task_02
{
    class Program
    {
        static int InvertNum(int x) {
            int invertedNum=x%10;
            int digit;
            x = x / 10;
            while (x > 0) {
                digit = x % 10;
                invertedNum = invertedNum * 10 + digit;
                x = x / 10;
            }
            return invertedNum;
        }
        static void Main(string[] args)
        {   //var-s
            int x;
            do
            {
                //input
                Console.Write("Input ...:");
                while (!int.TryParse(Console.ReadLine(), out x) || x <= 0)
                    Console.Write("Input ERROR! Input again:");
                //processing
                int inverted = InvertNum(x);
                //output
                Console.WriteLine(inverted);
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
