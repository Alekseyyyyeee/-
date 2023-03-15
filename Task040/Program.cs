/*40 Напишите программу, кторая принимает на вход
три числа, и проверяет, может ли существовать треугольник
со сторонами такой длины*/



// С помощью этого можно записать кучу значений сразу, вместо того, что бы вводить их по отдельности
// как здесь:   Console.Write("Введите число N: ");
//              int.TryParse(Console.ReadLine()!, out N);
// array = Console.ReadLine()!.Split(' ', ',').Where(i => int.TryParse(i, out _)).Select(int.Parse).ToArray();
// массив       считывает      знаки между     int.TryParse проверяет, является   отбирает цифры/числа и
//                              символами         ли символ числом или цифрой      записывает в массив



int[] array = FillArray(3);

Console.WriteLine(String.Join(" ", array));

Console.WriteLine(IsTriangle(array[0], array[1], array[2])? "Треугольник существует" : "Треугольник не существует");

bool IsTriangle(int a, int b, int c)
{
    if (a + b > c && b + c > a && c + a > b)
        return true;
    else
        return false;
}

int[] FillArray(int size, int min = 1, int max = 10)
{
    int[] a = new int[size];
    for (int i = 0; i < size; i++)
    {
        a[i] = new Random().Next(min, max);
        
    }
    return a;
}