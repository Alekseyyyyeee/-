/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/



int pos1; int pos2; int m = 5; int n =5;

Console.Write("Задайте индекс требуемой строки: ");
int.TryParse(Console.ReadLine()!, out pos1);
Console.Write("Задайте индекс требуемого столбца: ");
int.TryParse(Console.ReadLine()!, out pos2);

int[,] massive = new int[m, n];
for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        massive[i, j] = new Random().Next(10);
        Console.Write($"{massive[i, j]} ");
    }
    Console.WriteLine();
}

if (m >= pos1 && n >= pos2 && pos1 >= 0 && pos2 >= 0)
    Console.Write($"{pos1} {pos2} -> {massive[pos1, pos2]}");
else
    Console.WriteLine($"{pos1} {pos2} -> Такой позиции в массиве нет");

