/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

int m = 3; int n = 4;

double[,] massive = new double[m, n];

for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        massive[i, j] = new Random().Next(-10, 10) + new Random().NextDouble();
        Console.Write($"{massive[i, j]} ");
    }
    Console.WriteLine();
}

//Не знаю как заполнить массив одновременно и целыми и дробными числами.
//Получается только или целые или дробные.