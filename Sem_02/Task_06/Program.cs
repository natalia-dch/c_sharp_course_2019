using System;
/* 
Задан круг с центром в начале координат и радиусом R=10.   
Ввести  координаты точки и вывести сообщение:   «Точка внутри круга!» или «Точка вне круга!».

Предусмотреть проверку входных данных и цикл повторения решений.  
*/


namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            const int R = 10;
            int x;
            int y;
            string result;
            do
            {//input
                Console.Write("Input x: ");
                while (!int.TryParse(Console.ReadLine(), out x) || x < 0)
                    Console.Write("Input error! Try again:"); Console.Write("Input y: ");
                while (!int.TryParse(Console.ReadLine(), out y) || y < 0)
                    Console.Write("Input error! Try again:");
                //processing
                result = (x * x + y * y <= R * R) ? "Dot is inside the circle!" : "Dot is outside the circle";
                //output
                Console.WriteLine(result);
                //ending
                Console.WriteLine("Press <esc> to exit, any key to continue");


            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
