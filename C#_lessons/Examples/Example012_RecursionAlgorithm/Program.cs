string[,] table = new string[2, 5];

// table[0,0]   table[0,1]  table[0,2]  table[0,3]  table[0,4]
// table[1,0]   table[1,1]  table[1,2]  table[1,3]  table[1,4]
// ...

table[1, 2] = "word";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         System.Console.WriteLine($"{table[rows, columns]}");
//     }
// }

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

int[,] matrix = new int[5, 5];

FillArray(matrix);
PrintArray(matrix);