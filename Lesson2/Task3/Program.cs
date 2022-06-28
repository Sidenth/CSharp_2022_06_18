// Задача 3: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число ");
string num = Console.ReadLine();
char [] mass = num.ToCharArray();
if (mass.Length>=3)
{
 Console.WriteLine($"Третья цифра числа {mass[2]}");
}
else
{
Console.WriteLine("Третьей цифры нет " );
}