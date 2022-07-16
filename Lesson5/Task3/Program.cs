// Задача 3: Задайте массив вещественных чисел. Найдите разницу
//между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76
int[] GenerateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void FindSum (int [] array)
{
    int sum = 0;
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>max)
        {
            max=array[i];
        }
        if (array[i]<min)
        {
            min=array[i];
        }
    }
    sum=max-min;
    Console.WriteLine($"Разница между максимальным и минимальным равна {sum}");
}
int [] array = GenerateArray(5,1,10);
PrintArray(array);
FindSum(array);


