// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Оформите программу ввиде функций (пригодится в дальнейшем)
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
void FillArray(int [] array)
{
    int index = 0;
    int length = array.Length;
    while (index < length)
    {
        array[index] = new Random().Next(1,100);
        index++;
    }
}
void PrintArray(int [] array2)
{
    int index2 = 0;
    int length2 = array2.Length;
    while (index2<length2)
    {
        Console.Write($"{array2[index2]} ");
        index2++;
    }
    Console.WriteLine(" ");
}
int [] mass = new int[8];
FillArray(mass);
Console.WriteLine("Массив из восьми элементов ");
PrintArray(mass);
