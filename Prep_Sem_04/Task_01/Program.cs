using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: 
*/

namespace Task_01
{
    class Program
    {
        static int markConverter(int mark10)
        {
            switch (mark10)
            {
                case 1: case 2: case 3: return 2;
                case 4: case 5: return 3;
                case 6: case 7: return 4;
                case 8: case 9: case 10: return 5;
                default: return 0;
            }
        }
        static void Main(string[] args)
        {   //var-s
            int mark10;
            int mark4;
            do
            {
                //input
                Console.Write("Input your mark:");
                while (!int.TryParse(Console.ReadLine(), out mark10))
                    Console.Write("Input ERROR! Input again:");
                //processing
                mark4 = markConverter(mark10);

                //output
                if (mark4 != 0)
                    Console.WriteLine(mark4);
                else
                    Console.WriteLine("Error!");
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
