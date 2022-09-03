//Программа ,которая принимает на вход число N 
// и выдаёт таблицу квадратов чисел от 1 до N.
//5 -> 1 4 9 16 25 

Console.Clear();

Console.Write("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());

int count = 1;
while(num > 0 && count <= num)
{
    Console.Write($"{Math.Pow(count, 2)}  ");
    count++;
}
Console.WriteLine();

while(num < 0 && count >=num)
{
    Console.Write($"{Math.Pow(count, 2)}  ");
    count--;
}
Console.WriteLine();