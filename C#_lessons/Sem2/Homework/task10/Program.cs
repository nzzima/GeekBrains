// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int Start()
{
    Console.Write("Enter number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool CheckNumber(int number)
{
    if ((number > 99) && (number < 1000))
    {
        Console.WriteLine("Check number: OK!");
        return true;
    }
    Console.WriteLine("Check number: OUT OF RANGE!");
    return false;
}

int number = Start();
if (CheckNumber(number))
{
    Console.WriteLine("Second rank --> " + number / 10 % 10);
}