/*Задача 3: Задайте две матрицы. Напишите программу, которая будет
находить произведение двух матриц.*/

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
int[,] MultyMatrix(int[,] array, int[,] array2)
{
    int[,] newArray = new int[array.GetLength(0), array2.GetLength(1)];
    int i1 = 0;
    int j1 = 0;
    int nI = 0;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(0); k++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                result += array[i, j] * array2[i1, j1];
                i1++;
            }
            i1 = 0;
            newArray[nI, j1] = result;
            j1++;
            result = 0;
        }
        j1 = 0;
        nI++;
    }
    return newArray;
}
int rows = Prompt("Введите количество строк первой матрицы");
int columns = Prompt("Введите количество столбцов первой матрицы");
int rows2 = Prompt("Введите количество строк второй матрицы");
int columns2 = Prompt("Введите количество столбцов второй матрицы");
int[,] array = GenerateArray(rows, columns, -10, 10);
Console.WriteLine("Первая матрица");
PrintArray(array);
int[,] array2 = GenerateArray(rows2, columns2, -10, 10);
Console.WriteLine("Вторая матрица");
PrintArray(array2);
if (columns == rows2)
{
    Console.WriteLine("Произведение матриц равно ");
    PrintArray(MultyMatrix(array, array2));
}
else
{
    Console.WriteLine("Такие матрицы нельзя перемножить");
}
