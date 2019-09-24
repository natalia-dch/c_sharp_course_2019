using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Написать метод для расчета сложных процентов. 
Параметры: начальный капитал, годовая процентная ставка, число лет (вклада). 
Возвращаемое значение – итоговая сумма в конце срока вклада. 
static double Total(double k, double r, uint n)

В основной программе ввести начальный капитал (больший нуля), процентную ставку и число лет. Вывести таблицу значений итоговых сумм в конце каждого года вплоть до заданного числа лет.
*/

namespace Task_01
{
    class Program
    {
        static double CountInvestment(int startSum, double percent, int n){
            double currentSum = startSum;
            for (int i = 0; i < n; i++) {
                currentSum = currentSum * (100 + percent) / 100;
            }
            return currentSum;
        }
        static void Main(string[] args)
        {   //var-s
            int startSum;
            int years;
            double percent;
            double currentSum;
            
            do
            {
                //input
                Console.Write("Input your initial capital:");
                while (!int.TryParse(Console.ReadLine(), out startSum) || startSum <= 0)
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input how long is your investment:");
                while (!int.TryParse(Console.ReadLine(), out years) || years < 1)
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input percent:");
                while (!double.TryParse(Console.ReadLine(), out percent) || percent <= 0 || percent > 99.0)
                    Console.Write("Input ERROR! Input again:");
                //processing
                Console.WriteLine();
                for (int n = 1; n <= years; n++) {
                    currentSum = CountInvestment(startSum, percent, n);
                    Console.WriteLine($"{n,-5}  {currentSum:C}");
                };

                //output
                Console.WriteLine();
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
