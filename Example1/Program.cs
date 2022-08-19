Console.Clear();
Console.Write("Введите число");
int number = int.Parse(Console.ReadLine());

//Решение математическим путем
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} равен {sqr}");

//Решение с использованием библиотеки
int sqr2 = Convert.ToInt32(Math.Pow(number,2));
Console.WriteLine($"Квадрат числа2 {number} равен {sqr2}");