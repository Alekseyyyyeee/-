/* Напишите программу, на вход координаты
точки (X и Y), причём X и Y не равны 0,
и выдаёт номер плоскости, в которой находится эта точка. */

int x, y;
Console.Write($"Введите координату X: ");
int.TryParse(Console.ReadLine()!, out x);
Console.Write($"Введите координату Y: ");
int.TryParse(Console.ReadLine()!, out y);

if (x > 0 && y > 0)
{
    Console.WriteLine(1);
}
else if (x < 0 && y > 0)
{
    Console.WriteLine(2);
}
else if (x < 0 && y < 0)
{
    Console.WriteLine(3);
}
else if (x > 0 && y < 0)
{
    Console.WriteLine(4);
}
else if (x == 0 || y == 0)
{
    Console.WriteLine("Некорректные координаты");
}
