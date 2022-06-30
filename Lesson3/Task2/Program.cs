//Задача 2
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
Console.WriteLine ("Введите координаты точки A (x, y, z)" );
double xa = double.Parse(Console.ReadLine ());
double ya = double.Parse(Console.ReadLine ());
double za = double.Parse(Console.ReadLine ());
Console.WriteLine ("Введите координаты точки B (x, y, z)" );
double xb = double.Parse(Console.ReadLine ());
double yb = double.Parse(Console.ReadLine ());
double zb = double.Parse(Console.ReadLine ());
double res = Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya)+(zb-za)*(zb-za));
Console.WriteLine ($"Расстояние между точками A и B равно {res}");