using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Написать метод Props(), получающий в качестве параметров два целых числа N и K, метод имеет два out параметра GCD и LCM – в которые сохраняются вычисленные значения наибольшего общего делителя и наименьшего общего кратного. Метод возвращает значение типа bool: false, если НОД или НОК не может быть вычислено и true в противном случае.

В основной программе получить от пользователя два целых неотрицательных числа и, использовав метод Props(), вычислить их НОД и НОК.*/

namespace Task_01
{
    class Program


    {
        static bool Props(int num1, int num2, out int GCD, out int LCM) {
            //calculating GCD
            int A = num1;
            int B = num2;
            while (A != B) {
                if (A > B)
                    A -= B;
                else
                    B -= A;
            };
            GCD = A;
            //calculating LCM
            int bg = num1 > num2 ? num1: num2;
            int sm = num1 > num2 ? num2 : num1;
            LCM = bg;
            while (LCM % sm != 0) {
                LCM += bg;
            }
            return true;
        }
        static void Main(string[] args)
        {   //var-s
            int num1, num2;
            int GCD, LCM;
            do
            {
                //input
                Console.Write("Input num1:");
                while (!int.TryParse(Console.ReadLine(), out num1) || num1 < 0)
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input num2:");
                while (!int.TryParse(Console.ReadLine(), out num2) || num2 < 0)
                    Console.Write("Input ERROR! Input again:");
                //processing

                //output
                if (Props(num1, num2, out GCD, out LCM))
                    Console.WriteLine($"GCD({num1},{num2})={GCD}; LCM({num1},{num2})={LCM};");
                else
                    Console.WriteLine($"Cannot calculate GCD and LCM for {num1}, {num2}");
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}

