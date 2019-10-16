using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Написать метод для формирования массива символов, представляющих отдельные цифры целого числа N, переданного в параметре 
 
 В основной программе, вводя значения целого N > 0, формировать символьный массив его цифр и выводить его элементы на экран.


*/

namespace Task_01
{
    class Program
    {
        static char[] CreateArrFromNum(int N) {
            int digitsQ = N.ToString().Length;
            char[] arr = new char[digitsQ];
            for (int i = 0; i < digitsQ; i++) {
                int digit = N % 10;
                arr[digitsQ - 1 - i] = (char)digit;
                N /= 10;
            }
            return arr;
        }
        static void Main(string[] args)
        {   //var-s
            int N;
            do
            {
                //input
                Console.Write("Input N:");
                while (!int.TryParse(Console.ReadLine(), out N) || N <= 0)
                    Console.Write("Input ERROR! Input again:");
                //create arrays
                char[] arrFromNum = CreateArrFromNum(N);
                //print arr
                foreach (int memb in arrFromNum)
                    Console.Write($"{memb,-2}");
                arrFromNum.
                Console.WriteLine();
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
