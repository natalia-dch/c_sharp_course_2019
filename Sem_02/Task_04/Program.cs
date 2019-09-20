/*/* Задача 4. 
Написать метод с целочисленным параметром, определяющий является ли значение
аргумента кодом цифры, кодом буквы русского алфавита (прописной либо строчной),
или ни тем и ни другим. В основной программе, вводя целые числа, выводить сообщения
о них: «Это цифра!», «Это буква!», «Это ни буква, ни цифра!». Для выхода из программы
– ESC, для повторения решения - любой символ. При анализе цифрового кода использовать
тернарную операцию. Строку сообщения может возвращать метод, либо метод возвращает признак,
а строку формирует основная программа 
*/
using System;


namespace Task_04
{
    class Program
    {   static string Identif(int code) {
            int codeа = (int)'a';
            int codeя = (int)'я';
            int codeА = (int)'А';
            int codeЯ = (int)'А';
            int code0 = (int)'0';
            int code9 = (int)'9';
            return ((code >= codeа && code <= codeя) || (code >= codeА && code <= codeЯ))? "It's a letter!":((code >= code0 && code <= code9)? "It's a number!": "It's not a number or letter!");




        }
        static void Main(string[] args)
        { char symbol;
            do
            {   //input
                Console.Write("Input letter, number or any other symbol:");
                while (!char.TryParse(Console.ReadLine(), out symbol))
                    Console.Write("Input ERROR! Input again:");
                //processing
                int code = (int)symbol;
                string result = Identif(code);
                //output
                Console.WriteLine(result);
                //ending
                Console.WriteLine("Press <esc> to exit, any key to continue");

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
