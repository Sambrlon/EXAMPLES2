//Задача 10: Написать программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.
//456 -> 5 
//782 -> 8

Console.Clear();
Console.WriteLine("Задача 10");
Console.Write("Введите трёхзнычное число");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigitNumber);
Console.WriteLine("Вторая цифра этого числа ->" +stringNumber[1]);