// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

using static MatrixCreator;

void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
{
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        System.Console.WriteLine("It is impossible to multiply.");
    }
    else
    {
        MatrixMultiplication(matrixA, matrixB).PrintMatrix();
    }
}

int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
{
    int[,] multiplyMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int k = 0; k < matrixB.GetLength(0); k++)
            {
                multiplyMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }
    return multiplyMatrix;
}

int rowsA = EnterValue("Enter count of rows in matrixA: ");
int columnsA = EnterValue("Enter count of columns in matrixA: ");

int rowsB = EnterValue("Enter count of rows in matrixB: ");
int columnsB = EnterValue("Enter count of columns in matrixB: ");

int[,] matrixA = CreateMatrix(rowsA, columnsA);
matrixA.PrintMatrix();
System.Console.WriteLine();

int[,] matrixB = CreateMatrix(rowsB, columnsB);
matrixB.PrintMatrix();
System.Console.WriteLine();

MultiplyIfPossible(matrixA, matrixB);