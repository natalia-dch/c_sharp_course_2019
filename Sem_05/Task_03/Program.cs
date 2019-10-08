using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: 3.1. Написать метод, формирующий и возвращающий массив из N членов разложения в ряд функции sin(1):  
	sin(x)= x - x3/3! + x5/5! - ... 
Параметр N – число требуемых членов ряда.

3.2. Написать метод для вычисления sin(х) для заданного х с использованием массива членов ряда sin(1). 
Параметры: ссылка на массив разложения sin(1) и аргумент х.
 
3.3. В основной программе ввести значение N вычислить массив sin(1). Вводя, последовательно вводя, значения х, вычислять sin(х) как с помощью созданного метода, так и с использованием библиотечного метода Math.Sin(). Сравнить результаты. 

*/

namespace Task_01
{
    class Program
    {
        static double[] Sin1ToSeries(uint N){
            double[] series = new double[N];
            int x = 1;
            double elem = x;
            int num = 1;
            for (int i = 0; i < N; i++) {
                series[i] = elem;
                num++;
                elem = elem * (-1) * x * x / ((2*num - 1)*(2*num - 2));

            }
            return series;
        }

        static double CalcSin(double x)
        {
            double elem = x;
            int num = 1;
            double sum = 0;
            while (sum !=sum+elem)
            {
                sum += elem;
                num++;
                elem = elem * (-1) * x * x / ((2*num - 1) * (2*num - 2));

            }
            return sum;
        }
        static void Main(string[] args)
        {   //var-s
            uint N;
            do
            {
                //input
                Console.Write("Input length or the series:");
                while (!uint.TryParse(Console.ReadLine(), out N) || N < 1)
                    Console.Write("Input ERROR! Input again:");
                //create array of elements of sin(1) series
                double[] sinSeries = Sin1ToSeries(N);
                foreach (double memb in sinSeries)
                    Console.Write($"{memb:F4} ");
                Console.WriteLine();
                //input x
                double angle;
                Console.Write("Input x:");
                while (!double.TryParse(Console.ReadLine(), out angle))
                    Console.Write("Input ERROR! Input again:");
                double x = angle % (2 * Math.PI);
                //calc sin(x) using my method
                Console.WriteLine($"My sin({x}) is {CalcSin(x)}");
                //calc sin(x) using library 
                Console.WriteLine($"Library sin({x}) is {Math.Sin(x)}");
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
