/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int m; int n;

Console.Write("Задайте значение M: ");
int.TryParse(Console.ReadLine()!, out m);
Console.Write("Задайте значение N: ");
int.TryParse(Console.ReadLine()!, out n);

Console.Write(Sum(m, n));

int Sum(int m, int n)
{
    if (m == n)
        return m;
    return m + Sum(m + 1, n);
    
}



