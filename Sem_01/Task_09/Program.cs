using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*В программе ввести значения двух вещественных переменных. 
 * Вывести на экран сумму их дробных частей.
*/

namespace Task_09
{
    class Program
    {
        static void Main(string[] args)
        {   //ввод с клавиатуры
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            double x;
            double.TryParse(input1, out x);
            double y;
            double.TryParse(input2, out y);
            double decimalX = x % 1;
            double decimalY = y % 1;
            Console.WriteLine(decimalX + decimalY);
        }
    }
}
