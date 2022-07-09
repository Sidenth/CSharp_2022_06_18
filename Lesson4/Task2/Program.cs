//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine()); 
int count=0;
int result=0;
while (num>0 )
{
    count=num%10;
    result=result+count;
    num=num/10;
}
Console.WriteLine(result);