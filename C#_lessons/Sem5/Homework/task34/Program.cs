void FillArray(int[] array)
{
    for(int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(100, 1000);
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

int CountOfEven(int[] array)
{
    int count = 0;
    for(int index = 0; index < array.Length; index++)
    {
        if(array[index] % 2 == 0) count++;
        else continue;
    }
    return count;
}

int[] array = new int[5];
FillArray(array);
PrintArray(array);
int countOfEven = CountOfEven(array);
System.Console.WriteLine($"\nCount of even numbers = {countOfEven}");