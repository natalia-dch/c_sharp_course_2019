using System;
using System.IO;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Работа с двоичными файлами (запись и чтение)

Задача. 
Создайте два проекта в одном решении. В каждом проекте создайте по одному консольному приложению. В первом приложении пользователь вводит натуральное число n, где 1 < n < 10. На основании введенных данных сгенерируйте массив натуральных чисел, меньших n. Запишите этот массив в двоичный файл “Numbers.bin”, расположенный в корневой папке решения.
Во втором приложении прочитайте числа из файла “Numbers.bin” и выведите их на экран.

*/

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {   //var-s
            int n;
            do
            {
                //input
                Console.Write("Input n:");
                while (!int.TryParse(Console.ReadLine(), out n) || n < 2 || n > 9)
                    Console.Write("Input ERROR! Input again:");
                //create an array
                byte[] arr = new byte[(n - 1)*4];
                for (int i = 0; i < n - 1; i++)
                { byte[] arr1 = BitConverter.GetBytes(i + 1);
                    Array.Copy(arr1,0,arr,i*4,4);
                }

                //working with files
                try
                {
                    File.WriteAllBytes("../../../Numbers.bin", arr);
                }
                catch (Exception ex) { Console.WriteLine(ex); }

                //output
                Console.WriteLine();
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
