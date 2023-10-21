// Задача 67: напишите программу, которая будет принимать на вход
// число и возвращать сумму его цифр.

System.Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;

int GetSum(int number)
{
    sum += number % 10;
    if(number == 0) return sum;
    return GetSum(number / 10);
}

sum = GetSum(number);
System.Console.WriteLine($"Result sum = {sum}");