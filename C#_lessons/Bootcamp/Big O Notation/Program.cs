// int n = 5;
// int[] array = new int[n];

// for (int i = 0; i < n; i++)
//     array[i] = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("[" + string.Join(", ", array) + "]");

// int sum = 0;
// for (int i = 0; i < n; i++)
//     sum += array[i];
// System.Console.WriteLine(sum);

//O(n)--------------------------------------------------------------------

int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
for(int i = 1; i <= n; i++)
{
    for(int j = 1; j <= n; j++)
    {
        if(i + j <= n)
        {
            matrix[i, j] = i * j;
            matrix[j, i] = i * j;
        }
        // System.Console.Write(i * j);
        // System.Console.Write("\t");
    }
    System.Console.WriteLine();
}
// O(n^2)