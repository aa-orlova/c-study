/*Задача 38: Задайте массив вещественных(дробных) чисел. Найдите разницу между 
максимальным и минимальным элементов массива.

[3.1, 7.23, 22.57, 2.45, 78.78] -> 76.33*/

Console.Clear();

double[] array = new double[5];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите число массива (в качестве разделителя <запятая>): ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }


double result = 0, max = array[0], min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    max = array[i];
    else if (array[i] < min)
    min = array[i];
}

result = max - min;

Console.WriteLine($"Начальный массив: [{string.Join("; ", array)}]");
Console.WriteLine($"Разница между максимальным и минимальным: {result}");