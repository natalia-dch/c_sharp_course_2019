using System;
/* Задача на применение тернарной операции. 
(Не применять оператор if.)
Написать метод, так обменивающий значения трех переменных x, y, z, чтобы выполнилось
требование: x <= y <= z. 
В основной программе, вводить значения трех переменных и упорядочивать их с помощью
обращения к написанному методу. 
Для выхода из программы вводите ESC, для повторения решения – любую другую клавишу. 
*/


class Program
{   public static void SortABC(ref int a, ref int b, ref int c) {
        int a2 = 0;
        int b2 = 0;
        int c2 = 0;
        a2 = a <= b ? (a <= c ? a : c) : (b <= c ? b : c);
        b2 = a < b ? (b < c ? b : (a > c ? a : c)) : (b > c ? b : (a > c ? c : a));
        c2 = a > b ? (a > c ? a : c) : (b > c ? b : c);
        a = a2;
        b = b2;
        c = c2;
    }
    static void Main(string[] args)
    {   //var-s
        int a;
        int b;
        int c;
        do
        {
            //input
            Console.Write("Input \"a\":");
            while (!int.TryParse(Console.ReadLine(), out a))
                Console.Write("Input ERROR! Input \"a\" again:");
            Console.Write("Input \"b\":");
            while (!int.TryParse(Console.ReadLine(), out b))
                Console.Write("Input ERROR! Input \"b\" again:");
            Console.Write("Input \"c\":");
            while (!int.TryParse(Console.ReadLine(), out c))
                Console.Write("Input ERROR! Input \"c\" again:");
            //proccesing
            SortABC(ref a, ref b, ref c);
            //output
            Console.WriteLine($"Now a is {a}, b is {b}, c is {c}");
            //ending
            Console.WriteLine("Press <esc> to exit, any key to continue");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
};
