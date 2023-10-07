using System;

public class Answer
{
    public static int CountEvenElements(int[] array)
    { 
        int count = 0;
        for(int index = 0; index < array.Length; index++)
        {
            if(array[index] % 2 == 0) count++;
            else continue;
        }
        return count;
    }

    public static void PrintArray(int[] array)
    {
        for(int index = 0; index < array.Length; index++)
        {
            System.Console.Write($"{array[index]}" + "\t");
        }
        System.Console.WriteLine();
    }


    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
            array = new int[] { 100, 102, 105, 166, 283, 764, 300, 499, 133 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        Console.WriteLine("Массив:");
        PrintArray(array);
        int evenCount = CountEvenElements(array);
        Console.WriteLine($"Количество четных элементов: {evenCount}");
    }
}