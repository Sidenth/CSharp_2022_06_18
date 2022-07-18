/*Задача 3. Задайте двумерный массив из целых чисел. Найдите 
среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/
int Prompt(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}
double[,] GenerateArray(int rows, int columns, int min, int max)
{
    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:F2}\t");
        }
    }
    Console.WriteLine();
}
double[,] ArithMean(double[,] array, int rows)
{
    int i1 = 0;
    int j1 = 0;
    double sum = 0;
    double[,] array2 = new double[1, array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        array2[i1, j1] = Convert.ToDouble(sum / rows);
        j1++;
        sum = 0;
    }
    return array2;
}
int rows = Prompt("Введите количество строк");
int columns = Prompt("Введите количество столбцов");
double[,] array = GenerateArray(rows, columns, 1, 10);
PrintArray(array);
Console.Write($"Среднее арифметическое столбцов ");
PrintArray(ArithMean(array, rows));
