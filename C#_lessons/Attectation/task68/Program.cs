// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

System.Console.Write("Enter m: ");
int m = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());

bool CheckNumbers (int first, int second)
{
    if (first > 0 && second > 0) return true;
    return false;
}

int Akkerman(int m, int n)
{
    if (m == 0) return n + 1;
    else
    {
        if(m != 0 && n == 0) return Akkerman(m - 1, 1);
        else return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}

if (CheckNumbers(m, n))
{
    int result = Akkerman(m, n);
    System.Console.WriteLine($"Result Akkerman: A(m,n) = {result}");
}