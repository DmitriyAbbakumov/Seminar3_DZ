/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Write("A(x): ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("A(y): ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("A(z): ");
int az = Convert.ToInt32(Console.ReadLine());
Console.Write("B(x): ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("B(y): ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("B(z): ");
int bz = Convert.ToInt32(Console.ReadLine());

double n = Math.Sqrt(Math.Pow((ax-bx),2) + Math.Pow((ay-by), 2) + Math.Pow((az-bz), 2));
Console.WriteLine($"Расстояние между A и B= {Math.Round(n, 2)}");
