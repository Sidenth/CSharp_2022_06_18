// // Задача 4: Напишите программу, которая принимает на вход 
// цифру, обозначающую день недели, и проверяет, является ли этот 
// день выходным.
Console.WriteLine("Введите номер дня недели");
int day = int.Parse(Console.ReadLine());
if (day==0 || day>7)
{
    Console.WriteLine("Такого дня недели не существует ");
}
if (day==6 || day==7)
{
Console.WriteLine ("Сегодня выходной" );
}
else
{
Console.WriteLine ("Сегодня рабочий день" );
}
