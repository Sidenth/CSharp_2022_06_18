/*Задача 2: Напишите программу, которая найдёт точку пересечения
 двух прямых, заданных уравнениями y = k1 * x + b1, 
 y = k2 * x + b2; значения b1, k1, b2 и k2 задаются 
 пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5);*/
void CrossPoint(int k1, int k2, int b1, int b2)
{
    if (k1 == b1)
    {
        if (k2 == b2)
        {
            Console.WriteLine("Прямые совпадают");
        }
        if (k2 != b2)
        {
            Console.WriteLine("Прямые параллельны");
        }

    }
    else
    {
        int x = (b2 - b1) / (k1 - k2);
        int y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
        Console.WriteLine($"Координаты точки пересечения х = {x}, y = {y})");
    }

}
int Prompt(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int k1 = Prompt("Введите коэффициент k1 ");
int k2 = Prompt("Введите коэффициент k2 ");
int b1 = Prompt("Введите коэффициент b1 ");
int b2 = Prompt("Введите коэффициент b2 ");
CrossPoint(k1, k2, b1, b2);