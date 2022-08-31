//Задача 15:Программа,которая принимает на вход цифру, обозначающую день недели
// и проверяет, является ли этот день выходным.

Console.WriteLine("Задача 15");

Console.Write("Напишите цифру, обозначающий день недели");

int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("этот день выходной -> Да");
    }
    else
    {
        Console.WriteLine("Этот день не выходной");
    }

if(dayNumber < 1 || dayNumber > 7 )
{
Console.WriteLine("Это число не является днем недели");
}

