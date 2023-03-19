/*Двумерные массивы. Всё работает.


int[,] array = new int[2, 10];

for (int i = 0; i < array.GetLength(0); i++)   //Строка
{
    for (int j = 0; j < array.GetLength(1); j++ )    //Элементы строки (столбцы)
    {
        array[i, j] = new Random().Next(100);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}*/

/*Задача 48. Задайте двумерный массив размера m на n. 
Каждый элемент массива находится по формуле Amn = m + n. 
Выведите полученный массив на экран.
m = 3
n = 4 */

int m = 10; int n = 18;
int[,] massive = new int[m, n];

for (int i = 0; i < massive.GetLength(0); i++)
{
    for (int j = 0; j < massive.GetLength(1); j++)
    {
        massive[i, j] = i * j;  //Тут я умножил - мне так интереснее
        Console.Write($"{massive[i, j]} ");
    }
    Console.WriteLine();
}
