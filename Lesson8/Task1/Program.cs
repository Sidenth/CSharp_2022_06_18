/*Задача 1: Задайте двумерный массив. Напишите программу, которая
упорядочит по убыванию элементы каждой строки двумерного массива.*/
int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}
int[,] GenerateArray(int rows, int columns, int min, int max)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
    }
    Console.WriteLine();
}
int[,] SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = array.GetLength(1) - 1; k > j; k--)
            {
                if (array[i, k] < array[i, k - 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k - 1];
                    array[i, k - 1] = temp;
                }
            }
        }
    }
    return array;
}
int rows = Prompt("Введите количество строк");
int columns = Prompt("Введите количество строк");
int[,] array = GenerateArray(rows, columns, -10, 10);
PrintArray(array);
Console.WriteLine();
PrintArray(SortArray(array));
