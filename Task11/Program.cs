Console.Clear();

Console.Write("Напишите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Напишите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 % num2 == 0)
{
    //Console.WriteLine(num1);
    //Console.WriteLine(num2);
    Console.WriteLine("Кратно");
}
else
{
    //Console.WriteLine(num1);
    //Console.WriteLine(num2);
    Console.Write("Не кратно, остаток:");
    Console.WriteLine(num1 % num2);
}