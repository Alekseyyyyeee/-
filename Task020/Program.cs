/* Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу квадратов чисел от одного до N. */

int N;
Console.Write("ВВедите N: ");
int.TryParse(Console.ReadLine()!,out N);

int result;
for (int i = 0; i <= N; i++)
{
    result = i * i;
    Console.Write($"{result} ");
}

/*int i = 1; int result;
while (i < N)
{
    result = i * i;
    Console.Write($"{result}, ");
    i++;
}
result = N * N;
Console.Write($"{result} "); */
