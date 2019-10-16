using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: 
Пользователем с клавиатуры вводится целое число N > 0. В программе сформировать и вывести на экран целочисленный массив из N элементов. Значениями элементов являются степени числа 2 от нулевой до N-1 (1, 2, … 2N-1). Заполнение массива степенями числа 2 организовать при помощи метода.

*/

namespace Task_01
{
    class Program
    {
        static int[] MakeArr(int N)
        {
            int[] arr = new int[N];
            int elem = 1;
            for (int i = 0; i < N; i++)
            {  
                arr[i] = elem;
                elem *= 2;
            }
            return arr;
        }

        static void printArr(int[] arr)
        {
            foreach (int memb in arr)
                Console.Write($"{memb}\t");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {   //var-s
            int N;
            double a;
            do
            {
                //input
                Console.Write("Input N:");
                while (!int.TryParse(Console.ReadLine(), out N) || N < 1)
                    Console.Write("Input ERROR! Input again:");
                //processing
                int[] arr = MakeArr(N);
                printArr(arr);
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
