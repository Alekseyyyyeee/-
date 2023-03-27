/*69 Напишите прорамму, которая на вход принимает два числа A и B,
и вазводит число A в сцелую степень B с помощью рекурсии*/


int a; int b;

Console.Write("Введите число A: ");
int.TryParse(Console.ReadLine()!, out a);
Console.Write("Введите число B: ");
int.TryParse(Console.ReadLine()!, out b);

Console.Write(Pow(a, b));

int Pow(int a, int b)
{
    if (b == 0)
        return 1;
    return a * Pow(a, b - 1);
}