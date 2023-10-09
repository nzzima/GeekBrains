// Задача 37. Найдите произведение пар числе в одномерном массиве. Парой считаем первый и
// последний элемент, второй и предпоследний и т.д. Результат в новом массиве.

void FillArray(int[] array)
{
    for(int index = 0; index < array.Length; index++) array[index] = new Random().Next(1, 10);
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

int[] PairProduct(int[] array)
{
    int product = 0;
    if(array.Length % 2 == 0)
    {
        int[] pairProducts = new int[array.Length/2];
        for(int index = 0; index < array.Length/2; index++)
        {
            product = array[index] * array[array.Length - index - 1];
            pairProducts[index] += product;
        }
        return pairProducts;
    }
    else
    {
        int[] pairProducts = new int[array.Length/2 + 1];
        for(int index = 0; index < array.Length/2 + 1; index++)
        {
            if(index == array.Length/2) product = array[index];
            else product = array[index] * array[array.Length - index - 1];

            pairProducts[index] += product;
        }
        return pairProducts;
    }
}

int[] array = new int[9];
FillArray(array);
PrintArray(array);
int[] result = PairProduct(array);
System.Console.Write($"\nPair products: ");
PrintArray(result);
