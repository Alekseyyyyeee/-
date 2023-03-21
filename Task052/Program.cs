/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int m = 5; int n = 5;
int[,] massive = new int[m, n];

for (int i =0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        massive[i, j] = new Random().Next(10);
        Console.Write($"{massive[i, j]} ");
    }
    Console.WriteLine();
}

double result;

Console.Write("Среднее арифметическое каждого столбца: ");

for (int j =0; j < massive.GetLength(1); j++)
{
    int sum = 0;
    
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        sum += massive[i, j];
    }
    result =  (double) sum / m;
    
    Console.Write($"{result} ");
}




