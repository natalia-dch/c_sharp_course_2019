using System;
using System.IO;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Создайте два проекта в одном решении. В каждом проекте создайте по одному консольному приложению. В первом приложении пользователь вводит натуральное число n, где 1 < n < 10. На основании введенных данных сгенерируйте массив натуральных чисел, меньших n. Запишите этот массив в двоичный файл “Numbers.bin”, расположенный в корневой папке решения.
Во втором приложении прочитайте числа из файла “Numbers.bin” и выведите их на экран.
*/

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {   //var-s
            do
            {
                byte[] arr = new byte[0];
                //reading file
                try
                {
                     arr = File.ReadAllBytes("../../../Numbers.bin");

                }
                catch (Exception ex) { Console.WriteLine(ex); }
                //output
                for (int i = 0; i < arr.Length; i += 4)
                    Console.WriteLine(BitConverter.ToInt32(arr, i));
                
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
