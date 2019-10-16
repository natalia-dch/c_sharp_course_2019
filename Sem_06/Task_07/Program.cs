using System;
using System.IO;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: Во втором приложении, прочитайте число из файла “IntNumber.txt”, проверив существование файла на диске. Выведите пользователю на экран десятичное значение числа, а затем с новой строки все его 32 двоичных разряда в виде последовательности символов ‘0’ и ‘1’.
*/

namespace Task_07
{
    class Program
    {
        static void Main(string[] args)
        {   //var-s
            do
            {
                //processing
                try
                {
                    if (File.Exists("../../../IntNumber.txt"))
                    {
                        string myBinary = File.ReadAllText("../../../IntNumber.txt");
                        int myNum = 0;
                        for (int i = 0; i < myBinary.Length; i++)
                        {
                            char dig = myBinary[myBinary.Length - i - 1];
                            int digit = dig=='1' ? 1 : 0;
                            myNum += (int)Math.Pow(2, i) * digit; }
                        Console.WriteLine(myNum);
                        for (int i = 0; i < myBinary.Length; i++)
                        { Console.WriteLine(myBinary[i]); }



                    }


                }
                catch (Exception ex) { Console.WriteLine(ex); }
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
