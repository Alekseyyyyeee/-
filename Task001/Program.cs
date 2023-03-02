/* 1. Напишите программу, на вход принимает два числа и проверяет,
является ли первое число квадратом второго.
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3, b = 9 -> нет */



int number1, number2;
Console.Write($"Введите 1 число: ");
int.TryParse(Console.ReadLine()!, out number1);
Console.Write($"Введите 2 число: ");
int.TryParse(Console.ReadLine()!, out number2);
int sqr2 = number2 * number2;
if (number1 == sqr2)
{
    Console.WriteLine("Да");
}
if (number1 != sqr2)
{
    Console.WriteLine("Нет");
}