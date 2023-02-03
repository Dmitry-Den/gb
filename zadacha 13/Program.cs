// Задача 13: Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.

Console.Clear();
Console.Write($"Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
while (a > 1000) 
{
a = a/10;
}
if (a>100)
    {
  Console.WriteLine($"Получилось число: {a % 10}");
    }
else {
    Console.WriteLine($"Третьей цифры нет!");
}