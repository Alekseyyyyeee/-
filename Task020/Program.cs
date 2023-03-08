/* Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу квадратов чисел от одного до N. 

** Внизу также сведеня о листе*/

int N;
Console.Write("ВВедите N: ");
int.TryParse(Console.ReadLine()!,out N);


for (int i = 1; i <= N; i++)
{
    Console.Write($"{i * i} ");
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


/*   List<int> "имя этого List" = new List<int>();                - List неограниченное количество элементов 
int[] "имя этого array" = new int[количество элементов]           - array ограниченное количество элементов  */
