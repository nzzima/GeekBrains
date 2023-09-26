// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int number = new Random().Next(100,1000);
Console.WriteLine("Entered number --> " + number);

int temp1 = number / 10;
int temp2 = temp1 % 10;

Console.WriteLine("Result --> " + temp2);