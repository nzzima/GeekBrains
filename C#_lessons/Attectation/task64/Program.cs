// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

System.Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

string PrintNumbers(int start, int end)
{
    if (start == end)
    {
        return start.ToString();
    }
    return start + " " + PrintNumbers(start - 1, end);
}

System.Console.WriteLine(PrintNumbers(number, 1));