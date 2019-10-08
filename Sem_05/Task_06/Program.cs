using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: 
6.1.  Написать метод, реализующий операцию «сжатия массива»: если сумма двух соседних элементов A[i], A[i+1] начиная с первого делится на три, вычислить их произведение. Произведение присвоить элементу A[i]. Элемент A[i+1] удалить, элементы справа от i сдвигаются на одну позицию влево, размер массива уменьшается на 1. Далее обрабатываются элементы, начиная с  (i+1)-го и так до конца массива. 

6.2.  Написать метод, последовательно «запускающий» операцию (метод) сжатия массива и возвращающий количество успешно проведенных операций до момента, когда сжать массив больше невозможно. 
В основной программе ввести размер N целочисленного массива, создать массив, присвоить его элементам случайные значения из диапазона [-10;10]. Выполнить сжатие массива.  


*/

namespace Task_01
{
    class Program
    {
        static int[] compressArr(int[] arr, out bool didCompressed)
        {
            didCompressed = false;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] + arr[i + 1]) % 3 == 0)
                {
                    arr[i] = arr[i] + arr[i + 1];
                    for (int j = i + 1; j < arr.Length - 1; j++)
                        arr[j] = arr[j + 1];
                    Array.Resize(ref arr, arr.Length - 1);
                    didCompressed |= true;
                };
            }
            return arr;
        }

        static int[] StartCompress(out int counter, int[] arr) {
            bool didCompressed;
            int[] newArr = arr;
            counter = 0;
            do
            {
                newArr = compressArr(newArr, out didCompressed);
                if (didCompressed)
                    counter++;
            } while (didCompressed);
            return newArr;
        }
        static void Main(string[] args)
        {   //var-s
            int N;
            do
            {
                //input
                Console.Write("Input length of your array:");
                while (!int.TryParse(Console.ReadLine(), out N) || N < 1)
                    Console.Write("Input ERROR! Input again:");
                //create array
                Random generator = new Random();
                int[] arr = new int[N];
                for (int i = 0; i < N; i++)
                {
                    arr[i] = generator.Next(-10, 11);
                }
                //print array
                foreach (int memb in arr)
                    Console.Write($"{memb,-3} ");
                Console.WriteLine();
                //compress
                int timesCompressed;
                int[] newArr = StartCompress(out timesCompressed, arr);
                //print array
                foreach (int memb in newArr)
                    Console.Write($"{memb,-3} ");
                Console.WriteLine();
                Console.WriteLine($"Compressed {timesCompressed} times");
                
                
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
