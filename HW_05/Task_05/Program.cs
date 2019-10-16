using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: 
Пользователем с клавиатуры вводятся целые числа N > 1, A и D. В программе сформировать и вывести на экран целочисленный массив из N элементов. Элементы вычисляются: A[0] = A, A[1] = A + D, A[2] = A + 2*D, … A[N-1] = A + (N-1)*D. Формирование массива организовать при помощи метода.


*/

namespace Task_01
{
    class Program
    {
        static int[] MakeArr(int N, int A, int D)
        {
            int[] arr = new int[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = A+D*i;
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
            int N, A, D;
            do
            {
                //input
                Console.Write("Input N:");
                while (!int.TryParse(Console.ReadLine(), out N) || N <= 1)
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input A:");
                while (!int.TryParse(Console.ReadLine(), out A))
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input D:");
                while (!int.TryParse(Console.ReadLine(), out D))
                    Console.Write("Input ERROR! Input again:");
                //processing
                int[] arr = MakeArr(N,A,D);
                printArr(arr);
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
