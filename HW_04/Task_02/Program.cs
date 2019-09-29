using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Пользователь последовательно вводит целые числа. Для хранения полученных чисел в программе используется одна переменная. Окончание ввода чисел определяется либо желанием пользователя, либо когда сумма уже введённых отрицательных чисел становится меньше -1000. Определить и вывести на экран среднее арифметическое отрицательных чисел.
*/

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {   //var-s
            int sumNeg = 0;
            string input = "";
            int userNum;
            uint nNeg = 0;
            do
            {
                Console.WriteLine("Input an integer or \"R\" to get the result:");
                do
                {

                    do
                    {

                        input = Console.ReadLine();
                    } while (!int.TryParse(input, out userNum) && input != "R");
                    if (input == "R" || input == "r")
                        break;
                    if (userNum < 0)
                    {
                        sumNeg += userNum;
                        nNeg += 1;
                    }
                } while (sumNeg > -1000);

                //output
                if (nNeg == 0)
                    Console.WriteLine("No negative numbers");
                else
                    Console.WriteLine($"The mean is {(double)sumNeg / nNeg:F3}");
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
