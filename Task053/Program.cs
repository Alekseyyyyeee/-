/*53 Задайте двумерный массив. Напишите программу, которая
поменяет местами первую и последнюю строки массива.*/


/*int m = 3; int n = 4;
int[,] array = new int[m, n]; 
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

int lastrow = array.GetLength(0) - 1;
for (int i = 0; i < array.GetLength(1); i++)
{
    (array[0, i], array[lastrow, i]) = (array[lastrow, i], array[0, i]);
}



Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}*/


List<List<int>> array = new List<List<int>>();

for (int i = 0; i < 3; i++)
{
    array.Add(new List<int>());
    for (int j = 0; j < 4; j++)
    {
        array[i].Add(new Random().Next(10));
        Console.Write($"{array[i][j]} ");
    }
    Console.WriteLine();
}

Console.WriteLine();

int lastrow = array.Count - 1;
(array[0], array[lastrow]) = (array[lastrow], array[0]);

for (int i = 0; i < 3; i++)
{
    array.Add(new List<int>());
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{array[i][j]} ");
    }
    Console.WriteLine();
}
