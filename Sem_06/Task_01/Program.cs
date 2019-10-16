using System;
using System.IO;
using System.Text;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: 
Работа с папками
Создайте консольное приложение. 
Приложение выводит пользователю на экран следующие свойства директории проекта и всех вложенных в него поддиректорий: название, атрибуты, время создания и время последнего изменения. 
Обратите внимание, что необходимо вывести информацию о папках на всех уровнях вложенности в дереве каталогов.
*/

namespace Task_01
{
    class Program
    {

        static void DirOverview(string path, int K, ref string[] deleted)
        {
            try
            {
                deleted = new string[0];
                DirectoryInfo myDir = new DirectoryInfo(path);
                DirectoryInfo[] direcs = myDir.GetDirectories();
                if (direcs.Length == 0)
                { Directory.Delete(myDir.FullName);
                    Array.Resize(ref deleted, deleted.Length + 1);
                    deleted[deleted.Length - 1] = myDir.Name;
                    return;
                }
                    

                for (int i=0;i<direcs.Length;i++)
                {
                    Console.WriteLine($"{direcs[i].Name} {direcs[i].CreationTime} {direcs[i].LastAccessTime} {direcs[i].Attributes}");
                    if (K > 0)
                        DirOverview(direcs[i].FullName, K - 1, ref deleted);
                }
            }
            catch (Exception ex)
            { Console.WriteLine(ex.Message); }

        }
        static void Main(string[] args)
        {   //var-s
            do
            {
                string[] deleted = new string[0];
                Console.Write("Input path to directory:");
                string dirPath = Console.ReadLine();
                int K;
                Console.Write("Input K");
                while (!int.TryParse(Console.ReadLine(), out K) || K < 0)
                    Console.Write("Error!Input again:");
                DirOverview(dirPath, K, ref deleted);
                Console.WriteLine("I deleted:");
                foreach (string item in deleted)
                    Console.WriteLine(item);
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
