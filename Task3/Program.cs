void ArrayMaxMin()
{
    int number = Convert.ToInt32(Console.ReadLine());
    Random rnd = new Random();
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 101);
        System.Console.Write($"{array[i]}, ");
    }
    int max = array[0];
    int min = array[0];
    int n = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    n = (max - min);
    System.Console.WriteLine();
    Console.Write($"Максимальный Элемент - {max}, Минимальный Элемент - {min}, Разница между ними -  {n}");
}

System.Console.WriteLine("Введите размер массива");
ArrayMaxMin();
