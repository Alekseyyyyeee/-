/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/



int[] Massive = NewMassive(10, 0, 100);

Console.WriteLine(String.Join(" ", Massive));
Console.WriteLine(OddNumbers(Massive));



int OddNumbers(int[] Massive)
{
    int odd = 0;
    for (int i = 1; i < Massive.Length; i = i + 2)
        odd = odd + Massive[i];
        return odd;

}


int[] NewMassive(int size, int min, int max)
{
    int[] a = new int[size];
        for (int i = 0; i < size; i++)
            a[i] = new Random().Next(min, max);
        return a;
}