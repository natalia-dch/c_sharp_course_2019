using System;
using System.IO;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Создайте два консольных приложения в одном решении. 

В первом приложении запросите у пользователя целое неотрицательное число типа int и сохраните его в строковое двоичное представление в файле “IntNumber.txt”, расположенном в одной папке решения (длина файла 4 байта). 


*/

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {   //var-s
            int x;
            do
            {
                //input
                Console.Write("Input x:");
                while (!int.TryParse(Console.ReadLine(), out x) || x < 1)
                    Console.Write("Input ERROR! Input again:");
                //processing
                string myBinary = "";
                while (x > 0)
                {
                    myBinary = (x % 2) + myBinary;
                    x /= 2;
                }
                int len = myBinary.Length;
                for (int i = 0; i < 33 - len; i++)
                    myBinary = "0" + myBinary;
                //record to file
                try { File.WriteAllText("../../../IntNumber.txt", myBinary); } catch (Exception ex) { Console.WriteLine(ex.Message); }

                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
