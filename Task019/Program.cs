/* 19Напишите программу, которая принимает на вход пятизначное число и 
проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

int num;
Console.Write("Введите пятизначное число: ");
int.TryParse(Console.ReadLine()!, out num);
if (num < 1000 || num > 100000)
{
    Console.WriteLine("Некорректное число");
}
else if ((num / 10000) == (num % 10))
    if (((num / 1000) % 10) == ((num % 100) / 10))
    {
        Console.WriteLine($"{num} -> да");
    }
    else
    {
        Console.WriteLine($"{num} -> нет");
    }
else if ((num / 10000) != (num % 10))
{
    Console.WriteLine($"{num} -> нет");
}
/*Console.WriteLine($"{num / 10000}" );
Console.WriteLine($"{num % 10}" );

Console.WriteLine($"{(num / 1000) % 10}" );
Console.WriteLine($"{(num % 100) / 10}" );*/