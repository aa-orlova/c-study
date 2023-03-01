/*Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Clear();

Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = 0;
for (int i = m; i <= n; i++)
{
    result = result + i;
}
Console.WriteLine($"Сумма чисел от {m} до {n} равна {result}");