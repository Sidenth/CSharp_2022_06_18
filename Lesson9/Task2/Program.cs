/*Задача 2: Задайте значения M и N. Напишите программу, которая найдёт
сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30*/

int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}
int PrintSum(int M, int N)
{
    if (N == M)
    {
        return 0;
    }
    int sum = M + 1;
    return PrintSum(M + 1, N) + sum;
}
int M = Prompt("Введите первое число ");
int N = Prompt("Введите первое число ");
if (M > N || M < 0 || N < 0)
{
    Console.WriteLine("Неверные условия ввода");
}
else
{
    int result = PrintSum(M - 1, N);
    Console.WriteLine($"Сумма равна {result}");
}
