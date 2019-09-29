using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Описать метод ArrayHill(A), возвращающий значение типа void, меняющий порядок следования элементов в вещественном массиве A на следующий: наименьший элемент располагается на первом месте, наименьший из оставшихся – на последнем, следующий по величине – на втором, следующий на предпоследнем и т.д. В вызывающей программе сформировать целочисленный массив размера N (вводится с клавиатуры пользователем), заполнить его случайными числами из диапазона [-10, 10] и обработать при помощи метода ArrayHill(). Исходные и результирующие значения элементов массива вывести на экран. Для формирования массива размера N и вывода массива на экран описать методы.
*/

namespace Task_03
{
    class Program
    {
        static int[] createArray(uint N) {
            int[] intArr = new int[N];
            var rand = new Random();
            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = rand.Next(-10, 11);
            }
            return intArr;
        }

        static void PrintArray(int[] array) {
            foreach (int memb in array) { Console.Write(memb + " "); }
        }

        static void ArrayHill( ref int[] array) {
            Array.Sort(array);
            int[] newArr = new int[array.Length];
            array.CopyTo(newArr,0);
            for (int i = 0; i < array.Length; i++) {
                if (i < (array.Length / 2)) //0-4
                    array[i] = newArr[i * 2];
                else //5-9
                { array[i] = newArr[(newArr.Length - i) * 2 - 1];
                }
            }
        }
        static void Main(string[] args)
        {   //var-s
            uint N;
            do
            {
                //input
                Console.Write("Input N:");
                while (!uint.TryParse(Console.ReadLine(), out N))
                    Console.Write("Input ERROR! Input again:");
                //create array
                int[] myArray = createArray(N);
                PrintArray(myArray);
                ArrayHill(ref myArray);
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
