// Задача 31. Задайте массив из 12 элементов, заполненнный случайными числами из промежутка
// [-9, 9]. Найдити сумму отриц. и положит. элементов массива.

void FillArray(int[] array)
{
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] array)
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

int[] Sum (int[] array)
{
    int[] all_sum = new int[2];
    int sumPositive = 0, sumNegative = 0;
    for(int index = 0; index < array.Length; index++)
    {
        if (array[index] > 0) sumPositive += array[index];
        else if (array[index] < 0) sumNegative += array[index];
    }
    all_sum[0] = sumNegative;
    all_sum[1] = sumPositive;
    return all_sum;
}

int[] array = new int[12];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();

int[] result = Sum(array);
System.Console.WriteLine($"Sum of negative = {result[0]} \nSum of positive = {result[1]}");