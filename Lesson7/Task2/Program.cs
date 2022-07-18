/*Задача 2. Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/
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
void FindElement(int[,] array, int PosI, int PosJ)
{
    bool check = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == PosI - 1 & j == PosJ - 1)
            {
                check = true;
                Console.WriteLine($"Число на позиции ({PosI}, {PosJ}) = {array[i, j]}");
            }
        }
    }
    if (!check)
    {
        Console.WriteLine("Такого числа нет ");
    }
}
int rows = Prompt("Введите количество строк");
int columns = Prompt("Введите количество столбцов");
int[,] array = GenerateArray(rows, columns, -10, 10);
PrintArray(array);
int PosI = Prompt("Введите позицию строки элемента");
int PosJ = Prompt("Введите позицию столбца элемента");
FindElement(array, PosI, PosJ);
