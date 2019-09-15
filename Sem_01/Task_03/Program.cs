using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Ваше ФИО: ");
            Console.Write("Фамилия:");
            string surname = Console.ReadLine();
            Console.Write("Имя:");
            string name = Console.ReadLine();
            Console.Write("Отчество:");
            string secondname = Console.ReadLine();
            Console.WriteLine("Фамилия:" + surname);
            Console.WriteLine("Имя:" + name);
            Console.WriteLine("Отчество:" + secondname);
        }
    }
}
