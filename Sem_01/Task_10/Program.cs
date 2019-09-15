using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Программа запрашивает у пользователя три любых слова,
 * после чего печатает их в одну строку, разделяя вместо 
 * пробела символом восклицательный знак.
Пример ввода:
Небо
Солнце
Море
Вывод:
Небо!Солнце!Море
*/

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string word1 = Console.ReadLine();
            string word2 = Console.ReadLine();
            string word3 = Console.ReadLine();
            Console.WriteLine(word1 + "!" + word2 + "!" + word3 + "!");
        }
    }
}
