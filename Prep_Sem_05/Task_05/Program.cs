using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: 
1.1. Определить и инициализировать целочисленный массив из 10-ти элементов.
1.2. Упорядочить его элементы по возрастанию значений методом Sort().
1.3.Вывести измененный массив (применить оператор foreach).
1.4. Ввести целое число и методом двоичного поиска BinarySearch() найти номер элемента с этим значением в упорядоченном массиве.
1.5. Вывести результат поиска.

*/

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {   //var-s
            do
            {   //1.1
                int[] arrInt = { 1, 8, 6, 4, 9, 2, 5, 3, 7, 10 };
                //1.2
                Array.Sort(arrInt);
                //1.3
                foreach (int memb in arrInt)
                    Console.Write(memb + " ");
                //1.4
                int x;
                Console.Write("Input x:");
                while (!int.TryParse(Console.ReadLine(), out x))
                    Console.Write("Input ERROR! Input again:");
                int position = Array.BinarySearch(arrInt, x);
                if (position >= 0)
                    Console.WriteLine($"arrInt[{position}] = {x}");
                else
                    Console.WriteLine("No such number is found");

                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
