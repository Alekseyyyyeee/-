/* 42 Напишите программу, которая преобразует
десятичное число в двоичное
45 -> 101101
3 -> 11
2 -> 10*/

int[] array = NewMassive(1, 0, 100);
int num = array[0];
int temp = num;

Console.WriteLine(String.Join(" ", array));
Console.WriteLine($"{To2DSystem(num)}");


string To2DSystem(int num)
{
    string ans = "";
    while (num > 0)
    {
        ans = (num % 2).ToString() + ans;
        num /= 2;
    }
    return ans;
}




int[] NewMassive(int size, int min, int max)
{
    int[] a = new int[size];
    for (int i = 0; i < size; i++)
        a[i] = new Random().Next(min, max);
    return a;
}