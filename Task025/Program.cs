/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int A, B;
Console.Write("Введите число A: ");
int.TryParse(Console.ReadLine()!, out A);
Console.Write("Введите число B: ");
int.TryParse(Console.ReadLine()!, out B);

Text(A, B);


void Text(int a, int b, int c = 1)
{
    for (int i = 1; i <= b; i++)
    {
        c = c * a;
        
    }
    Console.WriteLine($"{c}");
}