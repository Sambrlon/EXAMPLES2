// Задача 39 : Программа которая перевернёт одномерный массив 
//(Последний элемент будет на первом месте, первый на последнем и т.д.)

/*
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

*/


///////////////////////////2 СПОСОБ/////////////////////////////////////////

/*
//Задача 39: Напишите программу, которая перевернёт одномерный массив
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1,2,3] -> [3,2,1]
Console.Clear();

Console.WriteLine("Введите размерность массива: ");
int size = int.Parse(Console.ReadLine());

int [] array = FillArray(size, 1, 10);

int [] FillArray(int size, int min, int max){
int [] result = new int[size];
for(int i = 0; i < size;i++){
result[i] = new Random().Next(min, max + 1);
}
return result;
}

Console.WriteLine("Входной массив: ");
Console.WriteLine(String.Join(" ", array));

Console.WriteLine("Полученный массив: ");
Console.WriteLine(String.Join(" ", array.Reverse()));

Console.WriteLine("Полученный массив (2 способ): ");
Console.WriteLine(String.Join(" ", ReverseArray(array)));

int [] ReverseArray(int [] array){
int [] result = new int[array.Length];
for(int i = 0; i < array.Length;i++){
result[i] = array[array.Length - 1 - i];
}
return result;
}
*/





/*
//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше 
//суммы двух других сторон.
Console.Clear();

int A, B, C;
Console.Write("Введите длины сторон треугольника: ");
while(!int.TryParse(Console.ReadLine(), out A)|| A < 0)
{
    Console.Write("Введите положительное число: ");
}
Console.Write("Введите длины сторон треугольника: ");
while(!int.TryParse(Console.ReadLine(), out B)|| B < 0)
{
    Console.Write("Введите положительное число: ");
}
Console.Write("Введите длины сторон треугольника: ");
while(!int.TryParse(Console.ReadLine(), out C)|| C < 0)
{
    Console.Write("Введите положительное число: ");
}

if(A < B+C & B < A+C & C < A+B)
{
    Console.Write("Правильно существование сторон: ");
}
else
{
    Console.Write("Не правильно ");
}
    */





Console.Clear();
Console.WriteLine("Введите число: ");
int value = int.Parse(Console.ReadLine());
string BinaryCode = Convert.ToString(value, 2);
Console.WriteLine(BinaryCode);