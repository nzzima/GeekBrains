// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом
// столбце.

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
            System.Console.Write($"{matr[i, j]}\t");
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

double[] AverageInColumn(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    for(int i = 0; i < matrix.GetLength(1); i++)
    {
        int sum_elems_in_column = 0;
        
        for(int j = 0; j < matrix.GetLength(0); j++)
        {
            sum_elems_in_column += matrix[j,i];
        }
        System.Console.WriteLine(sum_elems_in_column);
        average[i] += (double)sum_elems_in_column / matrix.GetLength(0);
    }
    return average;
}

void PrintListAvr (double [] list)
    {
        Console.WriteLine($"The averages in columns are:");
        for (int i = 0; i < list.Length; i++)
        {
            if (i == list.Length - 1) Console.Write($"{list[i].ToString("0.00")}");
            else Console.Write($"{list[i].ToString("0.00")}\t");
        }
    }

int m = EnterValue("Enter count of str: ");
int n = EnterValue("Enter count of stolb: ");

int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);

System.Console.WriteLine();

PrintListAvr(AverageInColumn(matrix));