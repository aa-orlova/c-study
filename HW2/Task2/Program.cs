Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int n1 = n % 10;
if (n < 100)
    Console.WriteLine("Третьей цифры нет");
else if (n >= 100)
{
    while (n > 999)
    {
        n = n / 10;
        n1 = n % 10;
    }
}
Console.WriteLine(n1);