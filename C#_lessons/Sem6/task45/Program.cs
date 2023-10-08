// Задача 45: Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

void FillArray(int[] array)
{
    for(int index = 0; index < array.Length; index++) array[index] = new Random().Next(1, 10);
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for(int index = 0; index < array.Length; index++)
    {
        if (index == array.Length - 1) System.Console.Write($"{array[index]}");
        else System.Console.Write($"{array[index]}" + ", ");
    }
    System.Console.Write("]");
}

int[] CopyArray (int[] array)
{
    int[] copiedArray = new int[array.Length];
    for (int index = 0; index < array.Length; index++)
    {
        copiedArray[index] = array[index];
    }
    return copiedArray;
}

int[] array = new int[10];

FillArray(array);
System.Console.Write("Old array: ");
PrintArray(array);

System.Console.Write("\nCopied array: ");
int[] copiedArray = CopyArray(array);
PrintArray(copiedArray);