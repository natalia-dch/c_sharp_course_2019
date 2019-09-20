using System;
/*
Входные данные представляют собой последовательность натуральных чисел, ограниченную числом 0. Например, 1 12 78 9 0
Вычислить и вывести на экран количество четных чисел в этой последовательности.
Псевдокод программы:
1. Начало
2. Занести в счетчик 0.
3. Начало цикла с постусловием.
4. Получить от пользователя число.
5. Если число четное и не равно 0, увеличить счетчик на 1.
6. Если число равно 0, завершить цикл.
7. Вывести значение счетчика.
8. Завершить выполнение.
9. Конец*/
class Program
{
    static void Main(string[] args)
    {
        do
        {
            int countEven = -1;
            int x;
            Console.WriteLine("Input numbers:");
            do
            {
                while (!int.TryParse(Console.ReadLine(), out x) || x<0)
                    Console.WriteLine("Input error! Input an integer!");
                if (x % 2 == 0)
                    countEven += 1;
            } while (x != 0);
            Console.WriteLine("There are " + countEven + " even numbers");
            Console.WriteLine("Press <esc> to exit, press any key to continue");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);


    }
}
