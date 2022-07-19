/*Задача 2: Задайте прямоугольный двумерный массив. Напишите программу,
которая будет находить строку с наименьшей суммой элементов.*/

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
            Console.Write($"{array[i, j]}\t ");
        }
    }
    Console.WriteLine();
}
int[,] SumElementsArray(int[,] array)
{
    int i1 = 0;
    int j1 = 0;
    int sum = 0;
    int[,] array2 = new int[1, array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        array2[i1, j1] = sum;
        j1++;
        sum = 0;
    }
    return array2;
}
void MinSumPrint(int[,] array, int[,] array2)
{
    int min = array2[0, 0];
    int i = 0;
    int PosI = 0;
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        if (array2[i, j] < min)
        {
            min = array2[i, j];
            PosI = j;
        }
    }
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[PosI, j]}\t");
    }
    Console.WriteLine();
}
int rows = Prompt("Введите количество строк");
int columns = Prompt("Введите количество столбцов");
int[,] array = GenerateArray(rows, columns, -10, 10);
PrintArray(array);
Console.WriteLine("Строка с наименьшей суммой элементов");
MinSumPrint(array, SumElementsArray(array));
