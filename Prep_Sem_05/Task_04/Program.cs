using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Описать метод ArrayItemDouble(A, X), возвращающий значение типа void, дублирующий в целочисленном массиве A элементы равные целочисленному значению переменной X. 
В вызывающей программе сформировать целочисленный массив размера N (вводится с клавиатуры пользователем), заполнить его случайными числами из диапазона [10, 100] и при помощи метода ArrayItemDouble() продублировать элементы равные введенному пользователем числу Y. 
Исходные и результирующие значения элементов массива вывести на экран. Для формирования массива размера N и вывода массива на экран описать методы.
*/

namespace Task_04
{
    class Program
    {
        static int[] createArray(uint N)
        {
            int[] intArr = new int[N];
            var rand = new Random();
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = rand.Next(10, 101);
            }
            return intArr;
        }

        static void PrintArray(int[] array)
        {
            foreach (int memb in array) { Console.Write(memb + " "); }
        }

        static void ArrayItemDouble(ref int[] A, int X)
        {
            int[] newArr = A;
            for (int i = 0; i < newArr.Length; i++)
            {
                if (newArr[i] == X)
                {
                    Array.Resize(ref A, A.Length + 1);
                    for (int j = A.Length-1; j > i; j--)
                    { A[j] = A[j - 1]; }
                };

            }
        }
        static void Main(string[] args)
        {   //var-s
            uint N;
            int X;
            do
            {
                //input
                Console.Write("Input N:");
                while (!uint.TryParse(Console.ReadLine(), out N))
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input X:");
                while (!int.TryParse(Console.ReadLine(), out X))
                    Console.Write("Input ERROR! Input again:");
                //create array
                int[] myArray = createArray(N);
                PrintArray(myArray);
                ArrayItemDouble(ref myArray, X);
                Console.WriteLine();
                PrintArray(myArray);


                //output
                Console.WriteLine();
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
