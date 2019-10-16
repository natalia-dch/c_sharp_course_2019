using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Пользователем с клавиатуры вводится целое число N > 1. В программе сформировать целочисленный массив, содержащий N первых элементов последовательности Фибоначчи: A[0] = 1, A[1] = 1, A[2] = A[0] + A[1], … A[K] = A[K-1] + A[K-2], … Формирование массива организовать при помощи метода. Элементы массива вывести на экран в обратном порядке, методы класса Array не использовать. 



*/

namespace Task_01
{
    class Program
    {
        static int[] MakeArr(int N)
        {
            int[] arr = new int[N];
            arr[0] = 1;
            arr[1] = 1;
            for (int i = 2; i < N; i++)
            {
                arr[i] = arr[i-1]+arr[i-2];
            }
            return arr;
        }

        static void PrintArrReversed(int[] arr)
        {
            for (int i= 0; i<arr.Length;i++)
                Console.Write($"{arr[arr.Length-1-i]}\t");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {   //var-s
            int N;
            do
            {
                //input
                Console.Write("Input N:");
                while (!int.TryParse(Console.ReadLine(), out N) || N <= 1)
                    Console.Write("Input ERROR! Input again:");
                //processing
                int[] arr = MakeArr(N);
                PrintArrReversed(arr);
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
