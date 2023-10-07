using System;

public class Answer
{
    public static int SumOddElements(int[] array)
    {
        int sum = 0;
        for(int index = 1; index < array.Length; index++)
        {
            if(index % 2 != 0) sum += array[index];
        }
        return sum;
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
            array = new int[] { 12, 64, 28, 93, 35, 47, 6, 72, 58, 21 };
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

        PrintArray(array);
        int sumOdd = SumOddElements(array);
        Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
    }
}