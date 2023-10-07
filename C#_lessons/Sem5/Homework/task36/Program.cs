void FillArray(int[] array)
{
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(-100, 100);
    }
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for(int index = 0; index < array.Length; index++)
    {
        if (index == array.Length - 1) System.Console.Write($"{array[index]}");
        else System.Console.Write($"{array[index]}" + ", ");
    }
    System.Console.Write("]");
}

int SumOnNotEvenInd(int[] array)
{
    int sum = 0;
    for(int index = 1; index < array.Length; index++)
    {
        if(index % 2 != 0) sum += array[index];
    }
    return sum;
}

int[] array = new int[6];
FillArray(array);
PrintArray(array);
int sum = SumOnNotEvenInd(array);
System.Console.WriteLine($"\nSum of numbers on not even index = {sum}");