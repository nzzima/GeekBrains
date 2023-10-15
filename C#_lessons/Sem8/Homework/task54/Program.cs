// Задача 54: Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.

int EnterValue(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,] GetArray (int rows, int columns)
{
    int [,] matr = new int[rows, columns];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,10);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matrix)
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

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

void SortingFromMaxToMin (int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        for(int j = i + 1; j < array.Length; j++)
        {
            if (array[i] < array[j])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}

void FromMaxToMinInMatr (int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        int[] str = new int[matrix.GetLength(1)];
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            str[j] += matrix[i,j];
            if (j == matrix.GetLength(1) - 1)
            {
                SortingFromMaxToMin(str);
                PrintArray(str);
                Array.Clear(str, 0, str.Length);
            }
        }
    }
}

int rows = EnterValue("Enter count of rows: ");
int columns = EnterValue("Enter count of columns: ");

int[,] matrix = GetArray(rows, columns);
PrintMatrix(matrix);
System.Console.WriteLine();
FromMaxToMinInMatr(matrix);