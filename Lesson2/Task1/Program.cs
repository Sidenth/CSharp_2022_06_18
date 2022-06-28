// Задача 1: Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого 
//числа.
Console.WriteLine("Введите трехзначное число ");
string num = Console.ReadLine();
char [] array= num.ToCharArray();
Console.WriteLine($"Вторая цифра {array[1]}");