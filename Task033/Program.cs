/* Задайте массив. Напишите программу, которая определяет,
ПРисутствует ли заданное число в массиве.*/
int num;
Console.WriteLine("Введите число: ");
int.TryParse(Console.ReadLine()!, out num);

int[] array = NewArray(30, 0, 10);

Console.WriteLine(Contain(array, num));

Console.WriteLine(String.Join(" ", array));

bool Contain(int[] a, int num)
{
    foreach (int element in a)
        if (element == num)
            return true;
    return false;
}

int[] NewArray(int size, int min, int max)
{
    int[] a = new int[size];
    for (int i = 0; i < size; i++)
        a[i] = new Random().Next(min, max);
    return a;

}