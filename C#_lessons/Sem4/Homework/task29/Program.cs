// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] collection)
{
    Console.Write("[");
    int count = collection.Length;
    int position = 0;
    while (position < count)
    {
        if (position == count - 1)
        {
            Console.Write(collection[position]);
            position++;
        }
        else
        {
            Console.Write(collection[position] + ", ");
            position++; 
        }
    }
    Console.Write("]");
}

int[] array = new int[8];

FillArray(array);
PrintArray(array);
