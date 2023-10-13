using System.Threading.Tasks.Dataflow;

/// <summary>
/// Класс МАССИВ
/// </summary>
public static class Infrastructure
{
    /// <summary>
    /// Метод создания и заполнения массива
    /// </summary>
    /// <param name="size">Размер нового массива</param>
    /// <param name="min">Нижняя граница заполнения</param>
    /// <param name="max">Верхняя граница заполнения</param>
    /// <returns>Новый массив</returns>
    public static int[] CreateArray(this int size, int min = 0, int max = 20)
    {
        return Enumerable.Range(1, size).Select(item => Random.Shared.Next(min, max)).ToArray();
    }
    
    /// <summary>
    /// Вывод массива в консоль
    /// </summary>
    /// <param name="array">Исходный массив</param>
    /// <param name="separator">Символ разделитель элементов массива</param>
    /// <returns></returns>
    public static int[] Show(this int[] array, string separator = ", ")
    {
        string output = String.Join(separator, array);
        System.Console.WriteLine($"[{output}]");
        return array;
    }
}