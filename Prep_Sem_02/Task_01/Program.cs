using System;
/*Задание 00
 * Доскач Наталья 
 * ЗАДАЧА: Пользователь с клавиатуры вводит два вещественных числа a и b. 
 * Вычислить и вывести на экран их среднее геометрическое: √𝒂∙𝒃.
 */
class Program
{
    static void Main(string[] args)
    {
        do
        {
            double a;
            double b;
            Console.Write("Input a: ");
while(!double.TryParse(Console.ReadLine(), out a))
                Console.Write("Incorrect input! Input a again: ");
            Console.Write("Input b: ");
            while (!double.TryParse(Console.ReadLine(), out b) || a*b < 0)
                            Console.Write("Incorrect input! Input a again: ");

            double result = Math.Sqrt(a * b);
            Console.WriteLine("The result is " + result);
            Console.WriteLine("Press <esc> to exit, any key to continue");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}
