using System;
using System.IO;
using System.Text;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: 1. Программа получает на вход от пользователя число – количество вводимых строк, а затем сами эти строки, введенные с клавиатуры. Все символы полученного текста кодируются в последовательность байтов (используя кодировку UTF-8), после чего выводятся в файл “EncodedFile.txt”, который необходимо расположить в папке с решением. При выводе переносы строк должны сохраняться.


*/

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {   //var-s
            do
            {
                //input
                byte[] bytes = new byte[0];
                try
                {
                    bytes = File.ReadAllBytes("../../../EncodedFile.txt");
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                string output = Encoding.UTF8.GetString(bytes);
                Console.WriteLine(output);
                //
                try
                {
                    File.WriteAllText("../../../DecodedFile.txt", output, Encoding.UTF8);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                FileInfo enfile = new FileInfo("../../../EncodedFile.txt");
                FileInfo defile = new FileInfo("../../../DecodedFile.txt");
                Console.WriteLine(enfile.Name+": "+enfile.Length);
                Console.WriteLine(defile.Name + ": " + defile.Length);
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
