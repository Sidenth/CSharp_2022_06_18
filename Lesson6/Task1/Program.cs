/*Задача 1: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
void CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Вы ввели {count} положительных чисел ");
}
int Prompt(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int[] PromptArray(string msg, int num)
{
    Console.WriteLine(msg);
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}
int num = Prompt("Сколько чисел вы хотите ввести? ");
CountPositiveNumbers(PromptArray("Введите числа", num));
