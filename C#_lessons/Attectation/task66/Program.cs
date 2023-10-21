// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

System.Console.Write("Enter first number M: ");
int M = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter second number N: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = 0;

int PrintNumbers(int M, int N)
{    
    sum += M;
    if(M == N) return sum;
    return PrintNumbers(M+1, N);
}

sum = PrintNumbers(M, N);

System.Console.WriteLine($"Result sum from M to N: {sum}");