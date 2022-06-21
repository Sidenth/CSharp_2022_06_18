// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число ");
int N = int.Parse(Console.ReadLine());
int i =1;
if (N>0)
{
while (i<N)
{ if (i%2==0)
{
    Console.Write(i+" ");
    i++;
}
    i++;
}
Console.WriteLine(" ");
}
else
{
    Console.WriteLine("Вы ввели отрицательное число");
}