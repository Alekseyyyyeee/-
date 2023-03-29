/*Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/



int n;
Console.Write("Задайте число: ");
int.TryParse(Console.ReadLine()!, out n);


Console.Write(Numbers(n));

string Numbers(int k, int i = 1)
{
    if (i == k)
        return k.ToString();
    return $"{k.ToString()}, {Numbers(k - 1)}";
}


