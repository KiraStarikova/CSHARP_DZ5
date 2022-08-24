//массив вещественных чисел (5). разницу между максимальным и минимальным элементов массива


double[] CreateArray(int length, int min, int max)
{
    double[] array = new double [length];
    for(int i = 0; i<length; i++)
    {
        array[i] = new Random().NextDouble()*(max - min) + min;
    }
    return array;
}

void PrintArray(double[] array)
{
    for(int i = 0; i<array.Length; i++)
       Console.Write($"{array[i]} ");

       Console.WriteLine();
}

double FindDiff(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < max) min = array[i];
    }
    double diff = max - min;
    return diff;
}

double[] array = CreateArray(4, 1, 99);
PrintArray(array);
double diff = FindDiff(array);
Console.WriteLine("Разница между максимальным и минимальным элементами: " + diff);