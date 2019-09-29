using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Пользователем с клавиатуры вводится целые числа N и K (1 ≤ K ≤ N). Сформировать массив A размера N. Вывести элементы массива с индексами, кратными K: AK, A2·K, A3·K, … .

Условный оператор не использовать.
*/

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {   //var-s
            uint N;
            uint K;
            do
            {
                //input
                Console.Write("Input N:");
                while (!uint.TryParse(Console.ReadLine(), out N))
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input K:");
                while (!uint.TryParse(Console.ReadLine(), out K) || K > N)
                    Console.Write("Input ERROR! Input again:");
                //create array
                int[] myArray = new int[N];
                for (int i = 0; i < myArray.Length; i++)
                {
                    myArray[i] = (i + 3) * i + 4;
                    Console.Write(myArray[i] + " ");
                }
                //вывести кратные K
                for (uint i = K; i < N; i += K)
                { Console.Write("\n" + myArray[i]); }
                Console.WriteLine();
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
