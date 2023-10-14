// Задача 50: Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.

using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
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
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k) //Damn shit code ^_^
    {
      int[,] matrix = new int[n, m];
      matrix[0, 0] = 1;
      for (int i = 0; i < n; i++)
      {
        for (int j = 0; j < m; j++)
        {
            if (i > 0)
            {
                if (j == 0) matrix[i, j] = matrix[i - 1, m - 1] + k;
                else matrix[i, j] = matrix[i, j - 1] + k;
            }
            else if (i == 0 && j == 0)
            {
                matrix[i, j] = 1;
            }
            else
            {
                matrix[i, j] = matrix[i, j - 1] + k;
            }
        }
      }
      return matrix;
    }
  
    public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
    {  
      int[] point = new int[2];
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == rowPosition && j == columnPosition)
            {
                point[0] = matrix[i, j];
                point[1] = 0;
                return point;
            }
        }
      }
      return point;
    }

    public static void PrintCheckIfError (int[] results, int X, int Y)
    {
        if (results[0] != 0 && results[1] == 0) Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
        else Console.WriteLine("There is no such index");
    }

    static public void Main(string[] args) {
        int n, m, k, x, y;

        if (args.Length >= 5) {
            n = int.Parse(args[0]);
            m = int.Parse(args[1]);
            k = int.Parse(args[2]);
            x = int.Parse(args[3]);
            y = int.Parse(args[4]);
        } else 
        {
            n = 3;
            m = 4;
            k = 3;
            x = 3;
            y = 3;
        }

        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}