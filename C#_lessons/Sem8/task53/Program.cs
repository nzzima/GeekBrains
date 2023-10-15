// Задача 53: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

Console.WriteLine("Введите размероность массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размероность массива");
int columns = Convert.ToInt32(Console.ReadLine());

int[,]  GetArray (int m, int n)
{
    int [,] array = new int[m,n]; 

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }

    return array;
}

void PrintArray(int[,] inputArray)    
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i,j]}\t");
        }
        Console.WriteLine();
    }
}

void ChangeArray(int[,] matrix)
{
    int rowsCount = matrix.GetLength(0)-1;

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0,i];
        matrix[0,i] =matrix[rowsCount,i];
        matrix[rowsCount,i]= temp;
    }
}

int[,] array2= GetArray(rows,columns);
PrintArray(array2);
ChangeArray(array2);
System.Console.WriteLine();
PrintArray(array2);