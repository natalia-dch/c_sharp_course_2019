using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Программа запрашивает у пользователя три любых слова, после чего печатает их в столбик, обрамляя каждое слово слева и справа знаками минус.
Пример ввода:
Небо
Солнце
Море
Вывод:
-Небо-
-Солнце-
-Море-
*/

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            string word3 = Console.ReadLine();
            string word11 = "-" + word1 + "-";
            string word12 = "-" + word2 + "-";
            string word13 = "-" + word3 + "-";
            Console.WriteLine(word11);
            Console.WriteLine(word12);
            Console.WriteLine(word13);
        }
    }
}
