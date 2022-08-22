int GetLenthArray(int number)
{
    int len = 0;
    while (number >= 1)
    {
        number = number / 2;
        len++;
    }
    return len;
}

int [] Converter(int number)
{
    int[] array = new int[GetLenthArray(number)];
    for (int i = array.Length - 1; i >= 0; i--)
    {
        array[i] = number % 2;
        number = number /2;
    }
    return array;   
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

int [] myArray = Converter(23);
PrintArray(myArray);