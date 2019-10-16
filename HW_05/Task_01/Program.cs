using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: 8.1. Написать метод формирования массива из N вещественных элементов, значения элементов массива вычисляются по формуле:
𝑎_𝑖=(𝑖(𝑖+1))/2  % N;  i = 0, 1, 2, 3, …, (N-1)
8.2. Написать метод нормировки элементов вещественного массива путем деления каждого элемента на значение максимального по модулю элемента.
8.3. Написать метод вывода на экран значений элементов вещественного массива с точностью до трёх знаков после запятой.
8.4. В основной программе получать от пользователя значение N, формировать и нормировать массив. Исходный и нормированный массивы выводить на экран. 

*/

namespace Task_01
{
    class Program
    {
        static double[] MakeArr(int N) {
            double[] arr = new double[N];
            for (int i = 0; i < N; i++) {
                arr[i] = (double)(i * (i + 1)) / 2 % N;
            }
            return arr;
        }

        static double[] NormArr(double[] arr) {
            double maxEl = arr[0];
            foreach (double memb in arr) {
                if (memb > maxEl) maxEl = memb;
            }
            for (int i = 0; i < arr.Length; i++) {
                arr[i] = arr[i] / maxEl;
            }
            return arr;
        }

        static void printArr(double[] arr) {
            foreach (double memb in arr)
                Console.Write($"{memb:F3}\t");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {   //var-s
            int N;
            do
            {
                //input
                Console.Write("Input N:");
                while (!int.TryParse(Console.ReadLine(), out N) || N < 1)
                    Console.Write("Input ERROR! Input again:");
                //processing
                double[] arr = MakeArr(N);
                printArr(arr);
                double[] normedArr = NormArr(arr);
                printArr(normedArr);
                //output
                Console.WriteLine();
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
