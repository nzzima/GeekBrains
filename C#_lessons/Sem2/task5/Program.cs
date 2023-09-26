// Задача 5.
// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

int num1 = new Random().Next(100,1000);
Console.WriteLine(num1);

int num2 = new Random().Next(100,1000);
Console.WriteLine(num2);
// int num1 = 5;
// int num2 = 25;

if(num1 == num2*num2 || num2 == num1*num1)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}