using System;

public class Answer
{
    public static double FindMax(double[] array)
    { 
        double max = array[0];
        for(int index = 0; index < array.Length; index++)
        {
            if(array[index] > max) max = array[index];
        }
        return max;
    }

    public static double FindMin(double[] array)
    {
        double min = array[0];
        for(int index = 0; index < array.Length; index++)
        {
            if(array[index] < min) min = array[index];
        }
        return min;
    }

    public static double CalcDifferenceBetweenMaxMin(double[] array)
    {
        return FindMax(array) - FindMin(array);
    }

    public static void PrintArray(double[] array)
    {
        for(int index = 0; index < array.Length; index++)
        {
            System.Console.Write($"{array[index]}" + "\t");
        }
        System.Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        double[] array;
        if (args.Length == 0)
        {
            array = new double[] { 3, 7.4, 22.3, 2, 78 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new double[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (double.TryParse(argStrings[i], out double number))
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
        double diff = CalcDifferenceBetweenMaxMin(array);
        Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
    }
}