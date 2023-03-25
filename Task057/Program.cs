/*57 Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных*/


int m; int n;
Console.Write("Укажите количество строк: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write("Укажите количество столбцов: ");
int.TryParse(Console.ReadLine()!, out n);


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

for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        int count = 0;   
        for (int z = 0; z < massive.GetLength(0); z++)
        {
            for (int x = 0; x < massive.GetLength(1); x++)
            {
                if (massive[i, j] == massive[z, x])
                    count++;
            }

        }
        Console.WriteLine($"Элемент {massive[i, j]} встречается {count} раз(а).");

    }

}


