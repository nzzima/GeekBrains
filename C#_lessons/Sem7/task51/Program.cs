// Задача 51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 

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
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int SumElems_on_Diag(int[,] matr)
{
    int sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == j) sum += matr[i, j];
            else continue;
        }
    }
    return sum;
}

int[,] matrix = new int[5, 5];
FillArray(matrix);
PrintArray(matrix);
int result = SumElems_on_Diag(matrix);
System.Console.WriteLine("Result summ elements on diagonal: " + result);