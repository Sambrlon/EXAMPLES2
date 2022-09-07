// Программа которая принимает на вход число (А) 
//и выдает сумму чисел от 1 до (А)
// 7->28
//4->10

Console.Clear();

Console.WriteLine("Введите число А");
int A = int.Parse(Console.ReadLine());

Console.WriteLine(GetSum(A));

int GetSum(int a)
{
    int sum = 0;
    for(int i = 0; i <= a; i++)
    {
        sum +=i;
    }
    return sum;
}