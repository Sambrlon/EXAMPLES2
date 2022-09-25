//Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Console.Clear();
Console.WriteLine($"Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.\n\nСразу зададим матрицу, которую можно перемножить, т.е. количество столбцов первой равно количеству строк второй");
Console.WriteLine($"Введите размеры матриц и диапазон случайных значений: ");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбов 1 матрицы ( и число строк 2-й): ");
int p = InputNumbers("Введите число столбов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел от 1 до ");

int[,] firstMartrix = new int[m,n];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица: ");
WriteArray(firstMartrix);

int[,] secondMartrix = new int[n,p];
CreateArray(secondMartrix);
Console.WriteLine($"\nВторая матрица: ");
WriteArray(secondMartrix);

int[,] resultMartrix = new int[m,p];

MultiplyMatrix(firstMartrix, secondMartrix, resultMartrix);
Console.WriteLine($"\nПроизведение первой и второй матриц: ");
WriteArray(resultMartrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMartrix )
{
    for (int i = 0; i < resultMartrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMartrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength; k++)
            {
                sum += firstMartrix[i,k] * secondMartrix[k,j];
            }
            resultMartrix[i,j] = sum;
        }
    }
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();    
    }
}