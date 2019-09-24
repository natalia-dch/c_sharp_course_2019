using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Написать метод Function() с двумя логическими параметрами, вычисляющий и возвращающий значение логического выражения (конкретное выражение в условии должно быть явно задано). 
Логическое выражение:
!(p & q) & !(p | !q)

В основной программе построить таблицу истинности логического выражения, заданного методом.

Модифицируйте предложенный на слайде 4 код метода Main() так, чтобы на экран выдавалась таблица из нулей и единиц.
*/

namespace Task_01
{
    class Program
    {
        static int Function(int num1, int num2)
        {
            bool p = num1 == 1 ? true : false;
            bool q = num2 == 1 ? true : false;
            bool result = !(p & q) & !(p | !q);
            return result == true ? 1 : 0;
        }
        static void Main(string[] args)
        {   //var-s
            do
            {
                //proccesing and output
                for (int p = 0; p < 2; p++)
                {
                    for (int q = 0; q < 2; q++)
                    {
                        Console.WriteLine($"{p} {q} | {Function(p, q)}");
                    }
                }

                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
