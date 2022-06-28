// Задача 2: Напишите программу, которая выводит случайное 
//трёхзначное число и удаляет вторую цифру этого числа.
void FillArray(int [] array)
{
    int index = 0;
    int length = array.Length;
    while (index < length)
    {
        array[index] = new Random().Next(1,10);
        index++;
    }
}
void PrintArray(int [] array2)
{
    int index2 = 0;
    int length2 = array2.Length;
    while (index2<length2)
    {
        Console.Write(array2[index2]);
        index2++;
    }
    Console.WriteLine(" ");
}
int [] mass = new int[3];
FillArray(mass);
Console.WriteLine("Первоначальное число ");
PrintArray(mass);
mass[1]=mass[2];
Console.WriteLine("Конечное число");
Console.WriteLine($"{mass[0]}"+$"{mass[1]}");