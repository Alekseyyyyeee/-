/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка*/




int m; int n;

Console.Write("Укажите количество строк: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write("Укажите количество столбцов: ");
int.TryParse(Console.ReadLine()!, out n);

int sum = 0;
int summin = 10000;
int row = 0;

int[,] massive = new int[m, n];

int[,] result = new int[m, n];

for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        massive[i, j] = new Random().Next(10);
        result[i, j] = massive[i, j];
        Console.Write($"{massive[i, j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        sum = sum + result[i, j];
        Console.Write($"{sum} ");
       
    }
    
    if (sum < summin)
    {
        summin = sum;
        row = i;
    }
    Console.WriteLine($"     {i + 1} строка");
    sum = 0;
}
Console.Write($"Наименьшая сумма элементов - {summin} - находится в {row + 1} строке.");
