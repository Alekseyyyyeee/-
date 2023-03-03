/* Напишите программу, которая выводит случайное число из 
отрезка {10, 99} и показывает наибольшую цифру числа. */

int n = new Random().Next(10, 100);

int a = n / 10;
int b = n % 10;
int  dig = a;
if (dig < b) dig = b;
Console.WriteLine(n);
Console.WriteLine(dig);