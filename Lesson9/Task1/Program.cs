/*Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8"*/

int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}
void PrintDif(int result)
{
    if (result < 0)
    {
        Console.WriteLine("Неверные условия ввода, второе число больше первого");
        return;
    }
    if (result == 0)
    {
        return;
    }
    if (result % 2 == 0)
    {
        Console.WriteLine($"{result}");
    }
    PrintDif(result - 1);
}
int M = Prompt("Введите первое число ");
int N = Prompt("Введите первое число ");
int result = M - N;
PrintDif(result);