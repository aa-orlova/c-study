/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Clear();

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

void ReleaseArray(int[] array)
{
    
    int count = 0;
    foreach (int item in array)
    {
        if ((item % 2) == 0)
        count ++;
    }
    Console.WriteLine($"Количество четных чисел: {count}");
}

int[] array = new int[4];
InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");
ReleaseArray(array);
