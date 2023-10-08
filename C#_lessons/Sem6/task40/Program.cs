// Задача 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.

System.Console.Write("Enter first: ");
int A = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter sacond: ");
int B = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter third: ");
int C = Convert.ToInt32(Console.ReadLine());

void ExistTriangle(int A, int B, int C)
{
    if ((A < B + C) && (B < A + C) && (C < A + B))
    {
        System.Console.WriteLine("Triangle exist!");
    }
    else
    {
        System.Console.WriteLine("Triangle NOT exist!");
    }
}

ExistTriangle(A, B, C);