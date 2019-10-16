/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Дата: 15.10
*/

using System;
using System.IO;

class Program
{
    /// <summary>
    /// Создает массив
    /// </summary>
    /// <param name="N">длина "стороны" массива</param>
    /// <returns>созданный массив</returns>
    static int[,] СreateArray(int N)
    {
        int[,] array = new int[N, N];
        Random generator = new Random();

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                array[i, j] = generator.Next(-10, 11);
            }
        }
        return array;
    }

    /// <summary>
    /// считает сумму элементов массива
    /// </summary>
    /// <param name="array">массив</param>
    /// <returns>сумму элементов</returns>
    static int SumArray(int[,] arr)
    {
        int sum = 0;
        foreach (int item in arr)
            sum = sum + item;
        return sum;
    }
    static void Main(string[] args)
    {   //переменные
        int N, //размер массива
            sum; //сумма элементов массива
        do
        {
            //ввод
            Console.Write("Input N:");
            while (!int.TryParse(Console.ReadLine(), out N) || N < 1)
                Console.Write("Input ERROR! Input again:");
            int[,] arr = СreateArray(N);
            sum = SumArray(arr);
            //работа с файлом
            try
            {
                File.WriteAllText("sum.txt", sum.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            //вывод
            Console.WriteLine(File.ReadAllText("sum.txt"));
            //эпилог, повтор решения
            Console.WriteLine("Press<esc> to exit, any key to continue");
        } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
    }
}
