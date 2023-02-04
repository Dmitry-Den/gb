// Задача 21 Напишите программу, которая принимает на вход координаты двух
// точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Введите координаты x1, y1 и z1: ");
int x1 = int.Parse(Console.ReadLine()!), y1 = int.Parse(Console.ReadLine()!), z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты x2, y2 и z2: ");
int x2 = int.Parse(Console.ReadLine()!), y2 = int.Parse(Console.ReadLine()!), z2 = int.Parse(Console.ReadLine()!);

double res = Math.Round(Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2)), 2);
Console.WriteLine($"Расстояние между точками: {res}");