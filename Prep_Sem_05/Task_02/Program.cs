using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Описать целочисленный массив из N элементов. N вводится с клавиатуры пользователем. Заполнить массив, используя формулу квадратных треугольных чисел. Sn = 34·Sn-1 – Sn-2 + 2, S0 = 0, S1 = 1. Элементы массива вывести на экран
*/

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {   //var-s
            uint N;
            do
            {
                //input
                Console.Write("Input N:");
                while (!uint.TryParse(Console.ReadLine(), out N))
                    Console.Write("Input ERROR! Input again:");
                //processing
                int[] intArr = new int[N];
                intArr[0] = 0;
                intArr[1] = 1;
                for (int i = 2; i < intArr.Length; i++) {
                    intArr[i] = 34 * intArr[i - 1] - intArr[i - 2] + 2;
                }
                //output
                foreach (int memb in intArr) {
                    Console.Write(memb + " ");
                }
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
