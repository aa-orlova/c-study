Console.Clear();
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
if (a % 2 == 0)
{
    while (a > b)
{
    b = b + 2;
    Console.Write($"{b} ");
}
}
else
{
    while ((a - 1) > b)
{
    b = b + 2;
    Console.Write($"{b} ");
}
}