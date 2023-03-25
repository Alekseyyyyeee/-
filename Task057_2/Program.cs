/*57 Составить частотный словарь элементов двумерного массива.
Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных*/


int m; int n;
Console.Write("Укажите количество строк: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write("Укажите количество столбцов: ");
int.TryParse(Console.ReadLine()!, out n);


int[,] massive = new int[m, n];
int[] massive_row = new int[massive.GetLength(0) * massive.GetLength(1)];
for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        massive[i, j] = new Random().Next(10);
        massive_row[i * massive.GetLength(0) + j] = massive[i, j];
        Console.Write($"{massive[i, j]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < massive_row.GetLength(0); i++)
{
    Console.Write($"{massive_row[i]} ");
}

Console.WriteLine();

Array.Sort(massive_row);

for (int i = 0; i < massive_row.GetLength(0); i++)
{
    Console.Write($"{massive_row[i]} ");
}
Console.WriteLine();

int count = 0;
int current = massive_row[0];
for (int i = 0; i < massive_row.GetLength(0); i++)
{
    
    if (current == massive_row[i])
    {
        count++;
    }
    else
    {
       Console.WriteLine($"Элемент {current} встречается {count} раз(а).");
       count = 1;
       current = massive_row[i];
    }
    
}
Console.WriteLine($"Элемент {current} встречается {count} раз(а).");
