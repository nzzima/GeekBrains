// Задача 39: Напишите программу, которая перевернёт одномерный
// массив (последний элемент будет на первом месте, а первый - на
// последнем и т.д.)

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

void ReverseArray(int[] array)
{
    int temp = 0;
    for(int index = 0; index < array.Length/2; index++)
    {
        temp = array[index];
        array[index] = array[array.Length - index - 1];
        array[array.Length - index - 1] = temp;
    }
}

int[] array = new int[7];
FillArray(array);
System.Console.Write("Array: ");
PrintArray(array);
System.Console.Write("\nReversed array: ");
ReverseArray(array);
PrintArray(array);