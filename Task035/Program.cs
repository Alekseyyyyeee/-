/* Задайте одномерный массив из 123 случайных чисел,
и найдите количество элементов массива, значения которых 
лежат в отрезке [10, 99]*/



int[] array = NewArray(123, 0, 200);
Console.WriteLine(Contain(array));
Console.WriteLine(String.Join(" ", array));

int Contain(int[] a)
{
    int count = 0;
    foreach (int element in a)
        if (element < 100 && element > 9)
            count++;
    return count;    
}

int[] NewArray(int size, int min, int max)
{
    int[] a = new int[size];
    for (int i = 0; i < size; i++)
        a[i] = new Random().Next(min, max);
    return a;

}