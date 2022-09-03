// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Input A(x;y;z)");
Console.Write("X1: ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Y1: ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Z1: ");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input B(x;y;z)");
Console.Write("X2: ");
int x2 = Convert.ToInt16(Console.ReadLine());
Console.Write("Y2: ");
int y2 = Convert.ToInt16(Console.ReadLine());
Console.Write("Z2: ");
int z2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)));
