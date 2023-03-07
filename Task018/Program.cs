/*Напишите программу, которая по заданному номеру четверти,
показывает диапазон возможных координат точек в этой четверти. */

int part;
Console.Write("Введите плоскость: ");
int.TryParse(Console.ReadLine()!, out part);

switch (part)
{
    case 1:
        Console.WriteLine("X > 0, Y > 0");
        break;
    case 2:
        Console.WriteLine("X < 0, Y > 0");
        break;
    case 3:
        Console.WriteLine("X < 0, Y < 0");
        break;
    case 4:
        Console.WriteLine("X > 0, Y < 0");
        break;
    default:
        Console.WriteLine("Неверный ввод");
        break;
}

/* if (part == 1)
    Console.WriteLine("X > 0, Y > 0");
else if (part == 2)
    Console.WriteLine("X < 0, Y > 0");
else if (part == 3)
    Console.WriteLine("X < 0, Y < 0");
else if (part == 4)
    Console.WriteLine("X > 0, Y < 0");
else
    Console.WriteLine("Неверный ввод"); */