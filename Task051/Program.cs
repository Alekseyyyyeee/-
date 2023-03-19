/*51 Задайте двумерный массив. Найдите сумму элементов,
находящихся на главной диагонали.*/


int m = 5; int n = 5;
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

int sum = 0;
for (int i = 0; i < massive.GetLength(0); i++)
{
    
    for (int j = 0; j < massive.GetLength(1); j++)
    {
       
        if (i == j)
            sum = sum + massive[i, j];
    }
}
Console.WriteLine($"{sum}");

int[,] array = FillArray(3, 4);
PrintArray(array);

int[,] FillArray(int row, int column, int min = 0, int max = 9)
{
    int[,] arr = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            arr[i, j] = new Random().Next(min, max +1);
        }
    }    
    return arr;
}

int[,] mass = FillArray(3, 4);

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}