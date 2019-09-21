using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Вывести таблицу значений функции двух переменных z = F(x,y). Для этого описать метод TabPrint() без параметров, возвращающий значение типа void. Из основной программы вызывать TabPrint().*/

namespace Task_055
{
    class Program
    {
        static void TabPrint()
        {
            for (double x = Math.PI / 4; x <= Math.PI; x += Math.PI / 4)
            {
                for (double y = 0; y <= Math.PI / 3; y += Math.PI / 6)
                {
                    for (int d = 0; d <= 1; d += 1) {
                        double result = Math.Sin(x + d)* Math.Sin(y - d);
                        Console.WriteLine($"{x,-5:F2}{y,-5:F2}{d,-5}|{result,10:F2}"); }
                }
            }
        }
        static void Main(string[] args)
        {   //var-s
            do
            {

                TabPrint();
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
