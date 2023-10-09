// Задача 38. Задайте массив вещественных чисел. Найдите разницу max - min э-тов массива. 

void FillArray(double[] array)
{
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().NextDouble() * 100;
    }
}

void PrintArray(double[] array)
{
    System.Console.Write("[");
    for(int index = 0; index < array.Length; index++)
    {
        if (index == array.Length - 1)
        {
            System.Console.Write($"{array[index]}");

        }
        else System.Console.Write($"{array[index]}" + ", ");
    }
    System.Console.Write("]");
}

double DiffMaxMin(double[] array)
{
    double min = array[0];
    double max = array[1];
    for(int index = 0; index < array.Length; index++)
    {
        if(array[index] > max) max = array[index];
        else if (array[index] < min) min = array[index];
        else continue;
    }
    System.Console.WriteLine("\nMax = " + max);
    System.Console.WriteLine("Min = " + min);
    return max - min;
}

double[] array = new double[10];
FillArray(array);
PrintArray(array);

double diff = DiffMaxMin(array);
System.Console.WriteLine($"Difference Max and Min = {diff}");