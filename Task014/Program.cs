/* Напишите программу, которая принимает на вход число 
 и проверяет, кратно ли оно одновременно 7 и 23. */

int num1;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out num1);

if (num1 % 7 == 0 && num1 % 23 == 0)
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");