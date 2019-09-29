using System;
/*ФИО: Доскач Наталья Алексеевна
Группа: БПИ192
Вариант: - 
Задача: статические классы и члены классов 
*/

class myClassmate
{ // Одноклассник

    const int apprenticeship = 4; // срок обучения (лет)
    static int entranceYear = 2010;
    string name;
    int birthYear;
    static myClassmate()
    {
        entranceYear = 2014;
    }
    public myClassmate() { } // Конструктор умолчания
    public myClassmate(string name, int by)
    {//Конструктор общего вида
        this.name = name;
        birthYear = by;

    }

    public string Information()
    { // Метод объекта
        return "Фамилия: " + name + "; возраст: " +
        (entranceYear - birthYear) +
        " лет; год окончания: " +
        (entranceYear + apprenticeship);
    }

}

class Program
{
    static void Main()
    {
        myClassmate Nan = new myClassmate();
        Console.WriteLine(Nan.Information());
        myClassmate Bob = new myClassmate("Смирнов", 1997);
        Console.WriteLine(Bob.Information());
    }

}

}
