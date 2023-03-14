/*Задача 38: Задайте массив вещественных чисел. Найдите разницу 
между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int[] Massive = NewMassive(10, 0, 100);

Console.WriteLine(String.Join(" ", Massive));
int minimum = Massive[0];
int maximum = Massive[0];
int i = 0;
while (i < Massive.Length)
{
    foreach (int element in Massive)
            if (minimum > Massive[i])
                minimum = Massive[i];
            if (maximum < Massive[i])
                maximum = Massive[i];
            i++;
}
Console.WriteLine($"Минимальное число: {minimum}\nМаксимальное число: {maximum}");
Console.WriteLine($"Разница = {maximum - minimum}");

int[] NewMassive(int size, int min, int max)
{
    int[] a = new int[size];
        for (int i = 0; i < size; i++)
            a[i] = new Random().Next(min, max);
        return a;
}