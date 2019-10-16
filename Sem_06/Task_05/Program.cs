using System;
using System.IO;
using System.Text;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: . Программа получает на вход от пользователя число – количество вводимых строк, а затем сами эти строки, введенные с клавиатуры. Все символы полученного текста кодируются в последовательность байтов (используя кодировку UTF-8), после чего выводятся в файл “EncodedFile.txt”, который необходимо расположить в папке с решением. При выводе переносы строк должны сохраняться.


*/

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {   //var-s
            int N;
            do
            {
                //input
                Console.Write("Input N:");
                while (!int.TryParse(Console.ReadLine(), out N))
                    Console.Write("Input ERROR! Input again:");
                //input strings
                string input = "";
                for (int i = 0; i < N; i++)
                    input += Console.ReadLine() + "\r\n";
                //encode to bytes
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                try
                {
                    File.WriteAllBytes("../../../EncodedFile.txt",bytes);
                } catch (Exception ex) { Console.WriteLine(ex.Message); };


                Console.WriteLine();
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
