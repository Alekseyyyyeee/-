﻿/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/



int N = 5; int M = 5;          // Я скопировал это из сети и вроде как разобрался в этом
int[,] A = new int[N, M];
 
int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = M;
 
for (int i = 0; i < A.Length; i++)
{
    A[col, row] = i + 1;
    if (--gran == 0)
    {
        gran = M * (dirChanges % 2) + N * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
        int temp = dx;
        dx = -dy;
        dy = temp;
        dirChanges++;
    }
    col += dx;
    row += dy;
}
 
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < M; j++)
    {
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}
 




