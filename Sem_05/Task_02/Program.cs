using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Получить от пользователя число К - размер массива и определить массив символов из К элементов. 
Присвоить элементам массива случайные значения от 'A' до 'Z’. 
Использовать методы класса Array (https://docs.microsoft.com/ru-ru/dotnet/api/system.array?view=netframework-4.8) 
вывести полученный массив, 
создать копию массива, 
отсортировать элементы копии в алфавитном порядке и вывести. 
реверсировать (заменить порядок следования элементов на обратный) отсортированный массив и вывести на экран.


*/

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {   //var-s
            uint K;
            do
            {
                //input
                Console.Write("Input length of array:");
                while (!uint.TryParse(Console.ReadLine(), out K) || K < 1)
                    Console.Write("Input ERROR! Input again:");
                //create array
                char[] arr = new char[K];
                //initialize arrays
                Random generator = new Random();

                for (int i = 0; i < K; i++)
                {
                    arr[i] = (char)generator.Next((int)'A', (int)'Z'+1); 
                    Console.Write(arr[i] + " ");
                };
                Console.WriteLine();
                //create a copy
                char[] copyArr = new char[K];
                Array.Copy(arr,copyArr,K);
                //sort A-G
                Array.Sort(copyArr);
                //show sortedArr
                foreach (char memb in copyArr)
                    Console.Write(memb + " ");
                Console.WriteLine();
                //reverse
                Array.Reverse(copyArr);
                //show sortedArr
                foreach (char memb in copyArr)
                    Console.Write(memb + " ");
                Console.WriteLine();
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
