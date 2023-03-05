/* Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */


int num;
Console.Write($"Введите трёхзначное целое число: ");
int.TryParse(Console.ReadLine()!, out num);

int num2 = num / 10;
int result = num2 % 10;
if (num2 < 10 || num2 > 99)
{
Console.WriteLine("Некорректное число");
}
else

Console.WriteLine(result);


