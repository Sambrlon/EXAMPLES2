//Задача 13: Программа, которая выводит третью часть заданного числа
//или сообщает, что третьей цифры нет.

Console.WriteLine("Задача 13");
Console.Write("Введите число");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if(anyNumberText.Length > 2)
{
    Console.WriteLine("Третья цифра ->" +anyNumberText[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
