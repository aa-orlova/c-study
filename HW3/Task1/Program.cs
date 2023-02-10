/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

Console.Clear();

Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 10000 || n > 99999)
{
    Console.Write("Ошибка! Введите пятизначное число: ");
    n = Convert.ToInt32(Console.ReadLine());
}

int n1 = n / 10000;
int n2 = n / 1000 % 10;
int n4 = n / 10 % 10;
int n5 = n % 10;

if (n1 == n5 && n2 == n4)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}