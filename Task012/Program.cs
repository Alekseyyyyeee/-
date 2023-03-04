/* Напишите программу, которая будет принимать 
дав числа на вход и выводить, является ли второе 
число кратным первому. Если второе число не кратно первому,
то программа выводит остаток от деления.  */

int num1, num2;
Console.Write($"Введите первое число: ");
int.TryParse(Console.ReadLine()!, out num1);
Console.Write($"Введите второе число: ");
int.TryParse(Console.ReadLine()!, out num2);
int result = num1 % num2;
if (result == 0)
    Console.Write("Кратно");
else
    Console.Write($"Не кратно, остаток {result}");

