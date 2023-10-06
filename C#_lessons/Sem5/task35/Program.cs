void FillArray(int[] array)
{
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(-1000, 1000);
    }
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for(int index = 0; index < array.Length; index++)
    {
        if (index == array.Length - 1)
        {
            System.Console.Write($"{array[index]}");
        }
        else System.Console.Write($"{array[index]}" + ", ");
    }
    System.Console.Write("]");
}

int CountOfNumbers(int[] array)
{
    int count = 0;
    for(int index = 0; index < array.Length; index++)
    {
        if ((array[index] >= 10) && (array[index] <= 99))
        {
            System.Console.WriteLine($"Number {array[index]} in [10,99]");
            count++;
        }
    }
    return count;
}

int[] array = new int[123];
FillArray(array);
PrintArray(array);
int count = CountOfNumbers(array);
System.Console.WriteLine($"Count of numbers = {count}");