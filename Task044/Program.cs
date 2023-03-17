/* 44   Не используя рекурсиюБ выведите первые N чисел Фибоначчи.
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */



int num;
Console.WriteLine("Введите число ");
int.TryParse(Console.ReadLine()!, out num);


int left = 0; int right = 1;

Console.Write($"{left} {right} ");

for (int i = 2; i < num; i++)
{
    right = left + right;
    left = right - left;
    Console.Write($"{right} ");
}