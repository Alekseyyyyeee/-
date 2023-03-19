/*49 Задайте двумерный массив. Найдите элементы, у которых 
оба индекса чётные, и замените эти элементы на их квадраты.*/

int m = 10; int n = 30;

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
Console.WriteLine();


for (int i = 2; i < massive.GetLength(0); i = i + 2)
{
    for (int j = 2; j < massive.GetLength(1); j = j + 2)
    {
            massive[i, j] = massive[i, j] * massive[i, j];
    }

}




for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
        Console.Write($"{massive[i, j]} ");
    Console.WriteLine();
}
