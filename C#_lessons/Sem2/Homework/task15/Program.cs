// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Enter week day: ");
int day = Convert.ToInt32(Console.ReadLine());

if ((day == 6) || (day == 7))
{
    Console.WriteLine("It's weekend day!");
}
else
{
    Console.WriteLine("It's no weekend day!");
}