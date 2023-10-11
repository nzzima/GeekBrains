/// <summary>
/// Это класс, отвечающий за создание массива.
/// </summary>
public static class ArrayCreator
{
    /// <summary>
    /// Метод создания массива.
    /// </summary>
    /// <param name="n">Количество элементов</param>
    /// <returns>Массив</returns>
    public static int[] Create(this int n)
    {
        return new int[n];
    }

    /// <summary>
    /// Метод, который лепит массив в строку.
    /// </summary>
    /// <param name="array">Массив</param>
    /// <returns>Строка с представлением массива</returns>
    public static string ConvertToStringandPrintToTerminal(this int[] array)
    {
        string str = $"[{String.Join(',', array)}]";
        System.Console.WriteLine(str);
        return str;
    }

    /// <summary>
    /// Метод, заполняющий массив.
    /// </summary>
    /// <param name="array">Массив</param>
    /// <param name="min">Нижняя граница диапозона генератора случайный чисел</param>
    /// <param name="max">Верхняя граница диапозона генератора случайный чисел</param>
    public static int[] Fill(this int[] array, int min = 0, int max = 10, int seed = 0)
    {
        Random random = seed == 0 ? new Random() : new Random(seed);
        return array = array.Select(item => random.Next(min, max)).ToArray();
    }
}