/*Задача 6: Напишите программу, которая на вход принимает число 
и выдаёт, является ли число чётным (делится ли оно на два без остатка).*/


int number;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out number);

if (number % 2==1)
{
    Console.WriteLine("Число нечетное");
           
}
else
{
    Console.WriteLine("Число четное");
}
 