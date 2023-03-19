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