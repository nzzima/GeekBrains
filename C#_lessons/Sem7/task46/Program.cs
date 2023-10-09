// Задача 46. Задайте двумерный массив размером m*n, заполненный случайными целыми числами.

int EnterValue(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-100, 100);
        }
    }
}

int m = EnterValue("Enter count of str: ");
int n = EnterValue("Enter count of stolb: ");

int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);