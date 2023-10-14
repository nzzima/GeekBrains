using System;

public class Answer {
  public static double[, ] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom) {
        double[,] matrix = new double[m,n];
        Random rnd = new Random();
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[i, j] = Math.Round(rnd.NextDouble()*(maxLimitRandom - minLimitRandom)+minLimitRandom, 2);
            }
        }
        return matrix;
  }

  public static void PrintArray(double[, ] matrix) {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                System.Console.Write($"{matrix[i, j]}\t");
            }
            System.Console.WriteLine();
        }
  }

  public static void Main(string[] args) {
        int m, n, minLimitRandom, maxLimitRandom;

        if (args.Length >= 4) 
        {
            m = int.Parse(args[0]);
            n = int.Parse(args[1]);
            minLimitRandom = int.Parse(args[2]);
            maxLimitRandom = int.Parse(args[3]);

            double[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);

            int row1 = new Random().Next(0, m);
            int col1 = new Random().Next(0, n);
            int row2 = new Random().Next(0, m);
            int col2 = new Random().Next(0, n);
            int row3 = new Random().Next(0, m);
            int col3 = new Random().Next(0, n);

            bool isFractional1 = (array[row1, col1] % 1) != 0;
            bool isFractional2 = (array[row2, col2] % 1) != 0;
            bool isFractional3 = (array[row3, col3] % 1) != 0;

            if ((isFractional1 && isFractional2) || (isFractional1 && isFractional3) || (isFractional2 && isFractional3))
            {
                Console.WriteLine("Все ок!");
            }
            else
            {
                throw new Exception("Выбранные элементы не содержат по крайней мере два дробных числа.");
            }
        } 
        else 
        {
            m = 3;
            n = 4;
            minLimitRandom = -10;
            maxLimitRandom = 10;
            
            double[, ] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
            PrintArray(result);
        }
  }
}