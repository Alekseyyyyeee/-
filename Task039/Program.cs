/* 039 Напишите программу на разворот одномерного массива*/

int[] array = FillArray(11);

Console.WriteLine($"{String.Join(" ", array)}");
Console.WriteLine($"{String.Join(" ", Reverse2(array))}");
Reverse(array);
Console.WriteLine(String.Join(" ", array));

void Reverse(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int rev = arr.Length - i - 1;
        (arr[i], arr[rev]) = (arr[rev], arr[i]);
    }
}

int[] Reverse2(int[] arr)
{
    int[] arr2 = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        int rev = arr.Length - i - 1;
        arr2[i] = arr[rev];
        
    }
    return arr2;
}


int[] FillArray(int size, int min = 0, int max = 100)
{   
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
        arr[i] = new Random().Next(min, max);
    return arr;
}