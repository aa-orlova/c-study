/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Clear();

Console.Write("Введите координату Х числа А: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y числа А: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z числа А: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Х числа B: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y числа B: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Z числа B: ");
double z2 = Convert.ToDouble(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));
Console.Write($"Расстояние между двумя точками: {Math.Round(result, 2)}");