int[] PrintArray(int number)
{
    Random rnd = new Random();
    int[] array = new int[number];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 51);
        System.Console.Write($"{array[i]}, ");
    }
    return array;

}
void SummIndex(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = (sum + array[i]);
    }
    System.Console.WriteLine();
    System.Console.Write($"Сумма чисел нечетных индексов = {sum} ");
}

System.Console.WriteLine("Введите количество элементов массива");
int number = Convert.ToInt32(Console.ReadLine());
int[] array = PrintArray(number);
SummIndex(array);