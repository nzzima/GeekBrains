// Задача 32. Напишите программу замены элементов массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.

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

void ArrayNegation (int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index] > 0) array[index] -= 2 * array[index];
        else if (array[index] < 0) array[index] -= 2 * array[index];
    }
}

int[] array = new int[5];
FillArray(array);
PrintArray(array);
ArrayNegation(array);
System.Console.WriteLine();
;
System.Console.Write($"Result of negation: ");
PrintArray(array);