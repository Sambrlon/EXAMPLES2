// Программа, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве

Console.Clear();

Console.WriteLine("Input A(x;y)");
Console.Write("X1:");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Y1:");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Input B(x;y)");
Console.Write("X2:");
int x2 = Convert.ToInt16(Console.ReadLine());
Console.Write("Y2:");
int y2 = Convert.ToInt16(Console.ReadLine());
Console.WriteLine(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1)));