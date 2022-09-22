/*
//Задайте двумерный массив размером m*n
//заполненный случайными целыми числами.
Console.Clear();

Console.Write("Количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Количество столбов в массиве: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = FillArray(rows, columns, 1, 10);

PrintArray(array);

int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] filledArray)
{
    for (int i = 0; i < filledArray.GetLength(0); i++)
    {
        for (int j = 0; j < filledArray.GetLength(1); j++)
        {
            Console.Write(filledArray[i, j] + " ");
            //Console.Write($"{illedArray[i, j]} ");
        }
        Console.WriteLine();
    }

}


*/






/*
//Задайте двумерный массив размером m*n, каждый элемент масссива находится по 
//формуле Amn = m+n. Выведите полученный массив на экран.

Console.Clear();

Console.Write("Количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Количество столбов в массиве: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = FillArray(rows, columns);

PrintArray(array);

int[,] FillArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

void PrintArray(int[,] filledArray)
{
    for (int i = 0; i < filledArray.GetLength(0); i++)
    {
        for (int j = 0; j < filledArray.GetLength(1); j++)
        {
            if(filledArray[i,j] / 10 == 0)
            Console.Write(filledArray[i, j] + "  ");
            else Console.Write($"{filledArray[i, j]} ");
        }
        Console.WriteLine();
    }

}
*/





/*
//Задача 49: Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
Например, изначально массив              Новый массив будет выглядеть вот так:
выглядел вот так:                          1 4 7 2
1 4 7 2                                    5 81 2 9
5 9 2 3                                    8 4 2 4
8 4 2 4


Console.Clear();

Console.Write("Количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Количество столбов в массиве: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = FillArray(rows, columns, 1, 10);

PrintArray(array);
Console.WriteLine();
PrintArray(FillArrayCheck(array));

int[,] FillArrayCheck(int[,] array)
{
    for (int i = 1; i < rows; i++)
    {
        for (int j = 1; j < columns; j++)
        {
            if(i % 2 == 1 && j % 2 == 1)
            {
                array[i,j] *= array[i,j];
            }
        }
    }
    return array;
}

int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void PrintArray(int[,] filledArray)
{
    for (int i = 0; i < filledArray.GetLength(0); i++)
    {
        for (int j = 0; j < filledArray.GetLength(1); j++)
        {
            if(filledArray[i,j] / 10 == 0)
            Console.Write(filledArray[i, j] + "  ");
            else Console.Write($"{filledArray[i, j]} ");
        }
        Console.WriteLine();
    }

}
*/
 
 /*
Задача 51: Найти сумму по главной диагонали.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

Console.Clear();

Console.Write("Количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Количество столбов в массиве: ");
int columns = int.Parse(Console.ReadLine());

int[,] array = FillArray(rows, columns, -9, 10);

PrintArray(array);
Console.WriteLine();
DiagonalArray(array);

void DiagonalArray(int[,] array)
{
    int[] Sum = new int[Math.Min(rows, columns)];
    int sum = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if(i == j)
            {
                sum += array[i,j];
                Sum[i] = array[i,j];
            }
        }
    }
    Console.Write($"({String.Join(") + (",Sum)})");
    Console.WriteLine($" = {sum}");
}

int[,] FillArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max);
        }
    }
    return array;
}

void PrintArray(int[,] filledArray)
{
    for (int i = 0; i < filledArray.GetLength(0); i++)
    {
        for (int j = 0; j < filledArray.GetLength(1); j++)
        {
            //if(filledArray[i,j] / 10 == 0)
            //Console.Write(filledArray[i, j] + "   ");
            if(filledArray[i,j] >= 0)
            Console.Write($"{filledArray[i,j]}  ");
            else
            Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }

}