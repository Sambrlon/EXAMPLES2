Console.Write("Введите четверть");
int num = int.Parse(Console.ReadLine());
if(num == 1)
{
    Console.WriteLine($"Диапазон значений в {num} x>0 && y>0");
}
else if(num == 2)
{
    Console.WriteLine($"Диапазон значений в {num} x<0 && y>0");
}
else if(num == 3)
{
    Console.WriteLine($"Диапазон значений в {num} x<0 && y<0");
}
else if(num == 4)
{
    Console.WriteLine($"Диапазон значений в {num} x>0 && y<0");
}
else 
{
    Console.WriteLine("Введите значение от 1 до 4");
}
