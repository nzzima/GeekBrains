int[] array = {11, 28, 365, 443, 523, 64, 7545, 443, 92};

int size = array.Length;
int find = 443;
int index = 0;

while (index < size)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}