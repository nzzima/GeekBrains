// Задача 56: Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

using static MatrixCreator;

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int SumOrRow(int[,] matrix, int row)
{
    int sum = 0;
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[row, j];
    }
    return sum;
}

int[] MinimumSumRow(int[,] matrix)
{
    int[] array = new int[2];
    array[1] = int.MaxValue;

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = SumOrRow(matrix, i);
        if (sum < array[1])
        {
            array[0] = i;
            array[1] = sum;
        }
        else continue;
    }
    return array;
}

int rows = EnterValue("Enter count of rows: ");
int columns = EnterValue("Enter count of columns: ");

int[,] matrix = CreateMatrix(rows, columns);
matrix.PrintMatrix();
System.Console.WriteLine();
int[] result = MinimumSumRow(matrix);
PrintArray(result);