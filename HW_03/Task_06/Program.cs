using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: (***) Трехзначным целым числом кодируется номер аудитории в учебном корпусе. Старшая цифра обозначают номер этажа, а две младшие –  номер аудитории на этаже. Из трех аудиторий определить и вывести на экран ту аудиторию, которая имеет минимальный номер внутри этажа. Если таких аудиторий несколько - вывести любую из них. 
*/

namespace Task_06
{
    class Program
    {
        static int smallestNum(int room1, int room2, int room3) {
            int num1 = room1 % 100;
            int num2 = room2 % 100;
            int num3 = room3 % 100;
            int smallest = num1 < num2 ? (num1 < num3 ? room1 : room3) : (num2 < num3 ? room2 : room3);
            return smallest;
        }
        static void Main(string[] args)
        {   //var-s
            int room1, room2, room3;
            do
            {
                //input
                Console.Write("Input 1st room number:");
                while (!int.TryParse(Console.ReadLine(), out room1) || room1 < 101 || room1 > 999)
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input 1st room number:");
                while (!int.TryParse(Console.ReadLine(), out room2) || room2 < 101 || room2 > 999)
                    Console.Write("Input ERROR! Input again:");
                Console.Write("Input 1st room number:");
                while (!int.TryParse(Console.ReadLine(), out room3) || room3 < 101 || room3 > 999)
                    Console.Write("Input ERROR! Input again:");
                //output
                Console.WriteLine(smallestNum(room1, room2, room3));
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
