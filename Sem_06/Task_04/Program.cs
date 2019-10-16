using System;
using System.IO;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: XOR-шифрование

Написать программу для XOR-шифрования и расшифровавания введенной строки по заданному ключу, ключ читать из файла.
*/


    class Program
    {

    static string EncriptMe(string message, short key) {
        //encript a string
        string encripted = "";
        for (int i = 0; i < message.Length; i++)
        {
            encripted += (char)(message[i] ^ key);
        }
        Console.WriteLine(encripted);
        return encripted;

    }
    static void Main(string[] args)
    {   //var-s
        do
        {
            //input
            Console.Write("Input a string:");
            string message = Console.ReadLine();
            //generate a key
            Random generator = new Random();
            int len = message.Length;
            byte[] key = new byte[32];
            for (int i = 0; i < 32; i++)
                key[i] = (byte)generator.Next(0, 2);
            //write key to a file
            File.WriteAllBytes("../../../key.bin", key);
            byte[] myKey = File.ReadAllBytes("../../../key.bin");
            //read key from a file
            short myKeyShort = BitConverter.ToInt16(myKey, 0);
            //encript a message
            string encr = EncriptMe(message, myKeyShort);
            string decr = EncriptMe(encr, myKeyShort);

            //processing
            //output
            Console.WriteLine();
            //ending
            Console.WriteLine("Press<esc> to exit, any key to continue");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}
