using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: В основной программе ввести размер N целочисленного массива, создать массив
, присвоить его элементам случайные значения из диапазона [-10;10]. Выполнить сжатие массива, удалив из него элементы с четными значениями.  

*/

namespace Task_01
{
    class Program
    {
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
                    Console.Write(memb + " ");
                Console.WriteLine();
                //delete even elems from array
                int oddQ = 0; //quantity of odd elems
                for (int i = 0; i < arr.Length; i++) {
                    if (arr[i] % 2 != 0) arr[oddQ++] = arr[i];
                }
                Array.Resize(ref arr, oddQ);
                //print array
                foreach (int memb in arr)
                    Console.Write(memb + " ");
                Console.WriteLine();
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
