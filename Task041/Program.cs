/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/



Console.WriteLine("Введите числа:");

int[] arr;
arr = Console.ReadLine()!.Split(' ', ',').Where(i => int.TryParse(i, out _)).Select(int.Parse).ToArray();

Console.WriteLine($"{String.Join(" ", (arr))}");
Console.WriteLine($"{String.Join(" ", Count(arr))}");

int Count(int[] arr)
{
    int num2 = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] > 0)
            num2++;
    return num2;
}