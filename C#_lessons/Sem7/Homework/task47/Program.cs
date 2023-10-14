// Задача 47: Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.

int EnterValue(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

void FillArray(double[,] matr)
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = Math.Round(rnd.NextDouble()*(10 - 1) + 1, 2);
        }
    }
}

int m = EnterValue("Enter count of str: ");
int n = EnterValue("Enter count of stolb: ");

double[,] matrix = new double[m, n];
FillArray(matrix);
PrintArray(matrix);