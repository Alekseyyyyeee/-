Console.WriteLine("Введите число");
string text = Console.ReadLine()!;
int number;
int.TryParse(text, out number);           //int number = int.Parse(text);


int answer;
answer = number * number;

//Console.Write(number);
//Console.Write(" ^ 2 = ");
//Console.WriteLine(answer);
Console.WriteLine($"{number} ^ 2 =  {answer}");  //Интерполяция: три строки вывода обработанной информации заменил одной
Console.WriteLine("Всё работает.");