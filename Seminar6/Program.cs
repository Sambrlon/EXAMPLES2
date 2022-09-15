// Задача 39 : Программа которая перевернёт одномерный массив 
//(Последний элемент будет на первом месте, первый на последнем и т.д.)
Console.Clear();

Console.WriteLine("Введите размерность массива");
int size = int.Parse(Console.ReadLine());

int [] array = FillArray(size, 1, 10);

Console.WriteLine("Входной массив: ");
Console.WriteLine(String.Join(" ", array));

Console.WriteLine("Полученный массив: ");
Console.WriteLine(string.Join(" ", array.Reverse())); // 1 способ

int [] FillArray( int size, int min, int max)
{
    int [] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    return result;
}