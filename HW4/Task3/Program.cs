/*Первая строка входного файла INPUT.TXT содержит натуральное число N (N ≤ 100) – количество учеников 
(не считая Петю). Во второй строке записаны N натуральных чисел Ai (Ai ≤ 200) – рост учеников в сантиметрах 
в порядке невозрастания. Третья строка содержит единственное натуральное число X (X ≤ 200) – рост Пети.*/

Console.Clear();

Console.Write("Количество учеников: ");
int amount = Convert.ToInt32(Console.ReadLine());
while (amount > 100)
{
    Console.Write("Количество учеников не может превышать 100. Введите заново: ");
    amount = Convert.ToInt32(Console.ReadLine());
}

int[] heightStudents = new int[amount];
for (int i = 0; i < amount; i++)
{
    Console.Write($"Рост ученика № {i+1} в шеренге в порядке убывания: ");
    heightStudents[i] = Convert.ToInt32(Console.ReadLine());
    while (heightStudents[i] > 200)
    {
        Console.Write("Рост ученика не может превышать 200. Введите заново: ");
        heightStudents[i] = Convert.ToInt32(Console.ReadLine());
    }
    if (i > 0)
    {
        while (heightStudents[i] > heightStudents[i - 1])
        {
        Console.Write("Рост этого ученика не может превышать рост предыдущего. Введите заново: ");
        heightStudents[i] = Convert.ToInt32(Console.ReadLine());
        }
    }
    
}

Console.Write("Рост Пети: ");
int heightPetr = Convert.ToInt32(Console.ReadLine());
while (heightPetr > 200)
{
    Console.Write("Рост Пети не может превышать 200. Введите заново: ");
    heightPetr = Convert.ToInt32(Console.ReadLine());
}

int count = 1;
for (int i = 0; heightPetr <= heightStudents[i]; i++)
{
    count = count + 1;
}
Console.WriteLine($"Место Пети в шеренге: {count}");

//Console.WriteLine(string.Join(", ", heightStudents));
