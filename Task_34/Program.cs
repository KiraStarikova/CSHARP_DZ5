//  массив заполненный случайными положительными трёхзначными числами(4), показать количество чётных чисел в массиве.

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

void Main(int[] array)
{
    int evenNumbersCount = 0;

    for(int i = 0; i<array.Length; i++)
    {
        if(array [i] % 2 == 0)
        {
            evenNumbersCount ++;
        }
    }

    Console.WriteLine("Количество чётных чисел " + evenNumbersCount);

}   

int[] array = CreateArray(4, 100, 999);
PrintArray(array);
Main(array);