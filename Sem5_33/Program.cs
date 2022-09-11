/*
// Задача 33: Задайте массив. Напиши программу, которая определяет,
//присутствует ли заданное число в массиве.
//4, массив [6,7,3,8,5] -> нет
//3, массив [4,3,2,5,8] -> да
*/

Console.Clear();
Console.WriteLine("Укажите длину массива");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите искомое число:");
int num = int.Parse(Console.ReadLine());
int [] rand = new int[size];
bool A = false;

for(int i = 0; i < rand.Length; i++)
{
    rand[i] = new Random().Next(-9999, 100000);
    Console.Write(rand[i]+" ");
    if(rand[i] == num)
        A = true;
}
if(A == true)
    Console.WriteLine("ДА");
else
Console.WriteLine("НЕТ");
