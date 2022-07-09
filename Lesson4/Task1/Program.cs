// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine ("Введите два числа A и B");
int A = int.Parse(Console.ReadLine ());
int B =int.Parse(Console.ReadLine ());
int result =1;
int count =1;
while (count <=B)
{
result=result*A;
count++;
}
Console.WriteLine (result);