using System;
/*
   Задача:      Написать метод для вычисления площади и длины окружности, 
   радиус которой задает вещественный параметр. 
    В основной программе, вводя значения радиуса, с помощью обращения к методу, 
    вычислять площадь и длину окружности. При вводе применять метод double.TryParse() и 
    проверять корректность введенного значения. При выводе использовать форматную строку 
    метода WriteLine(). Окончание работы программы – ввод нулевого или отрицательного значения 
    радиуса.    

*/

class Program
{ public static double Area(double r) {
        return  Math.PI * r * r;
    }
    public static double Circ(double r)
    {
        return 2 * Math.PI * r;
    }
    static void Main(string[] args)
    {
        //variables
        double r,
              s,
              l;
        //input
        Console.Write("Input radius:");
        while (!double.TryParse(Console.ReadLine(), out r) || r <= 0)
            Console.Write("Input ERROR! Try again:");
        //processing
        s = Area(r);
        l = Circ(r);
        //output
        Console.WriteLine($"{s,-10:G5}{l,-10:G5}");
        //ending
        Console.WriteLine("Press <enter> to exit");
        Console.ReadLine();
    }
}
