using System;
using System.IO;
using System.Text;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Файл firstFile.txt содержит знаки препинания, цифры и латинские буквы. Приложение считывает содержимое файла firstFile.txt и записывает его в файл secondFile.txt, при этом все заглавные буквы удаляются, а каждая цифра удваивается. 
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
                try
                {
                    string input = File.ReadAllText("../../../firstFile.txt");
                    int A = (int)'A';
                    int one = (int)'0';
                    string newStr = "";
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (!(input[i] >= A && input[i] <= A + 25))
                        {
                            newStr += input[i];
                            if (input[i] >= '0' && input[i] <= '9')
                                newStr += input[i];
                        }
                    }

                    Console.WriteLine(newStr);
                    try
                    {
                        File.WriteAllText("../../../secondFile.txt", newStr);
                    }
                    catch (Exception ex) { Console.WriteLine(ex.Message); }


                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}

