/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/



int[] Massive = FillMassive(10, 100, 1000);  

Console.WriteLine(String.Join(" ", Massive));
Console.WriteLine(Contain(Massive));

int Contain(int[] a)
{
    int count = 0;
    foreach (int element in a)
        if (element % 2 == 0)
            count++;
    return count;  
}


int[] FillMassive(int size, int min, int max)
{
    int[] a = new int[size];
        for (int i = 0; i < size; i++)
            a[i] = new Random().Next(min, max);
        return a;

}