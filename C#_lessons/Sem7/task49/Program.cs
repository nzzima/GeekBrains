// Задача 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса четные, и замените эти элементы
// на их квадраты.

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
            matr[i, j] = 2;//new Random().Next(1, 10);
        }
    }
}

void ReplaceElements_to_quadro(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == 0 || j == 0) continue;
            if ((i % 2 == 0) && (j % 2 == 0))
            {
                matr[i, j] *= matr[i, j];
            }
            else continue;
        }
    }
}

int m = EnterValue("Enter count of str: ");
int n = EnterValue("Enter count of stolb: ");

int[,] matrix = new int[m, n];

FillArray(matrix);
PrintArray(matrix);
System.Console.WriteLine();
ReplaceElements_to_quadro(matrix);
PrintArray(matrix);