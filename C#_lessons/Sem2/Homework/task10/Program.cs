// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int temp1 = number / 10;
int temp2 = temp1 % 10;

Console.WriteLine("Result --> " + temp2);