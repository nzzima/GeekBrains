// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int EnteringNum(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumNums(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

int number = EnteringNum("Enter number: ");
System.Console.WriteLine("Result = " + SumNums(number));