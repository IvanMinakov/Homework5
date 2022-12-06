void CountNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    Random rnd = new Random();
    int count = 0;
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
        Console.Write($"{array[i]} ");

        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    System.Console.WriteLine();
    System.Console.Write($"Количество четных чисел в массиве - {count}");
}

System.Console.WriteLine("Введите длину массива");
CountNumber();