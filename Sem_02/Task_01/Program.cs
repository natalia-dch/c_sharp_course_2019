using System;
/*Написать метод для вычисления приближенного значения n-го члена ряда Фибоначчи
 * по формуле Бине:

𝑈_𝑛=(𝑏^𝑛−(〖−𝑏〗^(−𝑛) ))/(2𝑏−1)
𝑏=(1+√5)/2

В основной программе, вводя с помощью метода int.TryParse() значения n,
вычислять и выводить приближенное вещественное значение n-го члена ряда Фибоначчи. Окончание работы программы – ввод нулевого или отрицательного значения n. 
*/
class Program
{
    static double Un(uint n)
    {
        double b = (1 + Math.Sqrt(5)) / 2;
        double result = (Math.Pow(b, n) - (-Math.Pow(-b, -n))) / (2 * b - 1);
        return result;
    }
    static void Main(string[] args)
    {
        //variables
        uint n;
        double result;
        Console.WriteLine("Press any key to start");
 while (Console.ReadKey(true).Key != ConsoleKey.Escape)
        {   //input 
            Console.Write("Input n, must be integer bigger than 0:");
            if (!uint.TryParse(Console.ReadLine(), out n))
                return;

            //proccesing
            result = Un(n);
            //output
            Console.WriteLine("The result is {0}", result.ToString("F2"));
            //ending
            Console.WriteLine("Press <esc> to exit, any key to continue");
        };

    }
}
