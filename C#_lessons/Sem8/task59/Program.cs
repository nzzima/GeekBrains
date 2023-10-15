// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:


Console.Write("Введите размероность массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите размероность массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int minValue= int.MaxValue;
int minRows=0;
int minColumns= 0;

int[,] GetArray (int m, int n)
{
    int [,] array = new int[m,n]; 

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);

            if(array[i,j] <minValue)
            {
                minValue = array[i,j];
                minRows= i;
                minColumns = j;
            }
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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (minRows!= i && minColumns!=j)
            {
                Console.Write($"{matrix[i,j]}\t");
            }
        }
        Console.WriteLine();
    }
}

int[,] array2= GetArray(rows,columns);
PrintArray(array2);
System.Console.WriteLine();
ChangeArray(array2);