// Задача 65. Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.

System.Console.Write("Enter first number M: ");
int M = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter second number N: ");
int N = Convert.ToInt32(Console.ReadLine());

void PrintNumbers(int M, int N)
{
    System.Console.Write(M + " ");
    
    if(M == N) return;
    else PrintNumbers(M+1, N);
}

PrintNumbers(M, N);