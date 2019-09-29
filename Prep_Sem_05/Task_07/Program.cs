using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Программа должна считывать с клавиатуры данные от пользователя, пока он не введёт -1. Все положительные значения, вводимые пользователем должны попадать в целочисленный массив, отрицательные – отбрасываются. После завершения ввода в программе вычисляется процентное соотношение элементов с чётными и нечётными значениями. Элементы массива и статистика выводится на экран.
*/

namespace Task_07
{
    class Program
    {
        static void AddElem(ref int[] arr, int elem) {
            Array.Resize(ref arr, arr.Length+1);
            arr[arr.Length - 1] = elem;
        }

        static void OddPerc( int[] arr, out double oddPerc) {
            int allCount = arr.Length;
            int oddCount = 0;
            foreach (int memb in arr) {
                if (memb % 2 == 1)
                    oddCount += 1;
            }
            oddPerc = 100 * (double)oddCount / allCount;
        }

        static void Main(string[] args)
        {   //var-s
            int userNum = 0 ;
            do
            {
                //creating array
                int[] intArr = new int[0];
                //input
                Console.Write("Input as many integers as you want:");
                while (userNum != -1) {
                    int.TryParse(Console.ReadLine(), out userNum);
                    if(userNum > 0)
                        AddElem(ref intArr, userNum);



                }
                //display array
                Console.Write("Array:");
                foreach (int memb in intArr)
                    Console.Write(memb + " ");
                //Even and odd percentage
                double oddPerc;
                OddPerc(intArr, out oddPerc);
                double evenPerc = 100 - oddPerc;
                Console.WriteLine($"\nodd numbers: {oddPerc:F3}, even numbers: {evenPerc:F3}");

                //output
                Console.WriteLine();
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
