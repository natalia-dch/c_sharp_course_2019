using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: 
9.1. Написать метод замены всех вхождений максимального элемента массива значением, переданным в параметре.
9.2. В основной программе объявить и инициализировать массив; получить от пользователя число, заменить им все вхождения максимального элемента в массив. Исходный и изменённый массивы вывести на экран.


*/

namespace Task_01
{
    class Program
    {
        static double[] MakeArr(int N)
        {
            Random generator = new Random();
            double[] arr = new double[N];
            for (int i = 0; i < N; i++)
            {
                arr[i] = 10* generator.NextDouble();
            }
            return arr;
        }
        static double[] ChangeMaxInArr(double[] arr, double a) {
            double maxEl = arr[0];
            foreach (double memb in arr)
            {
                if (memb > maxEl) maxEl = memb;
            }
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] == maxEl) arr[i] = a;
            }
            return arr;
        }

        static void printArr(double[] arr)
        {
            foreach (double memb in arr)
                Console.Write($"{memb:F3}\t");
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
                double[] arr = MakeArr(N);
                printArr(arr);
                //input a
                Console.Write("Input a:");
                while (!double.TryParse(Console.ReadLine(), out a) || a < 1)
                    Console.Write("Input ERROR! Input again:");
                double[] changedArr = ChangeMaxInArr(arr, a);
                printArr(changedArr);
                //output
                Console.WriteLine();
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
