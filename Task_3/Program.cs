// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число");
double num1 = double.Parse(Console.ReadLine());
if (num1%2==0)
{
    Console.WriteLine("Число является четным");
}
else
{
    Console.WriteLine("Число не является четным");
}