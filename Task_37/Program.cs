// Одномерный массив. Найти произведения чисел:
// первый*последний, второй*предпоследний и тд
//результат в новый массив

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
    int len = array.Length;
    for(int i = 0; i < len; i++)
        Console.Write($"{array[i]} ");

    Console.WriteLine();
}

int[] CreateNewArray(int[] array)
{
    int len = array.Length;
    int new_len = 0;

    if (len % 2 == 0) new_len = len / 2;
    else new_len = len / 2 + 1;

    int[] new_array = new int[new_len];

    for(int i = 0; i < new_len; i++)
    {
        new_array[i] = array[i] * array[len - 1 - i];
    }
    if(len % 2 != 0) new_array[len / 2] = array[len / 2];
    return new_array;
}

int[] array = CreateArray(5, 1, 9);
PrintArray(array);
int[] new_array = CreateNewArray(array);
PrintArray(new_array);
               