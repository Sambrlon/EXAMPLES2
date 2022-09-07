// Задача 26: Прога которая принимает на вход число и выдаёт количество цифр в числе

Console.Clear();

Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine());

string a = Convert.ToString(A);
Console.WriteLine(a.Length);
