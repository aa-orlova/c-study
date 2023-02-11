/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

Console.Clear();

Console.Write("Введите число: ");
string? n = Console.ReadLine();
int length = n.Length;
int sum = 0;
for (int i = 0; i < length; i++)
{
    sum = Convert.ToInt32(n[i].ToString()) + sum;
}

Console.Write(sum);