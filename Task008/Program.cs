/*Задача 8: Напишите программу, которая на вход принимает число (N), 
а на выходе показывает все чётные числа от 1 до N. */


int N;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out N);

int i = 2;
while(i <= N)
{
    
    Console.Write($"{i} ");
    i = i + 2; 
}
