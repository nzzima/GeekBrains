// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет
//  строки на столбцы. В случае, если это невозможно, программа должна 
//  вывести сообщение для пользователя.

Console.WriteLine("Введите размероность массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размероность массива");
int columns = Convert.ToInt32(Console.ReadLine());

if(rows != columns)
{
    System.Console.WriteLine("Введите правильные числа");
    return;
}

int [,] array = new int[rows,columns]; 
int [,] array2 = new int[rows,columns]; 

int[,]  GetArray (int [,] array)
{
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

void ChangeArray(int[,] matrix,int[,] matrix2 )
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           matrix2[j,i]= matrix[i,j];
        }
    }
}

GetArray(array);
PrintArray(array);
ChangeArray(array,array2);
System.Console.WriteLine();
PrintArray(array2);