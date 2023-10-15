/// <summary>
/// Class with creating matrix
/// </summary>
public static class MatrixCreator
{
    /// <summary>
    /// Enter rows and columns count
    /// </summary>
    /// <param name="message">Message to terminal</param>
    /// <returns>Value</returns>
    public static int EnterValue(string message)
    {
        System.Console.Write(message);
        int value = Convert.ToInt32(Console.ReadLine());
        return value;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="rows">Count of rows</param>
    /// <param name="columns">Count of columns</param>
    /// <returns>Matrix</returns>
    public static int[,] CreateMatrix(int rows, int columns)
    {
        int [,] matrix = new int[rows, columns];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i,j] = new Random().Next(0,10);
            }
        }
        return matrix;
    }

    /// <summary>
    /// Show matrix in terminal
    /// </summary>
    /// <param name="matrix">Matrix</param>
    public static void PrintMatrix(this int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write($"{matrix[i, j]}\t");
            }
            System.Console.WriteLine();
        }
    }
}