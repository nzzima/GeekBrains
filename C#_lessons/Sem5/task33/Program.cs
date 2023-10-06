void FillArray(int[] array)
{
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(-9, 10);
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

void NumberInArray(int[] array, int number)
{
    for (int index = 0; index < array.Length; index++)
    {
        if (number == array[index])
        {
            System.Console.WriteLine($"Number {number} in array !");
            return;
        }
        else continue;
    }
    System.Console.WriteLine($"Number {number} not in array !");
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
NumberInArray(array, new Random().Next(-9, 10));