Console.Clear();

Console.Write("Введите число, обозначающее день недели (от 1 до 7): ");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 6 || n == 7)
    Console.WriteLine($"{n} - да");

else Console.WriteLine($"{n} - нет");