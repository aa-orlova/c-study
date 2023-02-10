Console.Clear();

Console.Write("Введите количество кустов на грядке: ");
int n = Convert.ToInt32(Console.ReadLine());

while (n < 3 || n > 1000)
{
    Console.Write("Так не пойдет! Введите количество кустов ягод: ");
    n = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Введите N куста для сбора ягод: ");
int ni = Convert.ToInt32(Console.ReadLine());
int gather = 0;

if (ni > 1 && ni < n)
    gather = ni + (ni - 1) + (ni + 1);
else if (ni == 1)
{
    gather = ni + (ni + 1) + n;
}
else if (ni == n)
{
    gather = ni + (ni - 1) + 1;
}

Console.Write(gather);