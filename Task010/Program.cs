/* Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */


int num;
Console.Write($"Введите трёхзначное число: ");
int.TryParse(Console.ReadLine()!, out num);

int result;
int num2;

num2 = num / 10;
result = num2 % 10;

Console.WriteLine(result);