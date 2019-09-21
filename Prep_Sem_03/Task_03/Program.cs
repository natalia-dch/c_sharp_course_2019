using System;
class Program
{
    static void Main()
    {

        uint numberFromUser, // Введенное число
        currFigure, // Очередная цифра
        div = 1, // Делитель
        temp; // рабочая переменная


        do
            Console.Write("Введите целое число больше нуля: ");
        while (!uint.TryParse(Console.ReadLine(), out numberFromUser) | numberFromUser == 0); // Ноль или меньше!
        string num = "";
        while (numberFromUser > 0) {
            currFigure = numberFromUser % 10;
            num += currFigure;
            numberFromUser /= 10;
        };
        uint.TryParse(num, out numberFromUser);
        while (numberFromUser > 0)
        {
            currFigure = numberFromUser % 10;
            Console.WriteLine(currFigure);
            numberFromUser /= 10;
        };
    }
}