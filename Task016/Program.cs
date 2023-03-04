/* Напишите программу, которая принимает на вход два 
числа и проверияет, является ли первое число квадратом вторго. */

int num1, num2;
Console.Write($"Введите первое число: ");
int.TryParse(Console.ReadLine()!, out num1);
Console.Write($"Введите второе число: ");
int.TryParse(Console.ReadLine()!, out num2);

if (num1 == num2 * num2)
    Console.Write("Да");
else
    Console.WriteLine("Нет");

