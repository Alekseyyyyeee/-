/*67 Напишите программу, которая будет принимать 
на вход число, и возвращать сумму его цифр*/


int n;

Console.Write("Введите число: ");
int.TryParse(Console.ReadLine()!, out n);


Console.Write(Fact(n));

int Fact(int n)
{
    if (n < 10)
        return n;
    return n % 10 + Fact(n / 10);
}