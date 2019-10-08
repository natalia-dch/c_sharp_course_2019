using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: 4.1. Написать метод для формирования массива, целочисленные неотрицательные элементы которого вычисляются по следующему рекуррентному соотношению: ai+1 = ai%2==0 ? ai/2 :(3*ai+1). 
Процесс вычисления завершается, когда ai+1 станет равным 1. 
Параметр метода задает значение a0. Количество элементов массива заранее не известно, так как определяется значением a0.
 
4.2. Написать метод вывода элементов массива в виде [индекс] = значение, размещая в строке по 5 элементов.

4.3 В основной программе, вводя значения a0, формировать массив и выводить его элементы на экран.

*/

namespace Task_01
{
    class Program
    {
        static int[] CreateArr(int a0){
            int[] arr = new int[1];
            int elem = a0;
            arr[0] = elem;
            while (elem != 1) {
                elem = elem % 2 == 0 ? (elem / 2) : (3 * elem + 1);
                Array.Resize(ref arr, arr.Length + 1);
                arr[arr.Length - 1] = elem;
                
            }
            return arr;
        }

        static void PrintArray(int[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                if (i != 0 & i % 5 == 0)
                    Console.WriteLine();
                Console.Write($"[{i}]={arr[i]}\t");
            }
        }
        static void Main(string[] args)
        {   //var-s
            int a0;
            do
            {
                //input
                Console.Write("Input a0:");
                while (!int.TryParse(Console.ReadLine(), out a0) || a0 < 1)
                    Console.Write("Input ERROR! Input again:");
                //create array
                int[] reqArr = CreateArr(a0);
                //print array
               PrintArray(reqArr);
                Console.WriteLine();
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
