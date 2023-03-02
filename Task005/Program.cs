/* Напишите программу, которая принимает на вход одно число (N),
а на выходе показывает все целые числа от -N до N. */

int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

int i = -N;
while(i <= N)
{
    Console.Write($"{i} ");
    i = i + 1; 
}