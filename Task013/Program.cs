/* Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int num, num2, num3, num4, num5, num6, num7, num8;
Console.Write($"Введите целое положительное число: ");
int.TryParse(Console.ReadLine()!, out num);

if (num < 1)
{
    Console.WriteLine("Некорректное число.");
}
else if (num < 100)
{
    Console.WriteLine($"Третьей цифры нет");
}
else if (num < 1000)
{
    num2 = num % 10;
    Console.WriteLine($"{num2}");
}
else if (num < 10000)
{
    num3 = num % 100;
    num4 = num3 / 10;
    Console.WriteLine($"{num4}");
}
else if (num < 100000)
{
    num5 = num % 1000;
    num6 = num5 / 100;
    Console.WriteLine($"{num6}");
}
else if (num < 1000000)
{
    num7 = num % 10000;
    num8 = num7 / 1000;
    Console.WriteLine($"{num8}");
}
else if (num > 999999)
    Console.WriteLine("Этот быдлокод не принимает семизначные и более числа. Возможно, я это как нибудь исправлю.");
