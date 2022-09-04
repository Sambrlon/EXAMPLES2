// вид 1 Ничего не принимают и не возвращают.

void Method1()
{
    Console.WriteLine("Автор Артем");
}
 //Method1();


 //2 группа методов: что-то принимают, ничего не возвращают 

 void Method2(string msg)
 {
    Console.WriteLine(msg);
 }
//Method2(msg: "Текст сообщения");


void Method21(string msg, int count )
 {
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
 }
 //Method21("Текст", count: 4);


 //Третья группа методов: Возвращают и не принимаю

 int Method3()
 {
    return DateTime.Now.Year;
}
int year = Method3();
// Console.WriteLine(year);

//Метод 4 : что-то принимают и что-то возвращают

//string Method4(int count, string text)
//{
 //   int i = 0;
 //   string result = string.Empty;

 //   while(i < count)
 //   {
 //       result = result + text;
  //      i++;
//}
 //   return result;
//}
//string res = Method4(10, "Ивановка," );
// Console.WriteLine(res);


string Method5(int count, string text)
{
    string result = string.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method5(10, "Ивановка," );
//Console.WriteLine(res);


//for (int i = 2; i <= 10; i++)
//{
//    for (int j = 2; j <= 10; j++)
 //   {
 //       Console.WriteLine($"{i} * {j} = {i * j}");
 //   }
 //   Console.WriteLine();
//}


// Отсортировать числа в порядке возрастания.

int[] array = {1,3,2,6,4,5,8,7};

void PrintArray( int[] array)
{
    int count = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort( int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        //
        //
        //
        int temporary = array[i];
        array [i] = array [minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(array);
SelectionSort(array);
PrintArray(array);

