Console.Write("Введите число");
int num = int.Parse(Console.ReadLine());

Console.WriteLine(num % 7 == 0 && num % 23 == 0 ? "Да" : "Нет");