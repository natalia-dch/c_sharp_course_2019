using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Написать метод для решения квадратного уравнения. 
Параметры – коэффициенты уравнения А, В, С, и два параметра, для получения значений вещественных корней. 

При отсутствии вещественных корней (если А=В=С=0 или А=В=0 и С!=0) метод должен возвращать в точку вызова значение false, иначе - true. 

В основной программе вводить коэффициенты квадратного уравнения, выводить значения вещественных корней или сообщение об их отсутствии.
*/

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {   //var-s
            do
            {
                //input
                Console.Write("Input ...:");
                while (!int.TryParse(Console.ReadLine(), out x))
                    Console.Write("Input ERROR! Input again:");
                //processing
                //output
                Console.WriteLine();
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}

