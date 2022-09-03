Console.Clear();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

//Решение математическим путем
int sqr = number * number;
Console.WriteLine($"Квадрат числа {number} равен {sqr}");

//Решение с использованием библиотеки
Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine());
int sqr2 = Convert.ToInt32(Math.Pow(number1,2));
Console.WriteLine($"Квадрат числа2 {number1} равен {sqr2}");