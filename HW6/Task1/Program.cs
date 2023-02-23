void InputArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
    {
    Console.Write("Введите число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void ReleaseArray(int[] array)
{
  int count = 0;
  foreach (int i in array)
  {
    if (i > 0)
    count++;  
  }
  Console.WriteLine($"Положительных чисел: {count}");
}

Console.Clear();

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

InputArray(array);
Console.WriteLine($"Начальный массив: [{string.Join(", ", array)}]");

ReleaseArray(array);