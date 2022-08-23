// массив, заполненный случайными числами(4, -9, 99). Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for(int i = 0; i<length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
        Console.Write($"{array[i]} ");

    Console.WriteLine();
}

int FindSum(int[] array)
{
    int sum = 0;
    for ( int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    Console.WriteLine("Сумма элементов на нечётных позициях " + sum);
    return 0;

}


int[] array = CreateArray(4, -9, 99);
PrintArray(array);
FindSum(array);