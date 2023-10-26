using System.Runtime.InteropServices;

/// <summary>
/// Класс сортировок массива.
/// </summary>
public static class Sorting
{
    /// <summary>
    /// Сортировка методов выбора
    /// </summary>
    /// <param name="collection">Исходный массив</param>
    /// <returns>Отсортированный массив</returns>
    public static int[] SortSelection(this int[] collection)
    {
        int size = collection.Length;
        for(int i = 0; i < size - 1; i++)
        {
            int pos = i;
            for(int j = i + 1; j < size; j++)
            {
                if (collection[j] < collection[pos]) pos = j;
            }
            int temp = collection[i];
            collection[i] = collection[pos];
            collection[pos] = temp;
        }
        return collection;
    }
    
    /// <summary>
    /// Сортировка методом пузырька (Базовая)
    /// </summary>
    /// <param name="collection">Исходный массив</param>
    /// <returns>Отсортированный массив</returns>
    public static int[] SortBubble(this int[] collection)
    {
        int size = collection.Length;

        for(int current = 0; current < size - 1; current++)
        {
            for(int i = 0; i < size - 1; i++)
            {
                if(collection[i] > collection[i + 1])
                {
                    int temp = collection[i];
                    collection[i] = collection[i + 1];
                    collection[i + 1] = temp;
                }
            }
        }
        return collection;
    }

    /// <summary>
    /// Сортировка методом пузырька (Оптимизированная)
    /// </summary>
    /// <param name="collection">Исходный массив</param>
    /// <returns>Отсортированный массив</returns>
    public static int[] SortBubbleOptimized(this int[] collection)
    {
         int size = collection.Length;

        for(int current = 0; current < size - 1; current++)
        {
            for(int i = 0; i < size - 1 - current; i++)
            {
                if(collection[i] > collection[i + 1])
                {
                    int temp = collection[i];
                    collection[i] = collection[i + 1];
                    collection[i + 1] = temp;
                }
            }
        }
        return collection;
    }

    /// <summary>
    /// Сортировка подсчетом
    /// </summary>
    /// <param name="collection">Исходный массив</param>
    /// <returns>Отсортированный массив</returns>
    // public static int[] SortCounting(this int[] collection)
    // {
    //     int size = collection.Length;

    //     int max = collection[0];
    //     for(int i = 1; i < size; i++)
    //         if(collection[i] > max) max = collection[i];
        
    //     int[] counter = new int[max + 1];
    //     for(int i = 0; i < size; i++)
    //     counter[collection[i]]++;

    //     // System.Console.WriteLine($"counter = [{String.Join(' ', counter)}]");
    //     int index = 0;
    //     for(int i = 0; i < max + 1; i++)
    //         for(int j = 0; j < counter[i]; j++)
    //             collection[index++] = i;

    //     return collection;
    // }

    /// <summary>
    /// Однопоточная сортировка подсчетом
    /// </summary>
    /// <param name="inputArray">Исходный массив</param>
    public static void CountingSort(int[] inputArray)
    {
        int[] counters = new int[10]; //массив повторений

        for (int i = 0; i < inputArray.Length; i++)
        {
            counters[inputArray[i]]++;
            // ourNumber = inputArray[i];
            // counters[ourNumber]++;
        }

        int index = 0;
        for (int i = 0; i < counters.Length; i++)
        {
            for (int j = 0; j < counters[i]; j++)
            {
                inputArray[index] = i;
                index++;
            }
        }
    }

    /// <summary>
    /// Двупоточная сортировка подсчетом
    /// </summary>
    /// <param name="inputArray">Исходный массив</param>
    /// <returns>Отсортированный массив</returns>
    public static int[] CountingSortExtended(int[] inputArray)
    {
        int max = inputArray.Max();
        int min = inputArray.Min();

        int offset = -min;
        int[] sortedArray = new int[inputArray.Length];
        int[] counters = new int[max + offset + 1];

        for (int i = 0; i < inputArray.Length; i++)
        {
            counters[inputArray[i] + offset]++;
        }

        int index = 0;
        for (int i = 0; i < counters.Length; i++)
        {
            for (int j = 0; j < counters[i]; j++)
            {
                sortedArray[index] = i - offset;
                index++;
            }
        }

        return sortedArray;
    }

    /// <summary>
    /// Однопоточная сортировка подсчетом
    /// </summary>
    /// <param name="InputArray">Исходный массив</param>
    /// <returns>Отсортированный массив</returns>
    public static int[] CountingSortExtended(int[] InputArray)
    {
        int max = InputArray.Max();
        int min = InputArray.Min();

        int offset = -min;

        int[] sortedArray = new int[InputArray.Length];
        int[] counters = new int[max + offset + 1];
        for (int i = 0; i < InputArray.Length; i++)
        {
            counters[InputArray[i] + offset]++;
        }

        int index = 0;
        for (int i = 0; i < counters.Length; i++)
        {
            for (int j = 0; j < counters[i]; j++)
            {
                sortedArray[index] = i - offset;
                index++;
            }
        }
        return sortedArray;
    }

    /// <summary>
    /// Быстрая сортировка
    /// </summary>
    /// <param name="collection">Исходный массив</param>
    /// <param name="left">Левый элемент</param>
    /// <param name="right">Правый элемент</param>
    /// <returns></returns>
    public static int[] SortQuick(this int[] collection, int left, int right)
    {
        int i = left;
        int j = right;

        int pivot = collection[Random.Shared.Next(left, right)];
        while (i <= j)
        {
            while (collection[i] < pivot) i++;
            while (collection[j] > pivot) j--;

            if (i <= j)
            {
                int t = collection[i];
                collection[i] = collection[j];
                collection[j] = t;
                i++;
                j--;
            }
        }
        if (i < right) SortQuick(collection, i, right);
        if (left < j) SortQuick(collection, left, j);

        return collection;
    }
}