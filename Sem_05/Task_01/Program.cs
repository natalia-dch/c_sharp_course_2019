using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: В программе получить от пользователя количества элементов в двух целочисленных массивах: А и В. Массивы заполнить значениями случайными числами из диапазона [10, 50].
Изменить массив А, добавив в конец все четные по значению элементы  массива B.
На экран вывести:
 Исходный массив A
 Исходный массив B
Модифицированный массив A
Решение основано на однократном проходе массивов и выделении памяти под массив А с запасом 

*/

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {   //var-s
            uint nA, nB;
            do
            {
                //input
                Console.Write("Input length of array A:");
                while (!uint.TryParse(Console.ReadLine(), out nA) || nA < 1)
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input length of array B:");
                while (!uint.TryParse(Console.ReadLine(), out nB) || nB < 1)
                    Console.Write("Input ERROR! Input again:");
                //create arrays
                int[] arrA = new int[nA + nB];
                int[] arrB = new int[nB];
                //initialize arrays
                Random rand = new Random();
                for (int i = 0; i < nA; i++) {
                    arrA[i] = rand.Next(10, 51);
                    Console.Write(arrA[i] + " ");
                };
                Console.WriteLine();
                for (int i = 0; i < nB; i++)
                {
                    arrB[i] = rand.Next(10, 51);
                    Console.Write(arrB[i] + " ");
                };
                Console.WriteLine();
                //change A
                int evenCounter = 0;
                for(int i = 0; i < arrB.Length; i++){
                    if (arrB[i] % 2 == 0) {
                        arrA[nA + evenCounter] = arrB[i];
                        evenCounter++;
                    }
                }
                //show new A
                for (int i = 0; i < arrA.Length; i++)
                {
                    if (arrA[i]!=0)
                        Console.Write(arrA[i] + " ");
                };

                Console.WriteLine();
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
