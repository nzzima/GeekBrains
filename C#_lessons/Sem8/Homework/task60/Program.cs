// Задача 60. Сформируйте трехмерный массив из неповторяющихся двузначных
// чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

int EnterValue(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int[,,] CreateMatrix(int r, int c, int v)
{
    int [,,] matrix = new int[r, c, v];
    int point = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = point;
                point++;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.WriteLine($"matrix[{i},{j},{k}] = {matrix[i,j,k]}");
            }
        }
    }
}

int A = EnterValue("Enter A: ");
int B = EnterValue("Enter B: ");
int C = EnterValue("Enter C: ");

int[,,] matrix = CreateMatrix(A, B, C);
PrintMatrix(matrix);