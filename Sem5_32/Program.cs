// Программа замены элементов массива: положительные элементы замените 
// на соответствующие отрицательные, и наоборот.
// [-4,-8,8,2] -> [4,8,-8,-2]

Console.Clear();
Console.WriteLine("Укажите длину массива");
int size = int.Parse(Console.ReadLine());
int [] rand = new int[size];
int [] rand2 = new int[size];
for(int i = 0; i < rand.Length; i++)
{
    rand[i] = new Random().Next(-99, 100);
    Console.Write(rand[i]+" ");
}
Console.WriteLine();
for(int i = 0; i < rand.Length; i++)
{
    rand2[i] = rand[i] * -1;
    Console.Write(rand2[i]+" ");
}
Console.WriteLine();
