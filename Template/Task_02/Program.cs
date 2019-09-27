using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: В основной программе ввести символ, и если это символ латинской строчной буквы - сдвинуть его циклически в алфавите на 4 позиции. 

Для этого написать метод, изменяющий значение символьного параметра (сдвинуть его циклически в алфавите на 4 позиции, влево или вправо по вашему усмотрению).
Метод должен возвращать значение false, если параметр задан неверно. При удачном преобразовании метод возвращает true. 

Заголовок метода: 
bool Shift(ref char ch)

Основная программа, используя метод, «общается» с пользователем.
*/

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {   //var-s
            do
            {
                //input
                Console.Write("Input ...:");
                while (!int.TryParse(Console.ReadLine(), out x))
                    Console.Write("Input ERROR! Input again:");
                //processing
                //output
                Console.WriteLine();
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
