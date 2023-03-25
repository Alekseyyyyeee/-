/* 55 Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
В случае, если это невозможно, программа должна вывести собщение для пользователя.*/

int m; int n;

Console.Write("Укажите количество строк: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write("Укажите количество столбцов: ");
int.TryParse(Console.ReadLine()!, out n);

int[,] array = new int[m, n];

if (m != n)
{
    Console.WriteLine("Невозможно развернуть данный массив - количестов строк не равно количеству столбцов.");
    return;
}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < i; j++)
    {
        (array[i, j], array[j, i]) = (array[j, i], array[i, j]);
    }
    
}



for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}