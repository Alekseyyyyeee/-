/* Напишите программу, которая принимает на вход координаты
двух точек и находит растояние между ними в 2D пространстве. */

double[] A = new double[2];
double[] B = new double[2];
Console.Write("Введите координату X точки A: ");
double.TryParse(Console.ReadLine()!, out A[0]);
Console.Write("Введиет координату Y точки A: ");
double.TryParse(Console.ReadLine()!, out A[1]);
Console.Write("Введите координату X точки B: ");
double.TryParse(Console.ReadLine()!, out B[0]);
Console.Write("Введите координату Y точки B: ");
double.TryParse(Console.ReadLine()!, out B[1]);
                                                 //                                     2 - сама степень
double AC2 = (A[0] - B[0]) * (A[0] - B[0]);      // double AC2 = Math.Pow((A[0] - B[0]) 2);  - то же самое, но читать проще
double BC2 = (A[1] - B[1]) * (A[1] - B[1]);      //              Math.Pow - возведение в степень
double AB = Math.Sqrt(AC2 + BC2);                // Math.Sqrt -квадратный корень

Console.Write($"Расстояние между точками A({A[0]}; {A[1]}) и B({B[0]}; {B[1]}) = {AB}");
