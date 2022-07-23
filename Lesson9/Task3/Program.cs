/*Задача 3: Напишите программу вычисления функции Аккермана с помощью
рекурсии. Даны два неотрицательных числа m и n.
m = 3, n = 2 -> A(m,n) = 29*/

int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}
int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}
int m = Prompt("Введите первое число ");
int n = Prompt("Введите первое число ");
if (m < 0 || n < 0)
{
    Console.WriteLine("Неверные условия ввода");
}
else
{
    int result = Akkerman(m, n);
    Console.WriteLine($"Функции Аккермана для чисел {m} и {n} равна {result}");
}
