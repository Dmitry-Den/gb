// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую
// день недели, и проверяет, является ли этот день выходным.
Console.Clear();

Console.Write("Введите номер дня недели n: ");
int n = int.Parse(Console.ReadLine()!);
    if(n>0 && n<6)
    {
        Console.WriteLine("Будний день"); 
    }
    if (n>5 && n<8)
    {
        Console.WriteLine("Выходной!");
    }
    if(n>7)
    {
        Console.WriteLine("Такого дня недели нет");
    }