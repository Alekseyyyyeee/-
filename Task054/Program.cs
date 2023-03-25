/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/



int m; int n;

Console.Write("Укажите количество строк: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write("Укажите количество столбцов: ");
int.TryParse(Console.ReadLine()!, out n);


int[,] b = new int[m, n];
int[,] massive = new int[m, n];
for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        massive[i, j] = new Random().Next(10);
        b[i, j] = massive[i, j];
        Console.Write($"{massive[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();
int[] temp = new int[n];
for (int i = 0; i <  massive.GetLength(0); i++)
{
    for (int j = 0; j <  massive.GetLength(1); j++)
        temp[j] = b[i, j];
    Array.Sort(temp);
    Array.Reverse(temp);
    for (int k = 0; k < n; k++)
    {
        b[i, k] = temp[k];
        Console.Write("{0} ", b[i, k]);
    }
    Console.WriteLine();
}