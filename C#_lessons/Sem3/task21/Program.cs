// Задача 21: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.

Console.Write("Enter first X1: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter first Y1: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second X2: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second Y2: ");
int Y2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((X2 - X1)*(X2 - X1) + (Y2 - Y1)*(Y2 - Y1));
Console.Write("S = " + result);