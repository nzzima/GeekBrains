// Задача 60. Сформируйте трехмерный массив из неповторяющихся двузначных
// чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.

int EnterValue(string message)
{
    System.Console.Write(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int GenerateUniqueNumber(int[,,] matrix)
{
    while(true)
    {
        var n = new Random().Next(10, 100);
        if (!IsNumInMatrix(matrix, n)) return n;
    }
}

bool IsNumInMatrix(int[,,] matrix, int number)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i, j, k] == number) return true;
            }
        }
    }
    return false;
}

int[,,] CreateMatrix(int r, int c, int v)
{
    int [,,] matrix = new int[r, c, v];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = GenerateUniqueNumber(matrix);
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