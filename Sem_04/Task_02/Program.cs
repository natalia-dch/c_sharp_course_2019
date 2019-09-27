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
        static bool Shift(ref char ch) {
            if (ch < 'a' || ch > 'z')
                return false;
            ch = (char)('a' + (ch - 'a' + 4) % 26);
            return true;

        }

        static void Main(string[] args)
        {   //var-s
            char sym;
            do
            {
                //input
                Console.Write("Input a symbol:");
                while (!char.TryParse(Console.ReadLine(), out sym))
                    Console.Write("Input ERROR! Input again:");
                //processing
                bool result = Shift(ref sym);
                if (!result)
                    Console.WriteLine("Cannot shift the symbol");
                else
                    Console.WriteLine(sym);

                //output
                Console.WriteLine();
                //ending
                Console.WriteLine("Press<esc> to exit, any key to continue");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
