// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
double num2 =double.Parse(Console.ReadLine());
double max = 0, min = 0;
 if (num1>num2)
 {
    max=num1;
    min=num2;
    Console.WriteLine($"Максимальное число {max}, Минимальное число {min}");
 }
 else
 {
    max=num2;
    min=num1;
    Console.WriteLine($"Максимальное число {max}, Минимальное число {min}");
 }
 if (num1==num2)
 {
    Console.WriteLine("Числа равны");
 }