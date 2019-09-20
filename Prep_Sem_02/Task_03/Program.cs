using System;
/*Написать программу перевода значения температуры, выраженной в градусах шкалы Цельсия,
 * в шкалах Ранкина, Демиля, Ньютона, Реомюра и Рёмера.*/
class Program
    {
        static void Main(string[] args)
        {
        do
        {
            int tempC;
            int tempRan;
            int tempDem;
            int tempN;
            int tempReo;
            int tempRem;
            Console.Write("Input your temperature in Celcius: ");
            while (!int.TryParse(Console.ReadLine(), out tempC))
                Console.Write("Input error! Try again: ");
            tempRan = (int)((tempC + 273.15) * 9 / 5 );
            tempDem = (int)((100 - tempC) * 3 / 2); //[°De] = (100 − [°C]) × 3⁄2
            tempN = (int)(tempC  * 33 / 100); //	[°N] = [°C] × 33⁄100
            tempReo = (int)(tempC  * 4 / 5); //[°Ré] = [°C] × 4⁄5
            tempRem = (int)((tempC * 21 / 41) + 7.5); //[°Rø] = [°C] × 21⁄40 + 7,5
            Console.WriteLine("Your temperature is {0} in Rankin scale, {1} in Delisle, {2} in Newton, \n {3} in Réaumur, {4} in Rømer", tempRan,
            tempDem, tempN, tempReo, tempRem);
           
            Console.WriteLine("To exit press <esc>, to continue - press any other key");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
